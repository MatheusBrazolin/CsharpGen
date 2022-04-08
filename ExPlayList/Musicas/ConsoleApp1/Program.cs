using System;

namespace ConsoleApp1.Src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Musica");
            Musica fichaLimpa = new Musica("Ficha Limpa", "Gustavo Lima", "3:14");
            Musica Presepada = new Musica("Presepada", "Marilha mendonca", "3:14");
            Musica Evidencias = new Musica("Evidencias", "Chitãozinho & Xororo", "4:45");

            Console.WriteLine(fichaLimpa.ToString());
            Console.WriteLine(Presepada.ToString());
            Console.WriteLine(Evidencias.ToString());


        }
    }
}
