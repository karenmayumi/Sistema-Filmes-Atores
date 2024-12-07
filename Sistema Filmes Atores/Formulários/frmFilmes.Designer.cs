
namespace Sistema_Filmes_Atores
{
    partial class frmFilmes
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFilmes = new System.Windows.Forms.DataGridView();
            this.btnFilmeAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(22, 89);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(277, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar(Personagem, filme ou ator)";
            // 
            // dtFilmes
            // 
            this.dtFilmes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFilmes.Location = new System.Drawing.Point(22, 115);
            this.dtFilmes.Name = "dtFilmes";
            this.dtFilmes.Size = new System.Drawing.Size(612, 267);
            this.dtFilmes.TabIndex = 2;
            this.dtFilmes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFilmes_CellClick);
            this.dtFilmes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFilmes_CellDoubleClick);
            // 
            // btnFilmeAdd
            // 
            this.btnFilmeAdd.BackColor = System.Drawing.Color.Firebrick;
            this.btnFilmeAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFilmeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmeAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFilmeAdd.Location = new System.Drawing.Point(521, 86);
            this.btnFilmeAdd.Name = "btnFilmeAdd";
            this.btnFilmeAdd.Size = new System.Drawing.Size(113, 23);
            this.btnFilmeAdd.TabIndex = 3;
            this.btnFilmeAdd.Text = "Adicionar Filme";
            this.btnFilmeAdd.UseVisualStyleBackColor = false;
            this.btnFilmeAdd.Click += new System.EventHandler(this.btnFilmeAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(574, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "FILMES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources._4831192;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(536, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 47);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Logo_Locadora_removebg_preview__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 32);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(675, 433);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilmeAdd);
            this.Controls.Add(this.dtFilmes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "frmFilmes";
            this.Text = "Filmes";
            this.Load += new System.EventHandler(this.frmFilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtFilmes;
        private System.Windows.Forms.Button btnFilmeAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

