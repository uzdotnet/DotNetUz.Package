using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetUz.Tools
{
    public static class Converter
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
        public static bool IsOdd(this int number)
        {
            return number % 2 == 1;
        }
    }
}
