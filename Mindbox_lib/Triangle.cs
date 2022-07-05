using System;

namespace Mindbox_lib
{
    public class Triangle
    {
        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                return true;
            }
            else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                return true;
            }
            else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                return true;
            }
            else // 3 sides method
            {
                return false;
            }
        }
    }
}