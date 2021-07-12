using System;
using Lib2;

namespace MainProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib2 = new Lib2Class1();
            Console.WriteLine($"Lib2 DoWork(): {lib2.DoLib2Work()}");
        }
    }
}