using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_IHC_Quiz
{
    class Jogador
    {

        public string Nome { get; set; }
        public int Pontuacao { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Pontuacao = 0;
        }

    }
}
