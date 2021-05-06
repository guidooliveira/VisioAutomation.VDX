namespace VisioAutomation.Power.ShapeSheet
{
    public static class Converter
    {
        public static double PointsToInches(double points)
        {
            return points/72.0;
        }
    }
}