
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbAddFilme = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAddAtor = new System.Windows.Forms.ComboBox();
            this.txtPapel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAtor = new System.Windows.Forms.DataGridView();
            this.dtFilme = new System.Windows.Forms.DataGridView();
            this.txtAtor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtAtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePersonagem
            // 
            this.txtNomePersonagem.Location = new System.Drawing.Point(28, 45);
            this.txtNomePersonagem.Name = "txtNomePersonagem";
            this.txtNomePersonagem.Size = new System.Drawing.Size(163, 20);
            this.txtNomePersonagem.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome do Personagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Filme";
            // 
            // cbAddFilme
            // 
            this.cbAddFilme.FormattingEnabled = true;
            this.cbAddFilme.Location = new System.Drawing.Point(579, 132);
            this.cbAddFilme.Name = "cbAddFilme";
            this.cbAddFilme.Size = new System.Drawing.Size(169, 21);
            this.cbAddFilme.TabIndex = 41;
            this.cbAddFilme.TextChanged += new System.EventHandler(this.cbAddFilme_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(738, 45);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(124, 23);
            this.btnAdicionar.TabIndex = 40;
            this.btnAdicionar.Text = "Adicionar Personagem";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ator";
            // 
            // cbAddAtor
            // 
            this.cbAddAtor.FormattingEnabled = true;
            this.cbAddAtor.Location = new System.Drawing.Point(114, 151);
            this.cbAddAtor.Name = "cbAddAtor";
            this.cbAddAtor.Size = new System.Drawing.Size(169, 21);
            this.cbAddAtor.TabIndex = 38;
            this.cbAddAtor.TextChanged += new System.EventHandler(this.cbAddAtor_TextChanged);
            // 
            // txtPapel
            // 
            this.txtPapel.Location = new System.Drawing.Point(209, 45);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(163, 20);
            this.txtPapel.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Papel(Ex: Protagonista)";
            // 
            // dtAtor
            // 
            this.dtAtor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAtor.Location = new System.Drawing.Point(28, 178);
            this.dtAtor.Name = "dtAtor";
            this.dtAtor.Size = new System.Drawing.Size(407, 266);
            this.dtAtor.TabIndex = 47;
            // 
            // dtFilme
            // 
            this.dtFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFilme.Location = new System.Drawing.Point(455, 178);
            this.dtFilme.Name = "dtFilme";
            this.dtFilme.Size = new System.Drawing.Size(407, 266);
            this.dtFilme.TabIndex = 48;
            // 
            // txtAtor
            // 
            this.txtAtor.Location = new System.Drawing.Point(28, 98);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.Size = new System.Drawing.Size(163, 20);
            this.txtAtor.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nome do Ator";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Título do Filme";
            // 
            // frmPersonagemAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 456);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAtor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFilme);
            this.Controls.Add(this.dtAtor);
            this.Controls.Add(this.txtPapel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAddFilme);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAddAtor);
            this.Controls.Add(this.txtNomePersonagem);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonagemAdicionar";
            this.Text = "frmPersonagemAdicionar";
            ((System.ComponentModel.ISupportInitialize)(this.dtAtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomePersonagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAddFilme;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAddAtor;
        private System.Windows.Forms.TextBox txtPapel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtAtor;
        private System.Windows.Forms.DataGridView dtFilme;
        private System.Windows.Forms.TextBox txtAtor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}