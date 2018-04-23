using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChallenge
{
    public class Test
    {
        public string Str { get; set; }
        public bool IsPalindrome(string str)
        {
            str = Str.ToLower();
            return str.SequenceEqual(str.Reverse());
        }
    }
}
