
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmPersonagemAdicionar
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
            this.txtNomePersonagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPapel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPersonagens = new System.Windows.Forms.DataGridView();
            this.txtAtor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnomeFilme = new System.Windows.Forms.Label();
            this.dtAddAtor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdAtor = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdPersonagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAddAtor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePersonagem
            // 
            this.txtNomePersonagem.Location = new System.Drawing.Point(486, 74);
            this.txtNomePersonagem.Name = "txtNomePersonagem";
            this.txtNomePersonagem.Size = new System.Drawing.Size(163, 20);
            this.txtNomePersonagem.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome do Personagem";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(604, 419);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(124, 23);
            this.btnAdicionar.TabIndex = 40;
            this.btnAdicionar.Text = "Adicionar/Editar Personagem";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Personagens do filme:";
            // 
            // txtPapel
            // 
            this.txtPapel.Location = new System.Drawing.Point(678, 74);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(163, 20);
            this.txtPapel.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Papel(Ex: Protagonista)";
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonagens.Location = new System.Drawing.Point(12, 40);
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.Size = new System.Drawing.Size(407, 404);
            this.dtPersonagens.TabIndex = 47;
            this.dtPersonagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellClick);
            this.dtPersonagens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellDoubleClick);
            // 
            // txtAtor
            // 
            this.txtAtor.Enabled = false;
            this.txtAtor.Location = new System.Drawing.Point(486, 127);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.Size = new System.Drawing.Size(163, 20);
            this.txtAtor.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nome do Ator";
            // 
            // txtFilme
            // 
            this.txtFilme.Enabled = false;
            this.txtFilme.Location = new System.Drawing.Point(678, 127);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(163, 20);
            this.txtFilme.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Título do Filme";
            // 
            // lblnomeFilme
            // 
            this.lblnomeFilme.AutoSize = true;
            this.lblnomeFilme.Location = new System.Drawing.Point(120, 21);
            this.lblnomeFilme.Name = "lblnomeFilme";
            this.lblnomeFilme.Size = new System.Drawing.Size(57, 13);
            this.lblnomeFilme.TabIndex = 53;
            this.lblnomeFilme.Text = "nomeFilme";
            // 
            // dtAddAtor
            // 
            this.dtAddAtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAddAtor.Location = new System.Drawing.Point(458, 207);
            this.dtAddAtor.Name = "dtAddAtor";
            this.dtAddAtor.Size = new System.Drawing.Size(407, 210);
            this.dtAddAtor.TabIndex = 54;
            this.dtAddAtor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAddAtor_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Clique na tabela para selecionar o ator";
            // 
            // lblIdAtor
            // 
            this.lblIdAtor.AutoSize = true;
            this.lblIdAtor.Location = new System.Drawing.Point(483, 98);
            this.lblIdAtor.Name = "lblIdAtor";
            this.lblIdAtor.Size = new System.Drawing.Size(34, 13);
            this.lblIdAtor.TabIndex = 56;
            this.lblIdAtor.Text = "idAtor";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(458, 181);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(407, 20);
            this.txtPesquisar.TabIndex = 57;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(526, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 25);
            this.lblTitulo.TabIndex = 58;
            this.lblTitulo.Text = "Adicionar/Editar Personagem";
            // 
            // lblIdPersonagem
            // 
            this.lblIdPersonagem.AutoSize = true;
            this.lblIdPersonagem.Location = new System.Drawing.Point(483, 45);
            this.lblIdPersonagem.Name = "lblIdPersonagem";
            this.lblIdPersonagem.Size = new System.Drawing.Size(0, 13);
            this.lblIdPersonagem.TabIndex = 59;
            // 
            // frmPersonagemAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 456);
            this.Controls.Add(this.lblIdPersonagem);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblIdAtor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtAddAtor);
            this.Controls.Add(this.lblnomeFilme);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAtor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPersonagens);
            this.Controls.Add(this.txtPapel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomePersonagem);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonagemAdicionar";
            this.Text = "frmPersonagemAdicionar";
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAddAtor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomePersonagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPapel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtPersonagens;
        private System.Windows.Forms.TextBox txtAtor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnomeFilme;
        private System.Windows.Forms.DataGridView dtAddAtor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdAtor;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdPersonagem;
    }
}