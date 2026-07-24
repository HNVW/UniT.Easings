#nullable enable
namespace UniT.Easings
{
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using Extensions;
    using UnityEngine;

    public static class TransformExtensions
    {
        #region Move

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPosition, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPositionX, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPositionY, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPositionZ, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveAsync(this Transform target, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveAsync(target.position, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveXAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveXAsync(target.position.x, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveYAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveYAsync(target.position.y, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask MoveZAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveZAsync(target.position.z, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ResetPositionAsync(this Transform target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveAsync(Vector3.zero, duration, function, timer, timing, cancellationToken);
        }

        #endregion

        #region LocalMove

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPosition, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPositionX, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPositionY, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPositionZ, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveAsync(this Transform target, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveAsync(target.localPosition, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveXAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveXAsync(target.localPosition.x, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveYAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveYAsync(target.localPosition.y, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalMoveZAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveZAsync(target.localPosition.z, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ResetLocalPositionAsync(this Transform target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveAsync(Vector3.zero, duration, function, timer, timing, cancellationToken);
        }

        #endregion

        #region Rotate

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngle, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngleX, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngleY, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngleZ, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(target.eulerAngles, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateXAsync(this Transform target, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateXAsync(target.eulerAngles.x, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateYAsync(this Transform target, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateYAsync(target.eulerAngles.y, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateZAsync(this Transform target, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateZAsync(target.eulerAngles.z, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(begin.eulerAngles, end.eulerAngles, duration, function, false, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask RotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(target.rotation, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ResetRotationAsync(this Transform target, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(Vector3.zero, duration, function, normalize, timer, timing, cancellationToken);
        }

        #endregion

        #region LocalRotate

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngle, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngleX, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngleY, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngleZ, normalize ? NormalizeRotation(begin, end) : begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(target.localEulerAngles, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateXAsync(this Transform target, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateXAsync(target.localEulerAngles.x, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateYAsync(this Transform target, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateYAsync(target.localEulerAngles.y, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateZAsync(this Transform target, float end, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateZAsync(target.localEulerAngles.z, end, duration, function, normalize, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(begin.eulerAngles, end.eulerAngles, duration, function, false, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalRotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(target.localRotation, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ResetLocalRotationAsync(this Transform target, float duration, Easing.Function? function = null, bool normalize = true, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(Vector3.zero, duration, function, normalize, timer, timing, cancellationToken);
        }

        #endregion

        #region Scale

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScale, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScaleX, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScaleY, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScaleZ, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleAsync(this Transform target, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleAsync(target.lossyScale, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleXAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleXAsync(target.lossyScale.x, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleYAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleYAsync(target.lossyScale.y, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleZAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleZAsync(target.lossyScale.z, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleAsync(new Vector3(begin, begin, begin), new Vector3(end, end, end), duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask ScaleAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleAsync(new Vector3(end, end, end), duration, function, timer, timing, cancellationToken);
        }

        #endregion

        #region LocalScale

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScale, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScaleX, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScaleY, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScaleZ, begin, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleAsync(this Transform target, Vector3 end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(target.localScale, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleXAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleXAsync(target.localScale.x, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleYAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleYAsync(target.localScale.y, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleZAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleZAsync(target.localScale.z, end, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleAsync(this Transform target, float begin, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(new Vector3(begin, begin, begin), new Vector3(end, end, end), duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleAsync(this Transform target, float end, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(new Vector3(end, end, end), duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleInAsync(this Transform target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(1, duration, function, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask LocalScaleOutAsync(this Transform target, float duration, Easing.Function? function = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(0, duration, function, timer, timing, cancellationToken);
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector3 NormalizeRotation(Vector3 begin, Vector3 end)
        {
            begin.x = NormalizeRotation(begin.x, end.x);
            begin.y = NormalizeRotation(begin.y, end.y);
            begin.z = NormalizeRotation(begin.z, end.z);
            return begin;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float NormalizeRotation(float begin, float end)
        {
            return begin - 360 * Mathf.Round((begin - end) / 360);
        }
    }
}