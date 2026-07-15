#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using Extensions;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public static class UIExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideAsync(this Slider target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetValue, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideAsync(this Slider target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(target.value, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideInAsync(this Slider target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(0, 1, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideOutAsync(this Slider target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(1, 0, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillAsync(this Image target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetFillAmount, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillAsync(this Image target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(target.fillAmount, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillInAsync(this Image target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(0, 1, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillOutAsync(this Image target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(1, 0, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask CountAsync(this Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask CountAsync(this Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask CountAsync(this TMP_Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask CountAsync(this TMP_Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ChangeColorAsync(this Graphic target, Color begin, Color end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this Graphic target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ChangeColorAsync(this Graphic target, Color end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeColorAsync(target.color, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this Graphic target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.color.a, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeInAsync(this Graphic target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeOutAsync(this Graphic target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this CanvasGroup target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeAsync(this CanvasGroup target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.alpha, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeInAsync(this CanvasGroup target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FadeOutAsync(this CanvasGroup target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, duration, function, timer, timing, cancellationToken);
        }
    }
}