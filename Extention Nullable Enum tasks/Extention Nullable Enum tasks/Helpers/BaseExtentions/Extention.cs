using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extention_Nullable_Enum_tasks.Helpers.BaseExtentions
{
    public static class Extention
    {
        public static bool CheckEmail(this string email, string pattern)
        {
            var result = Regex.IsMatch(email, pattern);
            return result;

        }
        public static string GetFullName(this string name, string surname)
        {
            return name + " " + surname;
        }
        public static int MultipleOfNums(this int[] nums)
        {
            int multiple = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                multiple *= nums[i];
            }
            return multiple;
        }
    }
}
