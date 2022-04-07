using System;

namespace ExTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Tabuada");
            Console.WriteLine("Insira o numero que voce quer multiplicar");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int x = 1; x <= 10; x++)
            {
                int resultado = numero * x;
                Console.WriteLine($"{numero} x {x} = {resultado}");

            }
        }
    }
}
