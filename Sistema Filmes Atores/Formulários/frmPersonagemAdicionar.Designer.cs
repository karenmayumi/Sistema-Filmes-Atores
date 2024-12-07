
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAddAtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePersonagem
            // 
            this.txtNomePersonagem.Location = new System.Drawing.Point(456, 124);
            this.txtNomePersonagem.Name = "txtNomePersonagem";
            this.txtNomePersonagem.Size = new System.Drawing.Size(163, 20);
            this.txtNomePersonagem.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(453, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome do Personagem";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(560, 298);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(208, 42);
            this.btnAdicionar.TabIndex = 40;
            this.btnAdicionar.Text = "Adicionar/Editar Personagem";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Personagens do filme:";
            // 
            // txtPapel
            // 
            this.txtPapel.Location = new System.Drawing.Point(667, 124);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(163, 20);
            this.txtPapel.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(664, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Papel(Ex: Protagonista)";
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonagens.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtPersonagens.Location = new System.Drawing.Point(30, 68);
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.Size = new System.Drawing.Size(358, 370);
            this.dtPersonagens.TabIndex = 47;
            this.dtPersonagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellClick);
            this.dtPersonagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellContentClick);
            this.dtPersonagens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellDoubleClick);
            // 
            // txtAtor
            // 
            this.txtAtor.Enabled = false;
            this.txtAtor.Location = new System.Drawing.Point(456, 197);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.Size = new System.Drawing.Size(163, 20);
            this.txtAtor.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(453, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nome do Ator";
            // 
            // txtFilme
            // 
            this.txtFilme.Enabled = false;
            this.txtFilme.Location = new System.Drawing.Point(667, 197);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(163, 20);
            this.txtFilme.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(664, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Título do Filme:";
            // 
            // lblnomeFilme
            // 
            this.lblnomeFilme.AutoSize = true;
            this.lblnomeFilme.BackColor = System.Drawing.Color.Transparent;
            this.lblnomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeFilme.Location = new System.Drawing.Point(209, 45);
            this.lblnomeFilme.Name = "lblnomeFilme";
            this.lblnomeFilme.Size = new System.Drawing.Size(97, 22);
            this.lblnomeFilme.TabIndex = 53;
            this.lblnomeFilme.Text = "nomeFilme";
            this.lblnomeFilme.Click += new System.EventHandler(this.lblnomeFilme_Click);
            // 
            // dtAddAtor
            // 
            this.dtAddAtor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtAddAtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAddAtor.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtAddAtor.Location = new System.Drawing.Point(444, 392);
            this.dtAddAtor.Name = "dtAddAtor";
            this.dtAddAtor.Size = new System.Drawing.Size(407, 210);
            this.dtAddAtor.TabIndex = 54;
            this.dtAddAtor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAddAtor_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(501, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Clique na tabela para selecionar o ator";
            // 
            // lblIdAtor
            // 
            this.lblIdAtor.AutoSize = true;
            this.lblIdAtor.BackColor = System.Drawing.Color.Transparent;
            this.lblIdAtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAtor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIdAtor.Location = new System.Drawing.Point(453, 159);
            this.lblIdAtor.Name = "lblIdAtor";
            this.lblIdAtor.Size = new System.Drawing.Size(45, 17);
            this.lblIdAtor.TabIndex = 56;
            this.lblIdAtor.Text = "idAtor";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(456, 260);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(395, 20);
            this.txtPesquisar.TabIndex = 57;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(515, 33);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Sistema_de_Locadora__4_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 199);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // frmPersonagemAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Sistema_de_Locadora__3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 614);
            this.Controls.Add(this.pictureBox1);
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
            this.DoubleBuffered = true;
            this.Name = "frmPersonagemAdicionar";
            this.Text = "frmPersonagemAdicionar";
            this.Load += new System.EventHandler(this.frmPersonagemAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAddAtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}