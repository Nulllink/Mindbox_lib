using System;

namespace Mindbox_lib
{
    public static class AreaOf
    {
        public static double CircleByRadius(double r)
        {
            return Math.Round(Math.PI * Math.Pow(r,2),4);
        }

        public static double TriangleBy3Sides(double a, double b, double c)
        {
            double p = 0.5 * (a + b + c);
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),4);
        }

        #region without knowledge of figure type

        public static double AnyFigure(double r)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2), 4);
        }

        public static double AnyFigure(double a, double b, double c)
        {
            double p = 0.5 * (a + b + c);
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 4);
        }
        #endregion
    }
    
}