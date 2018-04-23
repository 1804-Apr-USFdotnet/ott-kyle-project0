using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newBool;
            
            Test pal = new Test();
            pal.Str = Console.ReadLine();
            newBool = pal.IsPalindrome(pal.Str);
            Console.WriteLine(newBool);
            Console.ReadLine();
        }
    }
}
