
namespace Sistema_Filmes_Atores
{
    partial class frmMenu
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
            this.btnFilmes = new System.Windows.Forms.Button();
            this.btnAtores = new System.Windows.Forms.Button();
            this.btnPersonagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilmes
            // 
            this.btnFilmes.Location = new System.Drawing.Point(79, 108);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(169, 48);
            this.btnFilmes.TabIndex = 0;
            this.btnFilmes.Text = "Ver filmes";
            this.btnFilmes.UseVisualStyleBackColor = true;
            this.btnFilmes.Click += new System.EventHandler(this.btnFilmes_Click);
            // 
            // btnAtores
            // 
            this.btnAtores.Location = new System.Drawing.Point(79, 176);
            this.btnAtores.Name = "btnAtores";
            this.btnAtores.Size = new System.Drawing.Size(169, 48);
            this.btnAtores.TabIndex = 1;
            this.btnAtores.Text = "Ver atores";
            this.btnAtores.UseVisualStyleBackColor = true;
            this.btnAtores.Click += new System.EventHandler(this.btnAtores_Click);
            // 
            // btnPersonagens
            // 
            this.btnPersonagens.Location = new System.Drawing.Point(79, 242);
            this.btnPersonagens.Name = "btnPersonagens";
            this.btnPersonagens.Size = new System.Drawing.Size(169, 48);
            this.btnPersonagens.TabIndex = 2;
            this.btnPersonagens.Text = "Ver personagens";
            this.btnPersonagens.UseVisualStyleBackColor = true;
            this.btnPersonagens.Click += new System.EventHandler(this.btnPersonagens_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 352);
            this.Controls.Add(this.btnPersonagens);
            this.Controls.Add(this.btnAtores);
            this.Controls.Add(this.btnFilmes);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnAtores;
        private System.Windows.Forms.Button btnPersonagens;
    }
}