using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoologico
{
    public class Cavalo : Animal
    {
        public Cavalo(){}
        public Cavalo(string nome, string cor, string classificacao) : base(nome, cor, classificacao)
        {
        }
        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }
    }
}