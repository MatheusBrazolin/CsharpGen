using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Src
{
    public class Musica
    {

        public string NomeMusica { get; set; }

        public string Cantor { get; set; }

        public string Duracao { get; set; }

        public Musica(string _nomeMusica, string _cantor, string _duracao)
        {
            NomeMusica = _nomeMusica;
            Cantor = _cantor;
            Duracao = _duracao;

        }

        public override string ToString()
        {
            return $"Nome da musica: {NomeMusica} | Cantor: {Cantor} | Ducação da musica: {Duracao}";
        }
    }
}
