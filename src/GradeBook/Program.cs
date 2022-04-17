// See https://aka.ms/new-console-template for more information
using System;
namespace GradeBook 
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new[]{11,12,13,14,15};
            var list = new List<int>{11,12,13,14,15};
            var b=0;
            foreach(var num in list)
            {
                 b = b + num ; 
            }
            Console.WriteLine(b);
            int n = add(5,6);
            Console.WriteLine(n);
            Console.WriteLine(IsOdd(5));
           //  Console.WriteLine($"Hello, {args[0]} , {args[1]}!");
        }

        public static int add(int a, int b)
        {
            return a+b ;
        }
        public static bool IsOdd(int val)
        {
            return val % 2 == 1 ;
        }
    }

}

