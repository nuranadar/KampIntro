using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FourOperation fourOperation = new FourOperation();
            fourOperation.Addition(1, 19);
            fourOperation.Addition(18, 12);
        }
    }
}
