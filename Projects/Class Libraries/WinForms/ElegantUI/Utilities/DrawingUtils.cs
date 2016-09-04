namespace ElegantUI.Utilities
{
    class DrawingUtils
    {
        public static int TransformValue(int value, int max, int targetMax)
        {
            return (int)(((float)value / (float)max) * targetMax);
        }

        public static float TransformValue(float value, float max, float targetMax)
        {
            return (value / max) * targetMax;
        }
    }
}
