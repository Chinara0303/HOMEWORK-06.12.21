using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = String.Empty;
            //string str = Console.ReadLine();
            //string[] arr = str.Split(" ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i != arr.Length - 1)
            //    {
            //        result += (arr[i]) + " ";
            //    }
            //    else
            //    {
            //        result += (arr[i]);
            //    }
            //}
            Reverse reverseword1 = new Reverse();
            reverseword1.ReverseString("Hello world"); 
            Console.WriteLine(reverseword1.ReverseString("Hello world"));
            //Console.ReadLine();

        }
    }
}
