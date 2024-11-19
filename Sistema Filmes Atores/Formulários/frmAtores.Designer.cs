
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
            ((System.ComponentModel.ISupportInitialize)(this.dtAtores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtorAdd
            // 
            this.btnAtorAdd.Location = new System.Drawing.Point(541, 50);
            this.btnAtorAdd.Name = "btnAtorAdd";
            this.btnAtorAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAtorAdd.TabIndex = 5;
            this.btnAtorAdd.Text = "Adicionar Ator/Atriz";
            this.btnAtorAdd.UseVisualStyleBackColor = true;
            this.btnAtorAdd.Click += new System.EventHandler(this.btnAtorAdd_Click);
            // 
            // dtAtores
            // 
            this.dtAtores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAtores.Location = new System.Drawing.Point(46, 106);
            this.dtAtores.Name = "dtAtores";
            this.dtAtores.Size = new System.Drawing.Size(608, 297);
            this.dtAtores.TabIndex = 8;
            this.dtAtores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAtores_CellClick);
            this.dtAtores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAtores_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(46, 53);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(277, 20);
            this.txtPesquisar.TabIndex = 6;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // frmAtores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 441);
            this.Controls.Add(this.dtAtores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnAtorAdd);
            this.Name = "frmAtores";
            this.Text = "frmAtores";
            ((System.ComponentModel.ISupportInitialize)(this.dtAtores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtorAdd;
        private System.Windows.Forms.DataGridView dtAtores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}