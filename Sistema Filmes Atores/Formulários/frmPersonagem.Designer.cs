
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
            this.txtFilme = new System.Windows.Forms.TextBox();
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
            this.txtIdAtor = new System.Windows.Forms.TextBox();
            this.txtIdFilme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddAtor = new System.Windows.Forms.Button();
            this.btnAddFilme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonagemAdd
            // 
            this.btnPersonagemAdd.Location = new System.Drawing.Point(15, 536);
            this.btnPersonagemAdd.Name = "btnPersonagemAdd";
            this.btnPersonagemAdd.Size = new System.Drawing.Size(462, 23);
            this.btnPersonagemAdd.TabIndex = 7;
            this.btnPersonagemAdd.Text = "Adicionar Personagem";
            this.btnPersonagemAdd.UseVisualStyleBackColor = true;
            this.btnPersonagemAdd.Click += new System.EventHandler(this.btnPersonagemAdd_Click);
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonagens.Location = new System.Drawing.Point(508, 106);
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.Size = new System.Drawing.Size(561, 453);
            this.dtPersonagens.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(508, 62);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(333, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // txtFilme
            // 
            this.txtFilme.Enabled = false;
            this.txtFilme.Location = new System.Drawing.Point(298, 119);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(179, 20);
            this.txtFilme.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Título do Filme";
            // 
            // txtAtor
            // 
            this.txtAtor.Enabled = false;
            this.txtAtor.Location = new System.Drawing.Point(298, 62);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.Size = new System.Drawing.Size(179, 20);
            this.txtAtor.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nome do Ator";
            // 
            // txtPapel
            // 
            this.txtPapel.Location = new System.Drawing.Point(15, 119);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(183, 20);
            this.txtPapel.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Papel(Ex: Protagonista)";
            // 
            // txtNomePersonagem
            // 
            this.txtNomePersonagem.Location = new System.Drawing.Point(15, 62);
            this.txtNomePersonagem.Name = "txtNomePersonagem";
            this.txtNomePersonagem.Size = new System.Drawing.Size(183, 20);
            this.txtNomePersonagem.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nome do Personagem";
            // 
            // dtAtor
            // 
            this.dtAtor.AllowUserToAddRows = false;
            this.dtAtor.AllowUserToDeleteRows = false;
            this.dtAtor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAtor.Location = new System.Drawing.Point(15, 198);
            this.dtAtor.Name = "dtAtor";
            this.dtAtor.Size = new System.Drawing.Size(462, 137);
            this.dtAtor.TabIndex = 62;
            this.dtAtor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAtor_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Pesquisar ator";
            // 
            // dtFilme
            // 
            this.dtFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFilme.Location = new System.Drawing.Point(15, 383);
            this.dtFilme.Name = "dtFilme";
            this.dtFilme.Size = new System.Drawing.Size(462, 137);
            this.dtFilme.TabIndex = 64;
            this.dtFilme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFilme_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Pesquisar filme";
            // 
            // txtPesqAtor
            // 
            this.txtPesqAtor.Location = new System.Drawing.Point(15, 179);
            this.txtPesqAtor.Name = "txtPesqAtor";
            this.txtPesqAtor.Size = new System.Drawing.Size(305, 20);
            this.txtPesqAtor.TabIndex = 65;
            this.txtPesqAtor.TextChanged += new System.EventHandler(this.txtPesqAtor_TextChanged);
            // 
            // txtPesqFilme
            // 
            this.txtPesqFilme.Location = new System.Drawing.Point(15, 364);
            this.txtPesqFilme.Name = "txtPesqFilme";
            this.txtPesqFilme.Size = new System.Drawing.Size(305, 20);
            this.txtPesqFilme.TabIndex = 66;
            this.txtPesqFilme.TextChanged += new System.EventHandler(this.txtPesqFilme_TextChanged);
            // 
            // txtIdAtor
            // 
            this.txtIdAtor.Enabled = false;
            this.txtIdAtor.Location = new System.Drawing.Point(223, 62);
            this.txtIdAtor.Name = "txtIdAtor";
            this.txtIdAtor.Size = new System.Drawing.Size(69, 20);
            this.txtIdAtor.TabIndex = 67;
            // 
            // txtIdFilme
            // 
            this.txtIdFilme.Enabled = false;
            this.txtIdFilme.Location = new System.Drawing.Point(223, 119);
            this.txtIdFilme.Name = "txtIdFilme";
            this.txtIdFilme.Size = new System.Drawing.Size(69, 20);
            this.txtIdFilme.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "*Inserir ator/filme selecionando no grid e apertando em \"Especificar ...\"";
            // 
            // btnAddAtor
            // 
            this.btnAddAtor.Location = new System.Drawing.Point(318, 179);
            this.btnAddAtor.Name = "btnAddAtor";
            this.btnAddAtor.Size = new System.Drawing.Size(159, 20);
            this.btnAddAtor.TabIndex = 70;
            this.btnAddAtor.Text = "Especificar ator";
            this.btnAddAtor.UseVisualStyleBackColor = true;
            this.btnAddAtor.Click += new System.EventHandler(this.btnAddAtor_Click);
            // 
            // btnAddFilme
            // 
            this.btnAddFilme.Location = new System.Drawing.Point(318, 364);
            this.btnAddFilme.Name = "btnAddFilme";
            this.btnAddFilme.Size = new System.Drawing.Size(159, 20);
            this.btnAddFilme.TabIndex = 71;
            this.btnAddFilme.Text = "Especificar filme";
            this.btnAddFilme.UseVisualStyleBackColor = true;
            this.btnAddFilme.Click += new System.EventHandler(this.btnAddFilme_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Adicionar Personagem";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(672, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 25);
            this.label10.TabIndex = 73;
            this.label10.Text = "Adicionar Personagem";
            // 
            // frmPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 588);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddFilme);
            this.Controls.Add(this.btnAddAtor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdFilme);
            this.Controls.Add(this.txtIdAtor);
            this.Controls.Add(this.txtPesqFilme);
            this.Controls.Add(this.txtPesqAtor);
            this.Controls.Add(this.dtFilme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtAtor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilme);
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
        private System.Windows.Forms.TextBox txtFilme;
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
        private System.Windows.Forms.TextBox txtIdAtor;
        private System.Windows.Forms.TextBox txtIdFilme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddAtor;
        private System.Windows.Forms.Button btnAddFilme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}