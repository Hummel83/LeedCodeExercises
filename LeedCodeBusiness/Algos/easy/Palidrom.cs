using System;
using System.Linq;

namespace LeedCodeBusiness.Algos.easy
{
    //Number 9
    public class Palidrom
    {
        public bool IsPalindrome(long x)
        {
            bool pali = false;

            var abs = string.Concat(Math.Abs(x).ToString().Reverse());
            var muh = long.Parse(abs);
            if (muh == x)
            {
                pali = true;
            }
            return pali;
        }
    }
}