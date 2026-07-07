#nullable enable
namespace UniT.Easings
{
    using UnityEngine;

    public static partial class Easing
    {
        public delegate float Timer();

        public static readonly Timer DeltaTime = static () => Time.deltaTime;

        public static readonly Timer UnscaledDeltaTime = static () => Time.unscaledDeltaTime;

        public static readonly Timer FixedDeltaTime = static () => Time.fixedDeltaTime;

        public static readonly Timer FixedUnscaledDeltaTime = static () => Time.fixedUnscaledDeltaTime;

        public static Timer DefaultTimer { get; set; } = DeltaTime;
    }
}