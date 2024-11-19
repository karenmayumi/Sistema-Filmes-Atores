
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmFilmesAdicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.rtxtSinopse = new System.Windows.Forms.RichTextBox();
            this.btnAddFilme = new System.Windows.Forms.Button();
            this.txtVlrDiaria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título do filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duração(em segundos)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sinopse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade Indicada(Acima de...)";
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(33, 49);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(163, 20);
            this.txtFilme.TabIndex = 6;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(33, 121);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(163, 20);
            this.txtCategoria.TabIndex = 7;
            // 
            // numDuracao
            // 
            this.numDuracao.Location = new System.Drawing.Point(33, 197);
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(134, 20);
            this.numDuracao.TabIndex = 9;
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(33, 252);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(134, 20);
            this.numIdade.TabIndex = 10;
            // 
            // rtxtSinopse
            // 
            this.rtxtSinopse.Location = new System.Drawing.Point(243, 49);
            this.rtxtSinopse.Name = "rtxtSinopse";
            this.rtxtSinopse.Size = new System.Drawing.Size(161, 82);
            this.rtxtSinopse.TabIndex = 12;
            this.rtxtSinopse.Text = "";
            // 
            // btnAddFilme
            // 
            this.btnAddFilme.Location = new System.Drawing.Point(33, 311);
            this.btnAddFilme.Name = "btnAddFilme";
            this.btnAddFilme.Size = new System.Drawing.Size(371, 23);
            this.btnAddFilme.TabIndex = 14;
            this.btnAddFilme.Text = "Adicionar Filme";
            this.btnAddFilme.UseVisualStyleBackColor = true;
            this.btnAddFilme.Click += new System.EventHandler(this.btnAddFilme_Click);
            // 
            // txtVlrDiaria
            // 
            this.txtVlrDiaria.Location = new System.Drawing.Point(243, 189);
            this.txtVlrDiaria.Name = "txtVlrDiaria";
            this.txtVlrDiaria.Size = new System.Drawing.Size(163, 20);
            this.txtVlrDiaria.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor da diária";
            // 
            // frmFilmesAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 380);
            this.Controls.Add(this.txtVlrDiaria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddFilme);
            this.Controls.Add(this.rtxtSinopse);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.numDuracao);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmesAdicionar";
            this.Text = "Adicionar Filme";
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.RichTextBox rtxtSinopse;
        private System.Windows.Forms.Button btnAddFilme;
        private System.Windows.Forms.TextBox txtVlrDiaria;
        private System.Windows.Forms.Label label6;
    }
}