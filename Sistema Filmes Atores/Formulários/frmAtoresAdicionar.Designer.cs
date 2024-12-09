
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmAtoresAdicionar
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
            this.btnAddAtor = new System.Windows.Forms.Button();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeArtistico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAtor
            // 
            this.btnAddAtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.btnAddAtor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAddAtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAtor.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnAddAtor.ForeColor = System.Drawing.Color.White;
            this.btnAddAtor.Location = new System.Drawing.Point(101, 331);
            this.btnAddAtor.Name = "btnAddAtor";
            this.btnAddAtor.Size = new System.Drawing.Size(120, 39);
            this.btnAddAtor.TabIndex = 27;
            this.btnAddAtor.Text = "Adicionar";
            this.btnAddAtor.UseVisualStyleBackColor = false;
            this.btnAddAtor.Click += new System.EventHandler(this.btnAddAtor_Click);
            // 
            // numIdade
            // 
            this.numIdade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numIdade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIdade.Location = new System.Drawing.Point(79, 223);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(171, 22);
            this.numIdade.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(78, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 19);
            this.txtNome.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // cbxGenero
            // 
            this.cbxGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGenero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Não Binário"});
            this.cbxGenero.Location = new System.Drawing.Point(77, 281);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(172, 28);
            this.cbxGenero.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(77, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gênero:";
            // 
            // txtNomeArtistico
            // 
            this.txtNomeArtistico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeArtistico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeArtistico.Location = new System.Drawing.Point(79, 166);
            this.txtNomeArtistico.Name = "txtNomeArtistico";
            this.txtNomeArtistico.Size = new System.Drawing.Size(171, 19);
            this.txtNomeArtistico.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nome Artístico:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(33, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 33);
            this.label6.TabIndex = 79;
            this.label6.Text = "Cadastro de Ator";
            // 
            // frmAtoresAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.FundoAdicionarAtores;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeArtistico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.btnAddAtor);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(348, 461);
            this.MinimumSize = new System.Drawing.Size(348, 461);
            this.Name = "frmAtoresAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAtor;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeArtistico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}