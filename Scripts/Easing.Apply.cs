#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UniT.Extensions;
    using UnityEngine;

    public static partial class Easing
    {
        [DefaultExecutionOrder(short.MinValue)]
        private sealed class UpdaterMono : MonoBehaviour
        {
            private struct Data
            {
                public readonly Action<float> action;
                public readonly float duration;
                public readonly Function easing;
                public readonly Timer timer;
                public readonly Timing timing;
                public readonly CancellationToken cancellationToken;
                public readonly UniTaskCompletionSource completionSource;

                public float time;

                public Data(Action<float> action, float duration, Function easing, Timer timer, Timing timing, CancellationToken cancellationToken, UniTaskCompletionSource completionSource)
                {
                    this.action = action;
                    this.duration = duration;
                    this.easing = easing;
                    this.timer = timer;
                    this.timing = timing;
                    this.cancellationToken = cancellationToken;
                    this.completionSource = completionSource;
                    this.time = 0;
                }
            }

            private readonly List<Data> dataList = new();

            private void Update() => this.Update(Timing.Update);

            private void LateUpdate() => this.Update(Timing.LateUpdate);

            private void FixedUpdate() => this.Update(Timing.FixedUpdate);

            private void Update(Timing timing)
            {
                for (var i = 0; i < this.dataList.Count;)
                {
                    var data = this.dataList[i];
                    if (data.timing != timing)
                    {
                        ++i;
                        continue;
                    }
                    if (data.cancellationToken.IsCancellationRequested)
                    {
                        data.completionSource.TrySetCanceled(data.cancellationToken);
                        this.dataList.RemoveAtSwapBack(i);
                        continue;
                    }
                    data.time += data.timer();
                    if (data.time >= data.duration)
                    {
                        data.action(data.easing(1));
                        data.completionSource.TrySetResult();
                        this.dataList.RemoveAtSwapBack(i);
                        continue;
                    }
                    data.action(data.easing(data.time / data.duration));
                    this.dataList[i] = data;
                    ++i;
                }
            }

            public UniTask Add(Action<float> action, float duration, Function easing, Timer timer, Timing timing, CancellationToken cancellationToken)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return UniTask.FromCanceled(cancellationToken);
                }
                if (duration <= 0)
                {
                    action(1);
                    return UniTask.CompletedTask;
                }
                var completionSource = new UniTaskCompletionSource();
                this.dataList.Add(new(action, duration, easing, timer, timing, cancellationToken, completionSource));
                return completionSource.Task;
            }
        }

#if UNITY_EDITOR
        private static UpdaterMono? updater;

        private static UpdaterMono Updater => updater = updater.NullIfDestroyed() ?? new GameObject(nameof(Easing)).AddComponent<UpdaterMono>().DontDestroyOnLoad();
#else
        private static readonly UpdaterMono Updater = new GameObject(nameof(Easing)).AddComponent<UpdaterMono>().DontDestroyOnLoad();
#endif

        public static UniTask Apply(Action<float> action, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, CancellationToken cancellationToken = default)
        {
            return Updater.Add(action, duration, easing ?? DefaultFunction, timer ?? DefaultTimer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask Apply(Action<float> action, float begin, float end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, CancellationToken cancellationToken = default)
        {
            var diff = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Apply(wrapper, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask Apply(Action<int> action, int begin, int end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, CancellationToken cancellationToken = default)
        {
            var last = int.MinValue;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask Apply(Action<Vector3> action, Vector3 begin, Vector3 end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, CancellationToken cancellationToken = default)
        {
            var diff = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Apply(wrapper, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask Apply(Action<Color> action, Color begin, Color end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, CancellationToken cancellationToken = default)
        {
            var diff = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Apply(wrapper, duration, easing, timer, timing, cancellationToken);
        }
    }
}