using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_IHC_Quiz
{
    public partial class Form1 : Form
    {

        Stack<Questao> questionario = new Stack<Questao>();
        Questao perguntaAtual;
        Questao[] questoesVetor;
        Jogador jogador;

        public void montarQuestionario()
        {
            questoesVetor = new Questao[10]
            {

            //new Questao("pergunta", "opção 1", "opção 2", "opção 3", "opção 4", "resposta", "dica"),
            new Questao("Em um lago, há um conjunto de flores aquáticas. Todos os dias, o conjunto dobra de tamanho. Se são necessários 48 dias para o conjunto cobrir todo o lago, quantos dias seriam necessários para que ele cobrisse metade do lago?", "24", "36", "47", "25", "47", "A maneira que as flores crescem é o segredo dessa pergunta"),
            new Questao("Um trem elétrico segue no sentido norte-sul. O vento está no sentido contrário, ou seja, sul-norte. Qual a direção da fumaça desse trem?", "Norte", "Sul", "Para cima", "Nenhuma", "Nenhuma", "Analise o trem e suas propriedades"),
            new Questao("Um avião, com tripulantes baianos, sobrevoava sobre Minas Gerais, indo em direção à São Paulo, quando o piloto percebeu que ambas as turbinas falharam, e o avião caiu, na divisa dos estados. Onde os sobreviventes devem ser enterrados?", "Minas Gerais", "São Paulo", "Bahia", "Não enterrar", "Não enterrar", "Qual é mesmo a situação das pessoas no acidente?"),
            new Questao("Quantas vezes é possível subtrair 10 de 100?", "10", "1", "100", "50", "1", "O número 100 é fundamental para essa pergunta, preste atenção nele."),
            new Questao("Alguns meses têm 30 dias e outros, 31. Quantos meses têm 28 dias durante um período de três anos? ", "12", "3", "6", "36", "36", "A solução está na interpretação da pergunta “quantos”?"),
            new Questao("Um casal tem seis filhos homens, cada filho tem uma irmã. Quantas pessoas há nessa família no total?", "6", "7", "14", "9", "9", "lembre-se de como funciona o parentesco."),
            new Questao("Se o amanhã de ontem era sexta-feira, que dia é o dia depois de amanhã de ontem?", "Sábado", "Domingo", "Quinta", "Sexta", "Sábado", "Pense nos dias de semana."),
            new Questao("Três gatos pegam três ratos em três minutos. Quantos minutos 100 gatos levam para capturar 100 ratos?", "100", "3", "300", "9", "3", "Todos os gatos vão atrás dos ratos ao mesmo tempo."),
            new Questao("Fábio foi sozinho até a padaria no centro da cidade. Durante o percurso, encontrou duas garotas passeando com três cachorros, que estavam brincando com dois gatos, que, por sua vez, tinham dois donos. Quantos seres no total foram com Fábio até a padaria?", "4", "2", "0", "9", "0", "A resposta está na pergunta."),
            new Questao("Imagine que em sua frente vão caminhando 2 mães, 2 filhas, uma avó e uma neta. Quantas pessoas são?", "3", "4", "5", "6", "3", "A neta é filha de quem, a vó é mãe de quem?")

            };

            MontarQuestionario(questoesVetor);
        }

        void MontarQuestionario(Questao[] questoes)
        {
            Random aleatorio = new Random();
            int pos, cont = 9;
            Questao aux;
            

            for (int i = 0; i < 10; i++)
            {
                pos = aleatorio.Next(0, cont);
                questionario.Push(questoes[pos]);
                aux = questoes[pos];
                questoes[pos] = questoes[cont];
                questoes[cont] = aux;
                cont--;
            }
        }

        void InserirPergunta()
        {
            continuar.Visible = false;
                                       

            if(questionario.Count > 0)
            {

                perguntaAtual = questionario.Pop();
                pergunta.Text = perguntaAtual.Pergunta;

                opcao1.Text = perguntaAtual.Opcao1;
                opcao2.Text = perguntaAtual.Opcao2;
                opcao3.Text = perguntaAtual.Opcao3;
                opcao4.Text = perguntaAtual.Opcao4;

                dica_questao.Text = "Dica: " + perguntaAtual.Dica;

            }
            else
            {
                //Apresentar resultados
                resultado_panel.Visible = true;
                resultado_panel.BringToFront();
                resultado_label.Text = jogador.Nome + ", o você acertou:";
                resultado_value.Text = jogador.Pontuacao + " / 10";
                jogar_novamente.Enabled = true;
            }

            
        }

        void responder(Questao questao, Button botaoClicado, string opcao)
        {

            if(questao != null)
            {

                if (opcao.Equals(questao.Resposta))
                {
                    botaoClicado.BackColor = Color.Green;

                    opcao1.Enabled = false;
                    opcao2.Enabled = false;
                    opcao3.Enabled = false;
                    opcao4.Enabled = false;
                    
                    continuar.Visible = true;
                    jogador.Pontuacao++;
                }
                else
                {
                    botaoClicado.BackColor = Color.Red;
                    dica_questao.Visible = true;

                    opcao1.Enabled = false;
                    opcao2.Enabled = false;
                    opcao3.Enabled = false;
                    opcao4.Enabled = false;

                    continuar.Visible = true;

                }

            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void botao_entrar_Click(object sender, EventArgs e)
        {
            if(nome_input.Text == "")
            {
                //Mostrar erro que tá sem nome
                nome_input.Text = "Você precisa colocar um nome para entrar";                
            }
            else
            {
                jogador = new Jogador(nome_input.Text);
                montarQuestionario();
                InserirPergunta();
                botao_entrar.Visible = false;
                jogar_novamente.Enabled = false;
                questionario_painel.Visible = true;
                questionario_painel.BringToFront();
            }
        }


        #region Eventos da tela de questionário
        private void opcao1_Click(object sender, EventArgs e)
        {
            responder(perguntaAtual, opcao1, opcao1.Text);
        }

        private void opcao2_Click(object sender, EventArgs e)
        {
            responder(perguntaAtual, opcao2, opcao2.Text);
        }

        private void opcao3_Click(object sender, EventArgs e)
        {
            responder(perguntaAtual, opcao3, opcao3.Text);
        }

        private void opcao4_Click(object sender, EventArgs e)
        {
            responder(perguntaAtual, opcao4, opcao4.Text);
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            InserirPergunta();

            opcao1.Enabled = true;
            opcao2.Enabled = true;
            opcao3.Enabled = true;
            opcao4.Enabled = true;

            opcao1.BackColor = Color.Yellow;
            opcao2.BackColor = Color.Yellow;
            opcao3.BackColor = Color.Yellow;
            opcao4.BackColor = Color.Yellow;

            dica_questao.Visible = false;

        }

        #endregion



        private void jogar_novamente_Click(object sender, EventArgs e)
        {
            resultado_panel.Visible = false;
            questionario_painel.Visible = false;
            botao_entrar.Visible = true;
            nome_input.Text = "";
            jogar_novamente.Enabled = false;
        }
    }
}
