using System;
using Lib1;
using Lib2;

namespace MainProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib1 = new Lib1Class1();
            Console.WriteLine($"Lib1 DoWork(): {lib1.DoWork()}");
            var lib2 = new Lib2Class1();
            Console.WriteLine($"Lib2 DoWork(): {lib2.DoLib2Work()}");
        }
    }
}