using System;

namespace Aplicatie01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int c;
            c = n1 + n2;
            Console.WriteLine("Suma este : {0}", c);
        }
    }
}
