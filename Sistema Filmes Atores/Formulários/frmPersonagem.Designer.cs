
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
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonagemAdd
            // 
            this.btnPersonagemAdd.Location = new System.Drawing.Point(496, 34);
            this.btnPersonagemAdd.Name = "btnPersonagemAdd";
            this.btnPersonagemAdd.Size = new System.Drawing.Size(127, 23);
            this.btnPersonagemAdd.TabIndex = 7;
            this.btnPersonagemAdd.Text = "Adicionar Personagem";
            this.btnPersonagemAdd.UseVisualStyleBackColor = true;
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonagens.Location = new System.Drawing.Point(15, 90);
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.Size = new System.Drawing.Size(608, 297);
            this.dtPersonagens.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(15, 37);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(277, 20);
            this.txtPesquisa.TabIndex = 4;
            // 
            // frmPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 407);
            this.Controls.Add(this.btnPersonagemAdd);
            this.Controls.Add(this.dtPersonagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "frmPersonagem";
            this.Text = "frmPersonagem";
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonagemAdd;
        private System.Windows.Forms.DataGridView dtPersonagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}