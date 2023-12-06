using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string response)
        {
            var reversed = ""; 

           for (int i = response.Length - 1; i >= 0; i--)
            {
                reversed += response[i];
            }
           if (reversed == response)
            {
                return true; 
            }
           else
            {
                return false;
            }
        }
    }
}
