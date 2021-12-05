using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Reverse
    {
        public string ReverseString(string str)
        {
            //string[] arr = str.Split(" ");
            string result = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
            
        }

    }
}
