using System;

namespace DotNetUz.Tools
{
    public static class Converter
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
        public static double ToDouble(this string str)
        {
            return double.Parse(str);
        }
    }
}
