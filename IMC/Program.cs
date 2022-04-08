using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float peso, altura, imc;

            string nome;

            Console.WriteLine("Insira seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Insira seu peso");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira sua altura");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            Console.WriteLine("seu imc é " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("abaixo do peso:" + imc);
            }
            else if (imc < 25)
            {
                Console.WriteLine("peso normal:" + imc);
            }
            else if (imc < 30)
            {
                Console.WriteLine("sobre peso:" + imc);

            }
            else
            {
                Console.WriteLine("obesidade:");

            }
        }
    }
}

        
