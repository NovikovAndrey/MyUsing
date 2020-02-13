using System;

namespace MyUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey(); ;
        }
        private static void Test()
        {
            using Person p = new Person { Name = "Tom" } ;
            Console.WriteLine($"Some actions {p.Name}");
            Console.WriteLine("End method");
        }
    }
}
