using System;
namespace SophiAppConsole.Helpers
{

    public static class MathHelper
    {
       
        public static decimal Add(decimal value1, decimal value2)
        {
            decimal result = value1 + value2;
            return result;
        }
        public static decimal Subtract(decimal value1, decimal value2)
        {
            decimal result = value1 - value2;
            return result;
        }
        public static decimal Multiplication(decimal value1, decimal value2)
        {
            decimal result = value1 * value2;
            return result;
        }
        public static decimal Division(decimal value1, decimal value2)
        {
            decimal result = value1 / value2;
            return result;
        }
    }
}
