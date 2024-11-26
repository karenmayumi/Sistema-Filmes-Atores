
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtores));
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
            this.btnAtorAdd.BackColor = System.Drawing.Color.Wheat;
            this.btnAtorAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtorAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAtorAdd.Location = new System.Drawing.Point(406, 94);
            this.btnAtorAdd.Name = "btnAtorAdd";
            this.btnAtorAdd.Size = new System.Drawing.Size(138, 25);
            this.btnAtorAdd.TabIndex = 5;
            this.btnAtorAdd.Text = "Adicionar Ator/Atriz";
            this.btnAtorAdd.UseVisualStyleBackColor = false;
            this.btnAtorAdd.Click += new System.EventHandler(this.btnAtorAdd_Click);
            // 
            // dtAtores
            // 
            this.dtAtores.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dtAtores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAtores.Location = new System.Drawing.Point(12, 123);
            this.dtAtores.Name = "dtAtores";
            this.dtAtores.Size = new System.Drawing.Size(717, 297);
            this.dtAtores.TabIndex = 8;
            this.dtAtores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAtores_CellClick);
            this.dtAtores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAtores_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 97);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(388, 20);
            this.txtPesquisar.TabIndex = 6;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Atores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Sistema_Filmes_Atores.Properties.Resources.filmes_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(609, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // frmAtores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(758, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtAtores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnAtorAdd);
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