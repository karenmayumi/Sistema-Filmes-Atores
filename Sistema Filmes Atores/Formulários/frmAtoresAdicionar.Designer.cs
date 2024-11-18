
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmAtoresAdicionar
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
            this.btnAddAtor = new System.Windows.Forms.Button();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeArtistico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAtor
            // 
            this.btnAddAtor.Location = new System.Drawing.Point(27, 260);
            this.btnAddAtor.Name = "btnAddAtor";
            this.btnAddAtor.Size = new System.Drawing.Size(163, 23);
            this.btnAddAtor.TabIndex = 27;
            this.btnAddAtor.Text = "Adicionar Ator/Atriz";
            this.btnAddAtor.UseVisualStyleBackColor = true;
            this.btnAddAtor.Click += new System.EventHandler(this.btnAddAtor_Click);
            // 
            // numDuracao
            // 
            this.numDuracao.Location = new System.Drawing.Point(27, 142);
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(163, 20);
            this.numDuracao.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 20);
            this.txtNome.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Não Binário"});
            this.comboBox1.Location = new System.Drawing.Point(27, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gênero";
            // 
            // txtNomeArtistico
            // 
            this.txtNomeArtistico.Location = new System.Drawing.Point(27, 91);
            this.txtNomeArtistico.Name = "txtNomeArtistico";
            this.txtNomeArtistico.Size = new System.Drawing.Size(163, 20);
            this.txtNomeArtistico.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nome Artístico";
            // 
            // frmAtoresAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 325);
            this.Controls.Add(this.txtNomeArtistico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddAtor);
            this.Controls.Add(this.numDuracao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAtoresAdicionar";
            this.Text = "Adicionar Ator/Atriz";
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAtor;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeArtistico;
        private System.Windows.Forms.Label label4;
    }
}