﻿
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmAtores
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
            this.btnAtorAdd = new System.Windows.Forms.Button();
            this.dtAtores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtAtores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtorAdd
            // 
            this.btnAtorAdd.AllowDrop = true;
            this.btnAtorAdd.AutoEllipsis = true;
            this.btnAtorAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtorAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtorAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAtorAdd.Location = new System.Drawing.Point(447, 114);
            this.btnAtorAdd.Name = "btnAtorAdd";
            this.btnAtorAdd.Size = new System.Drawing.Size(147, 20);
            this.btnAtorAdd.TabIndex = 5;
            this.btnAtorAdd.Text = "Adicionar Ator/Atriz";
            this.btnAtorAdd.UseVisualStyleBackColor = false;
            this.btnAtorAdd.Click += new System.EventHandler(this.btnAtorAdd_Click);
            // 
            // dtAtores
            // 
            this.dtAtores.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtAtores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAtores.Location = new System.Drawing.Point(51, 155);
            this.dtAtores.Name = "dtAtores";
            this.dtAtores.Size = new System.Drawing.Size(543, 256);
            this.dtAtores.TabIndex = 8;
            this.dtAtores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAtores_CellClick);
            this.dtAtores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAtores_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar :";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(154, 114);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(287, 20);
            this.txtPesquisar.TabIndex = 6;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(278, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Atores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.iconeator;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(219, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmAtores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtAtores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnAtorAdd);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "frmAtores";
            this.Text = "frmAtores";
            ((System.ComponentModel.ISupportInitialize)(this.dtAtores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtorAdd;
        private System.Windows.Forms.DataGridView dtAtores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}