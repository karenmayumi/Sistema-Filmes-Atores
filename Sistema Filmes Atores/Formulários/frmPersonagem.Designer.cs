
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtFilme = new System.Windows.Forms.DataGridView();
            this.txtPesqFilme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPersonagens.Location = new System.Drawing.Point(436, 138);
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.Size = new System.Drawing.Size(422, 206);
            this.dtPersonagens.TabIndex = 6;
            this.dtPersonagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(436, 112);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(422, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dtFilme
            // 
            this.dtFilme.AllowUserToAddRows = false;
            this.dtFilme.AllowUserToDeleteRows = false;
            this.dtFilme.AllowUserToResizeColumns = false;
            this.dtFilme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtFilme.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFilme.Location = new System.Drawing.Point(36, 138);
            this.dtFilme.Name = "dtFilme";
            this.dtFilme.Size = new System.Drawing.Size(357, 206);
            this.dtFilme.TabIndex = 64;
            this.dtFilme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFilme_CellClick);
            // 
            // txtPesqFilme
            // 
            this.txtPesqFilme.Location = new System.Drawing.Point(36, 112);
            this.txtPesqFilme.Name = "txtPesqFilme";
            this.txtPesqFilme.Size = new System.Drawing.Size(357, 20);
            this.txtPesqFilme.TabIndex = 66;
            this.txtPesqFilme.TextChanged += new System.EventHandler(this.txtPesqFilme_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(35, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 20);
            this.label10.TabIndex = 73;
            this.label10.Text = "Pesquisar por filme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(432, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Pesquisar por personagem:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.iconepersonagenss1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(657, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(725, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "PERSONAGENS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Logo_Locadora_removebg_preview__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(36, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 31);
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // frmPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(898, 390);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPesqFilme);
            this.Controls.Add(this.dtFilme);
            this.Controls.Add(this.dtPersonagens);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "frmPersonagem";
            this.Text = "frmPersonagem";
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtPersonagens;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dtFilme;
        private System.Windows.Forms.TextBox txtPesqFilme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}