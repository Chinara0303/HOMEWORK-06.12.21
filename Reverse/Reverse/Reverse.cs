using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            Console.Write("Enter String:");
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    result +=ReverseString ( arr[i]) + " ";
                }
                else
                {
                    result += ReverseString (arr[i]);
                }
            }
            Console.WriteLine("Reverse String :{0}", result);
            Console.ReadLine();



            static string ReverseString(string str)
            {
                string result = String.Empty;

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
                return result;

            }





        }
    }

}
