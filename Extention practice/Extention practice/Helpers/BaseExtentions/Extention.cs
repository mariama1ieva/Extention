using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extention_practice.Helpers.BaseExtentions
{
    public static class Extention
    {
        public static void ShowNum(this int num,int num1)
        {
            Console.WriteLine(num+num1);
        }

        public static int ShowSumOfNumber(this int number,int number2)
        {
            return number + number2;
        }

        public static bool CheckDigit(this string str)
        {
            return Regex.IsMatch( str,@"\d");
        }

        public static bool CheckText(this string text,string pattern)
        {
            return Regex.IsMatch( text,pattern);
        }

        public static bool CheckDigitForStr(this string str)
        {
            
            return Regex.IsMatch(str, @"\d");
        }
        public static int FindFactorial(this int num)
        {
            var factorial = 1;
            for(int i = 1; i <=num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static bool CheckLogin(this string str,string pattern)
        {
            var res = Regex.IsMatch(str, pattern);
            return res;
        }

        public static double PowOfNum(this double num,int pow)
        {
            return Math.Pow(num,pow);
        }

        public static bool IsConvertStringToNumber(this string str)
        {
            var res=int.TryParse(str, out int result);
            return res;
        }


        public static bool CheckStr(this string str,string pattern)
        {
            var res= Regex.IsMatch(str,pattern);
            return res;
        }
    }
}
