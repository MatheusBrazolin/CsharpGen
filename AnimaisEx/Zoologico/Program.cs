using System;
using System.Collections.Generic;
using Zoologico.src;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[]{
                    new Gato("Gato Brazola", "Cinza", "Felino"),
                    new Cachorro("Cachorro Gustavo", "Preto", "Canídio"),
                    new Cachorro("Cachorro Aaron", "Branco", "Canídio"),
                    new Gato("Gato Buona", "Marrom", "Felino"),
                    new Cavalo("Cavalo Jhow", "Marrom", "Perissodactyla"),
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au au!");
                } 
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");
                 }
                else if (animal.Classificacao == "Perissodactyla")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Irararara");
                }
            }

        }
    }
}