using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Palindrome

{
    public class PalindromeCheck
    {
         public static bool PalindromeChecker(string pali)
        {
            
            int min = 0;
            int max = pali.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = pali[min];
                char b = pali[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
