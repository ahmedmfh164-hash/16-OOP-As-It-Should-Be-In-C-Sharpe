using System;
using MyFirstClassLibrary;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMyMath myMath = new clsMyMath();

            Console.WriteLine(myMath.Sum(10, 20));

            Console.ReadKey();

        }
    }
}
