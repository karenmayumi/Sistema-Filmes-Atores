
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmAtoresEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtoresEditar));
            this.txtNomeArtistico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAtor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEditAtor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeArtistico
            // 
            this.txtNomeArtistico.Location = new System.Drawing.Point(51, 169);
            this.txtNomeArtistico.Name = "txtNomeArtistico";
            this.txtNomeArtistico.Size = new System.Drawing.Size(204, 20);
            this.txtNomeArtistico.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(48, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nome Artístico:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(48, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Gênero:";
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Não Binário"});
            this.cbxGenero.Location = new System.Drawing.Point(51, 258);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(204, 21);
            this.cbxGenero.TabIndex = 38;
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(51, 215);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(204, 20);
            this.numIdade.TabIndex = 36;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 126);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 20);
            this.txtNome.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(48, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(48, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome:";
            // 
            // btnDeleteAtor
            // 
            this.btnDeleteAtor.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteAtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAtor.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAtor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAtor.ImageKey = "deletar.png";
            this.btnDeleteAtor.ImageList = this.imageList1;
            this.btnDeleteAtor.Location = new System.Drawing.Point(157, 297);
            this.btnDeleteAtor.Name = "btnDeleteAtor";
            this.btnDeleteAtor.Size = new System.Drawing.Size(98, 33);
            this.btnDeleteAtor.TabIndex = 42;
            this.btnDeleteAtor.Text = "Deletar ";
            this.btnDeleteAtor.UseVisualStyleBackColor = false;
            this.btnDeleteAtor.Click += new System.EventHandler(this.btnDeleteAtor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EDITAR.png");
            this.imageList1.Images.SetKeyName(1, "deletar.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(48, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(51, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 44;
            // 
            // btnEditAtor
            // 
            this.btnEditAtor.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditAtor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditAtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAtor.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEditAtor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAtor.ImageKey = "EDITAR.png";
            this.btnEditAtor.ImageList = this.imageList1;
            this.btnEditAtor.Location = new System.Drawing.Point(51, 297);
            this.btnEditAtor.Name = "btnEditAtor";
            this.btnEditAtor.Size = new System.Drawing.Size(100, 33);
            this.btnEditAtor.TabIndex = 37;
            this.btnEditAtor.Text = "Editar ";
            this.btnEditAtor.UseVisualStyleBackColor = false;
            this.btnEditAtor.Click += new System.EventHandler(this.btnEditAtor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(87, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Editar Atores";
            // 
            // frmAtoresEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Design_sem_nome__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(301, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteAtor);
            this.Controls.Add(this.txtNomeArtistico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.btnEditAtor);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frmAtoresEditar";
            this.Text = "frmAtoresEditar";
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeArtistico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Button btnEditAtor;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAtor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}