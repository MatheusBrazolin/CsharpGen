using System;

namespace Contagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"posicão {i} valor que deseja somar a {valor}: ");
            }

            Console.WriteLine($"Somatoria: {valor}");
        }
    }
}



