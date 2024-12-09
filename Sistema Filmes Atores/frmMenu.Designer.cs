
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnAtores = new System.Windows.Forms.Button();
            this.btnFilmes = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonagens = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtores
            // 
            this.btnAtores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtores.BackColor = System.Drawing.Color.Snow;
            this.btnAtores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtores.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAtores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAtores.Location = new System.Drawing.Point(291, 260);
            this.btnAtores.Name = "btnAtores";
            this.btnAtores.Size = new System.Drawing.Size(182, 49);
            this.btnAtores.TabIndex = 6;
            this.btnAtores.Text = "Atores";
            this.btnAtores.UseVisualStyleBackColor = false;
            this.btnAtores.Click += new System.EventHandler(this.btnAtores_Click_1);
            // 
            // btnFilmes
            // 
            this.btnFilmes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilmes.BackColor = System.Drawing.Color.Snow;
            this.btnFilmes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFilmes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmes.ImageKey = "(nenhum/a)";
            this.btnFilmes.ImageList = this.imageList1;
            this.btnFilmes.Location = new System.Drawing.Point(494, 260);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(182, 49);
            this.btnFilmes.TabIndex = 5;
            this.btnFilmes.Text = "Filmes";
            this.btnFilmes.UseVisualStyleBackColor = false;
            this.btnFilmes.Click += new System.EventHandler(this.btnFilmes_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconmovie.png");
            this.imageList1.Images.SetKeyName(1, "character.png");
            this.imageList1.Images.SetKeyName(2, "iconactor.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Logo_Locadora_removebg_preview__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 31);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(196, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu de Telas";
            // 
            // btnPersonagens
            // 
            this.btnPersonagens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPersonagens.BackColor = System.Drawing.Color.Snow;
            this.btnPersonagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonagens.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnPersonagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonagens.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonagens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPersonagens.Location = new System.Drawing.Point(86, 260);
            this.btnPersonagens.Name = "btnPersonagens";
            this.btnPersonagens.Size = new System.Drawing.Size(182, 49);
            this.btnPersonagens.TabIndex = 9;
            this.btnPersonagens.Text = "Personagens";
            this.btnPersonagens.UseVisualStyleBackColor = false;
            this.btnPersonagens.Click += new System.EventHandler(this.btnPersonagens_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.iconepersonagenss1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Location = new System.Drawing.Point(137, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 80);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.iconeator2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(340, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 80);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources._4831192;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(543, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 79);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.FundoMenu_IdeiaKaren_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 411);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPersonagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtores);
            this.Controls.Add(this.btnFilmes);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtores;
        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonagens;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}