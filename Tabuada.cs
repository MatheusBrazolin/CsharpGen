using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuadas");

            for (int b = 1; b <= 10; b++)
            {
                for (int p = 1; p <= 10; p++)
                {
                    Console.WriteLine($"{b} x {p} = {b*p}" );
                    }
            }
        }
    }
}
