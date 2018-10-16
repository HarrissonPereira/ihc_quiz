using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_IHC_Quiz
{
    class Questao
    {

        public string Pergunta { get; set; }

        public string Opcao1 { get; set; }
        public string Opcao2 { get; set; }
        public string Opcao3 { get; set; }
        public string Opcao4 { get; set; }

        public string Resposta { get; set; }
        public string Dica { get; set; }

        public Questao
            (
            string pergunta,
            string opcao1,
            string opcao2,
            string opcao3,
            string opcao4,
            string resposta,
            string dica
            )
        {

            Pergunta = pergunta;
            Opcao1 = opcao1;
            Opcao2 = opcao2;
            Opcao3 = opcao3;
            Opcao4 = opcao4;
            Resposta = resposta;
            Dica = dica;

        }

    }
}
