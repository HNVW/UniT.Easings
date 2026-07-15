#nullable enable
namespace UniT.Easings
{
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using Extensions;
    using UnityEngine;

    public static class ColorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ChangeColorAsync(this SpriteRenderer target, Color begin, Color end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this SpriteRenderer target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ChangeColorAsync(this SpriteRenderer target, Color end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeColorAsync(target.color, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this SpriteRenderer target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.color.a, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeInAsync(this SpriteRenderer target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeOutAsync(this SpriteRenderer target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ChangeColorAsync(this Material target, Color begin, Color end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this Material target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ChangeColorAsync(this Material target, Color end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeColorAsync(target.color, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this Material target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.color.a, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeInAsync(this Material target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeOutAsync(this Material target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, duration, function, timer, timing, cancellationToken);
        }
    }
}