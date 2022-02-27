using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Utils
{
    public static class Utils
    {
        public static string coinToMoney(int price)
        {
            string result = (price / 100).ToString();
            if (price % 100 != 0)
            {
                result += "." + (price % 100).ToString();
            }
            result += " ₼";
            return result;
        }
    }
}
