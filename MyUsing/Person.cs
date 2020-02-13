using System;

namespace MyUsing
{
    internal class Person : IDisposable
    {
        public string Name { get; set; }
        public void Dispose()
        {
            Console.WriteLine("Dis");
        }
    }
}