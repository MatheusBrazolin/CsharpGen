using System;
using System.Collections.Generic;
using zoologico.src;

namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal []{
                    new Gato("Gato Matheus", "Branco", "Felino");
                    new Cachorro("Cachorro Gustavo","Preto","Canídio");
                    new Gato("Gato Aaron", "Amarelo", "Felino");
                    new Cachorro("Cachorro Buona","Cínza","Canídio");
                }
            );

            foreach (Animal animal in animal)
            {
                if (animal.Classificacao == "Canidio")
                {
                    Console.WriteLine($"{Animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au Au");
                }
                else
                {
                     if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{Animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miauuu");
                }
            }

    }
}
