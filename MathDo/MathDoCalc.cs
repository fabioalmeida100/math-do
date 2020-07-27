using System;

namespace MathDo
{
    public static class MathDoCalc
    {
        public static double Truncate(double value, int decimalPlace)
        {
            var multi = Math.Pow(10, decimalPlace);
            return Math.Truncate(multi * value) / multi;
        }
    }
}
