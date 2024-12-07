
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
            ((System.ComponentModel.ISupportInitialize)(this.dtFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(41, 100);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(277, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar(Personagem, filme ou ator)";
            // 
            // dtFilmes
            // 
            this.dtFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFilmes.Location = new System.Drawing.Point(41, 138);
            this.dtFilmes.Name = "dtFilmes";
            this.dtFilmes.Size = new System.Drawing.Size(608, 297);
            this.dtFilmes.TabIndex = 2;
            this.dtFilmes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFilmes_CellClick);
            this.dtFilmes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFilmes_CellDoubleClick);
            // 
            // btnFilmeAdd
            // 
            this.btnFilmeAdd.Location = new System.Drawing.Point(526, 97);
            this.btnFilmeAdd.Name = "btnFilmeAdd";
            this.btnFilmeAdd.Size = new System.Drawing.Size(113, 23);
            this.btnFilmeAdd.TabIndex = 3;
            this.btnFilmeAdd.Text = "Adicionar Filme";
            this.btnFilmeAdd.UseVisualStyleBackColor = true;
            this.btnFilmeAdd.Click += new System.EventHandler(this.btnFilmeAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "FILMES";
            // 
            // frmFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilmeAdd);
            this.Controls.Add(this.dtFilmes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "frmFilmes";
            this.Text = "Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.dtFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtFilmes;
        private System.Windows.Forms.Button btnFilmeAdd;
        private System.Windows.Forms.Label label2;
    }
}

