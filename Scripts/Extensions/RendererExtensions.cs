#nullable enable
namespace UniT.Easings
{
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static class RendererExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask BlendAsync(this SkinnedMeshRenderer target, int index, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(value => target.SetBlendShapeWeight(index, value), begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask BlendAsync(this SkinnedMeshRenderer target, int index, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.BlendAsync(index, target.GetBlendShapeWeight(index), end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask BlendInAsync(this SkinnedMeshRenderer target, int index, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.BlendAsync(index, 0, 100, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask BlendOutAsync(this SkinnedMeshRenderer target, int index, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.BlendAsync(index, 100, 0, duration, function, timer, timing, cancellationToken);
        }
    }
}