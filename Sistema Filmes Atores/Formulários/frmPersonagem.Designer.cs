
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmPersonagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPersonagemAdd = new System.Windows.Forms.Button();
            this.dtPersonagens = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAtor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPapel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePersonagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtAtor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFilme = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPesqAtor = new System.Windows.Forms.TextBox();
            this.txtPesqFilme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonagemAdd
            // 
            this.btnPersonagemAdd.Location = new System.Drawing.Point(350, 536);
            this.btnPersonagemAdd.Name = "btnPersonagemAdd";
            this.btnPersonagemAdd.Size = new System.Drawing.Size(127, 23);
            this.btnPersonagemAdd.TabIndex = 7;
            this.btnPersonagemAdd.Text = "Adicionar Personagem";
            this.btnPersonagemAdd.UseVisualStyleBackColor = true;
            this.btnPersonagemAdd.Click += new System.EventHandler(this.btnPersonagemAdd_Click);
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonagens.Location = new System.Drawing.Point(564, 106);
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.Size = new System.Drawing.Size(505, 453);
            this.dtPersonagens.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(564, 62);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(277, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Título do Filme";
            // 
            // txtAtor
            // 
            this.txtAtor.Location = new System.Drawing.Point(35, 115);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.Size = new System.Drawing.Size(163, 20);
            this.txtAtor.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nome do Ator";
            // 
            // txtPapel
            // 
            this.txtPapel.Location = new System.Drawing.Point(259, 66);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(163, 20);
            this.txtPapel.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Papel(Ex: Protagonista)";
            // 
            // txtNomePersonagem
            // 
            this.txtNomePersonagem.Location = new System.Drawing.Point(35, 62);
            this.txtNomePersonagem.Name = "txtNomePersonagem";
            this.txtNomePersonagem.Size = new System.Drawing.Size(163, 20);
            this.txtNomePersonagem.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nome do Personagem";
            // 
            // dtAtor
            // 
            this.dtAtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAtor.Location = new System.Drawing.Point(15, 181);
            this.dtAtor.Name = "dtAtor";
            this.dtAtor.Size = new System.Drawing.Size(462, 137);
            this.dtAtor.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ator";
            // 
            // dtFilme
            // 
            this.dtFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFilme.Location = new System.Drawing.Point(15, 383);
            this.dtFilme.Name = "dtFilme";
            this.dtFilme.Size = new System.Drawing.Size(462, 137);
            this.dtFilme.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Filme";
            // 
            // txtPesqAtor
            // 
            this.txtPesqAtor.Location = new System.Drawing.Point(44, 162);
            this.txtPesqAtor.Name = "txtPesqAtor";
            this.txtPesqAtor.Size = new System.Drawing.Size(433, 20);
            this.txtPesqAtor.TabIndex = 65;
            this.txtPesqAtor.TextChanged += new System.EventHandler(this.txtPesqAtor_TextChanged);
            // 
            // txtPesqFilme
            // 
            this.txtPesqFilme.Location = new System.Drawing.Point(44, 364);
            this.txtPesqFilme.Name = "txtPesqFilme";
            this.txtPesqFilme.Size = new System.Drawing.Size(433, 20);
            this.txtPesqFilme.TabIndex = 66;
            this.txtPesqFilme.TextChanged += new System.EventHandler(this.txtPesqFilme_TextChanged);
            // 
            // frmPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 588);
            this.Controls.Add(this.txtPesqFilme);
            this.Controls.Add(this.txtPesqAtor);
            this.Controls.Add(this.dtFilme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtAtor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAtor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPapel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomePersonagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonagemAdd);
            this.Controls.Add(this.dtPersonagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "frmPersonagem";
            this.Text = "frmPersonagem";
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonagemAdd;
        private System.Windows.Forms.DataGridView dtPersonagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAtor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPapel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePersonagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtAtor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtFilme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPesqAtor;
        private System.Windows.Forms.TextBox txtPesqFilme;
    }
}