namespace Trabalho_IHC_Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botao_entrar = new System.Windows.Forms.Button();
            this.nome_input = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionario_painel = new System.Windows.Forms.Panel();
            this.dica_questao = new System.Windows.Forms.Label();
            this.pergunta = new System.Windows.Forms.Label();
            this.opcao3 = new System.Windows.Forms.Button();
            this.continuar = new System.Windows.Forms.Button();
            this.opcao4 = new System.Windows.Forms.Button();
            this.opcao2 = new System.Windows.Forms.Button();
            this.opcao1 = new System.Windows.Forms.Button();
            this.resultado_panel = new System.Windows.Forms.Panel();
            this.resultado_label = new System.Windows.Forms.Label();
            this.resultado_value = new System.Windows.Forms.Label();
            this.jogar_novamente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_erro = new System.Windows.Forms.Label();
            this.questionario_painel.SuspendLayout();
            this.resultado_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // botao_entrar
            // 
            this.botao_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(123)))), ((int)(((byte)(217)))));
            this.botao_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_entrar.Location = new System.Drawing.Point(244, 362);
            this.botao_entrar.Name = "botao_entrar";
            this.botao_entrar.Size = new System.Drawing.Size(107, 51);
            this.botao_entrar.TabIndex = 0;
            this.botao_entrar.Text = "ENTRAR";
            this.botao_entrar.UseVisualStyleBackColor = false;
            this.botao_entrar.Click += new System.EventHandler(this.botao_entrar_Click);
            // 
            // nome_input
            // 
            this.nome_input.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nome_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_input.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nome_input.Location = new System.Drawing.Point(82, 328);
            this.nome_input.Name = "nome_input";
            this.nome_input.Size = new System.Drawing.Size(433, 24);
            this.nome_input.TabIndex = 1;
            this.nome_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(149, 63);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(293, 228);
            this.logo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Racional Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionario_painel
            // 
            this.questionario_painel.Controls.Add(this.dica_questao);
            this.questionario_painel.Controls.Add(this.pergunta);
            this.questionario_painel.Controls.Add(this.opcao3);
            this.questionario_painel.Controls.Add(this.continuar);
            this.questionario_painel.Controls.Add(this.opcao4);
            this.questionario_painel.Controls.Add(this.opcao2);
            this.questionario_painel.Controls.Add(this.opcao1);
            this.questionario_painel.Location = new System.Drawing.Point(23, 21);
            this.questionario_painel.Name = "questionario_painel";
            this.questionario_painel.Size = new System.Drawing.Size(545, 375);
            this.questionario_painel.TabIndex = 4;
            this.questionario_painel.Visible = false;
            // 
            // dica_questao
            // 
            this.dica_questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dica_questao.ForeColor = System.Drawing.Color.Gold;
            this.dica_questao.Location = new System.Drawing.Point(3, 157);
            this.dica_questao.Name = "dica_questao";
            this.dica_questao.Size = new System.Drawing.Size(539, 45);
            this.dica_questao.TabIndex = 2;
            this.dica_questao.Text = "Dica";
            this.dica_questao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dica_questao.Visible = false;
            // 
            // pergunta
            // 
            this.pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergunta.Location = new System.Drawing.Point(0, -3);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(545, 158);
            this.pergunta.TabIndex = 1;
            this.pergunta.Text = "Pergunta";
            this.pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opcao3
            // 
            this.opcao3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(81)))));
            this.opcao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcao3.Location = new System.Drawing.Point(86, 264);
            this.opcao3.Name = "opcao3";
            this.opcao3.Size = new System.Drawing.Size(159, 43);
            this.opcao3.TabIndex = 0;
            this.opcao3.Text = "button1";
            this.opcao3.UseVisualStyleBackColor = false;
            this.opcao3.Click += new System.EventHandler(this.opcao3_Click);
            // 
            // continuar
            // 
            this.continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(123)))), ((int)(((byte)(217)))));
            this.continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar.Location = new System.Drawing.Point(196, 324);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(164, 43);
            this.continuar.TabIndex = 0;
            this.continuar.Text = "Próxima Pergunta";
            this.continuar.UseVisualStyleBackColor = false;
            this.continuar.Visible = false;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // opcao4
            // 
            this.opcao4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(81)))));
            this.opcao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcao4.Location = new System.Drawing.Point(317, 264);
            this.opcao4.Name = "opcao4";
            this.opcao4.Size = new System.Drawing.Size(164, 43);
            this.opcao4.TabIndex = 0;
            this.opcao4.Text = "button1";
            this.opcao4.UseVisualStyleBackColor = false;
            this.opcao4.Click += new System.EventHandler(this.opcao4_Click);
            // 
            // opcao2
            // 
            this.opcao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(81)))));
            this.opcao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcao2.Location = new System.Drawing.Point(317, 205);
            this.opcao2.Name = "opcao2";
            this.opcao2.Size = new System.Drawing.Size(164, 43);
            this.opcao2.TabIndex = 0;
            this.opcao2.Text = "button1";
            this.opcao2.UseVisualStyleBackColor = false;
            this.opcao2.Click += new System.EventHandler(this.opcao2_Click);
            // 
            // opcao1
            // 
            this.opcao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(81)))));
            this.opcao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcao1.Location = new System.Drawing.Point(86, 205);
            this.opcao1.Name = "opcao1";
            this.opcao1.Size = new System.Drawing.Size(159, 43);
            this.opcao1.TabIndex = 0;
            this.opcao1.Text = "opcao1";
            this.opcao1.UseVisualStyleBackColor = false;
            this.opcao1.Click += new System.EventHandler(this.opcao1_Click);
            // 
            // resultado_panel
            // 
            this.resultado_panel.Controls.Add(this.resultado_label);
            this.resultado_panel.Controls.Add(this.resultado_value);
            this.resultado_panel.Controls.Add(this.jogar_novamente);
            this.resultado_panel.Location = new System.Drawing.Point(23, 21);
            this.resultado_panel.Name = "resultado_panel";
            this.resultado_panel.Size = new System.Drawing.Size(545, 378);
            this.resultado_panel.TabIndex = 5;
            this.resultado_panel.Visible = false;
            // 
            // resultado_label
            // 
            this.resultado_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_label.Location = new System.Drawing.Point(10, 10);
            this.resultado_label.Name = "resultado_label";
            this.resultado_label.Size = new System.Drawing.Size(532, 87);
            this.resultado_label.TabIndex = 2;
            this.resultado_label.Text = "O seu resultado é:";
            this.resultado_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultado_value
            // 
            this.resultado_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_value.Location = new System.Drawing.Point(4, 136);
            this.resultado_value.Name = "resultado_value";
            this.resultado_value.Size = new System.Drawing.Size(538, 111);
            this.resultado_value.TabIndex = 1;
            this.resultado_value.Text = "resultado";
            this.resultado_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jogar_novamente
            // 
            this.jogar_novamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(123)))), ((int)(((byte)(217)))));
            this.jogar_novamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogar_novamente.Location = new System.Drawing.Point(185, 298);
            this.jogar_novamente.Name = "jogar_novamente";
            this.jogar_novamente.Size = new System.Drawing.Size(166, 49);
            this.jogar_novamente.TabIndex = 0;
            this.jogar_novamente.Text = "Jogar Novamente";
            this.jogar_novamente.UseVisualStyleBackColor = false;
            this.jogar_novamente.Click += new System.EventHandler(this.jogar_novamente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite seu nome";
            // 
            // nome_erro
            // 
            this.nome_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_erro.ForeColor = System.Drawing.Color.Maroon;
            this.nome_erro.Location = new System.Drawing.Point(285, 309);
            this.nome_erro.Name = "nome_erro";
            this.nome_erro.Size = new System.Drawing.Size(230, 16);
            this.nome_erro.TabIndex = 6;
            this.nome_erro.Text = "Você precisa digitar um nome.";
            this.nome_erro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nome_erro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(594, 425);
            this.Controls.Add(this.nome_erro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultado_panel);
            this.Controls.Add(this.questionario_painel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.nome_input);
            this.Controls.Add(this.botao_entrar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Racional Quiz";
            this.questionario_painel.ResumeLayout(false);
            this.resultado_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_entrar;
        private System.Windows.Forms.TextBox nome_input;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel questionario_painel;
        private System.Windows.Forms.Label pergunta;
        private System.Windows.Forms.Button opcao3;
        private System.Windows.Forms.Button opcao4;
        private System.Windows.Forms.Button opcao2;
        private System.Windows.Forms.Button opcao1;
        private System.Windows.Forms.Label dica_questao;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Panel resultado_panel;
        private System.Windows.Forms.Label resultado_label;
        private System.Windows.Forms.Label resultado_value;
        private System.Windows.Forms.Button jogar_novamente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label nome_erro;
    }
}

