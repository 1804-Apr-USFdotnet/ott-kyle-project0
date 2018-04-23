using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class Class1
    {
        public static bool IsPalindrome(String str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
