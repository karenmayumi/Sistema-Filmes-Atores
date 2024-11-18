
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilmes
            // 
            this.btnFilmes.Location = new System.Drawing.Point(82, 85);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(169, 48);
            this.btnFilmes.TabIndex = 0;
            this.btnFilmes.Text = "Ver filmes";
            this.btnFilmes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver atores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ver categorias";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFilmes);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}