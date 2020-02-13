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
            using Person tom = new Person { Name = "Tom" };
            using Person bob = new Person { Name = "Bob" };
            Console.WriteLine($"Some actions {tom.Name} and {bob.Name}");
            Console.WriteLine("End method");
        }
    }
}
