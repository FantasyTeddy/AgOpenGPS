using AgOpenGPS.Core.Models;

namespace AgOpenGPS.Core.Drawing
{
    public static class Colors
    {
        // Physical colors
        public static readonly ColorRgba Black = new(0, 0, 0);
        public static readonly ColorRgba White = new(255, 255, 225);
        public static readonly ColorRgba Red = new(255, 0, 0);
        public static readonly ColorRgba Green = new(0, 255, 0);
        public static readonly ColorRgba Yellow = new(255, 255, 0);
        public static readonly ColorRgba Gray012 = new(0.12f, 0.12f, 0.12f);
        public static readonly ColorRgba Gray025 = new(0.25f, 0.25f, 0.25f);

        // Functional colors
        public static readonly ColorRgba AntennaColor = new(0.20f, 0.98f, 0.98f);
        public static readonly ColorRgba BingMapBackgroundColor = new(0.6f, 0.6f, 0.6f, 0.5f);
        public static readonly ColorRgba FlagSelectedBoxColor = new(0.980f, 0.0f, 0.980f);

        public static readonly ColorRgba GoalPointColor = new(0.98f, 0.98f, 0.098f);
        public static readonly ColorRgba HarvesterWheelColor = new(20, 20, 20);

        public static readonly ColorRgba HitchColor = new(0.765f, 0.76f, 0.32f);
        public static readonly ColorRgba HitchTrailingColor = new(0.7f, 0.4f, 0.2f);
        public static readonly ColorRgba HitchRigidColor = new(0.237f, 0.037f, 0.0397f);

        public static readonly ColorRgba SvenArrowColor = new(0.95f, 0.95f, 0.10f);

        public static readonly ColorRgba TramDotManualFlashOffColor = new(0.0f, 0.0f, 0.0f, 0.993f);
        public static readonly ColorRgba TramDotManualFlashOnColor = new(0.99f, 0.990f, 0.0f, 0.993f);
        public static readonly ColorRgba TramDotAutomaticControlBitOffColor = new(0.9f, 0.0f, 0.0f, 0.53f);
        public static readonly ColorRgba TramDotAutomaticControlBitOnColor = new(0.29f, 0.990f, 0.290f, 0.983f);
        public static readonly ColorRgba TramMarkerOnColor = new(0.0f, 0.900f, 0.39630f);

        public static readonly ColorRgba WorldGridDayColor = Gray012;
        public static readonly ColorRgba WorldGridNightColor = Gray025;
    }
}
