
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
            this.dtPersonagens = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtFilme = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPesqFilme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonagens.Location = new System.Drawing.Point(435, 102);
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.Size = new System.Drawing.Size(493, 235);
            this.dtPersonagens.TabIndex = 6;
            this.dtPersonagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(435, 83);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(493, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dtFilme
            // 
            this.dtFilme.AllowUserToAddRows = false;
            this.dtFilme.AllowUserToDeleteRows = false;
            this.dtFilme.AllowUserToResizeColumns = false;
            this.dtFilme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFilme.Location = new System.Drawing.Point(34, 102);
            this.dtFilme.Name = "dtFilme";
            this.dtFilme.Size = new System.Drawing.Size(369, 235);
            this.dtFilme.TabIndex = 64;
            this.dtFilme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFilme_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Pesquisar filme";
            // 
            // txtPesqFilme
            // 
            this.txtPesqFilme.Location = new System.Drawing.Point(34, 83);
            this.txtPesqFilme.Name = "txtPesqFilme";
            this.txtPesqFilme.Size = new System.Drawing.Size(369, 20);
            this.txtPesqFilme.TabIndex = 66;
            this.txtPesqFilme.TextChanged += new System.EventHandler(this.txtPesqFilme_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 25);
            this.label10.TabIndex = 73;
            this.label10.Text = "Pesquisar por filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Pesquisar por personagem";
            // 
            // frmPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPesqFilme);
            this.Controls.Add(this.dtFilme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPersonagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "frmPersonagem";
            this.Text = "frmPersonagem";
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtPersonagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dtFilme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPesqFilme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}