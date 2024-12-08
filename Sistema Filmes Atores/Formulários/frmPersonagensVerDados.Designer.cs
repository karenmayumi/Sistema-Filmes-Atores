
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmPersonagensVerDados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPersonagens = new System.Windows.Forms.DataGridView();
            this.lblFilmeElenco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPapel = new System.Windows.Forms.TextBox();
            this.txtAtor = new System.Windows.Forms.TextBox();
            this.btnAtor = new System.Windows.Forms.Button();
            this.lblIdAtor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdPersonagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(508, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 33);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ver personagens";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "Elenco de:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtPersonagens
            // 
            this.dtPersonagens.AllowUserToAddRows = false;
            this.dtPersonagens.AllowUserToDeleteRows = false;
            this.dtPersonagens.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtPersonagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPersonagens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtPersonagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtPersonagens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtPersonagens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPersonagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtPersonagens.ColumnHeadersHeight = 30;
            this.dtPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtPersonagens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtPersonagens.EnableHeadersVisualStyles = false;
            this.dtPersonagens.Location = new System.Drawing.Point(37, 86);
            this.dtPersonagens.MultiSelect = false;
            this.dtPersonagens.Name = "dtPersonagens";
            this.dtPersonagens.ReadOnly = true;
            this.dtPersonagens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtPersonagens.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Crimson;
            this.dtPersonagens.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtPersonagens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtPersonagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPersonagens.Size = new System.Drawing.Size(376, 369);
            this.dtPersonagens.TabIndex = 81;
            this.dtPersonagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPersonagens_CellClick);
            // 
            // lblFilmeElenco
            // 
            this.lblFilmeElenco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilmeElenco.AutoSize = true;
            this.lblFilmeElenco.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmeElenco.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFilmeElenco.Location = new System.Drawing.Point(147, 61);
            this.lblFilmeElenco.Name = "lblFilmeElenco";
            this.lblFilmeElenco.Size = new System.Drawing.Size(107, 22);
            this.lblFilmeElenco.TabIndex = 82;
            this.lblFilmeElenco.Text = "nomeFilme";
            this.lblFilmeElenco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(447, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "• Nome";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(446, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 87;
            this.label8.Text = "• Papel";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(446, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 89;
            this.label10.Text = "• Ator";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(556, 418);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 37);
            this.btnEditar.TabIndex = 91;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(662, 418);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 37);
            this.btnExcluir.TabIndex = 93;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(39, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "clicado do filme(essa mensagem é invisível)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(450, 376);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(309, 33);
            this.btnAdicionar.TabIndex = 95;
            this.btnAdicionar.Text = "Adicionar novo";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(450, 418);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 37);
            this.btnSalvar.TabIndex = 96;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(450, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(309, 22);
            this.txtNome.TabIndex = 97;
            // 
            // txtPapel
            // 
            this.txtPapel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPapel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPapel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPapel.Location = new System.Drawing.Point(450, 195);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.ReadOnly = true;
            this.txtPapel.Size = new System.Drawing.Size(309, 22);
            this.txtPapel.TabIndex = 98;
            // 
            // txtAtor
            // 
            this.txtAtor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAtor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAtor.Location = new System.Drawing.Point(450, 264);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.ReadOnly = true;
            this.txtAtor.Size = new System.Drawing.Size(309, 22);
            this.txtAtor.TabIndex = 99;
            // 
            // btnAtor
            // 
            this.btnAtor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnAtor.Enabled = false;
            this.btnAtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtor.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.btnAtor.Location = new System.Drawing.Point(450, 299);
            this.btnAtor.Name = "btnAtor";
            this.btnAtor.Size = new System.Drawing.Size(117, 27);
            this.btnAtor.TabIndex = 100;
            this.btnAtor.Text = "Selecionar ator";
            this.btnAtor.UseVisualStyleBackColor = false;
            this.btnAtor.Click += new System.EventHandler(this.btnAtor_Click);
            // 
            // lblIdAtor
            // 
            this.lblIdAtor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdAtor.AutoSize = true;
            this.lblIdAtor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblIdAtor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIdAtor.Location = new System.Drawing.Point(525, 243);
            this.lblIdAtor.Name = "lblIdAtor";
            this.lblIdAtor.Size = new System.Drawing.Size(47, 17);
            this.lblIdAtor.TabIndex = 101;
            this.lblIdAtor.Text = "idAtor";
            this.lblIdAtor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblIdAtor.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Logo_Locadora_removebg_preview__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 29);
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.iconepersonagenss1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(769, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdPersonagem
            // 
            this.lblIdPersonagem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdPersonagem.AutoSize = true;
            this.lblIdPersonagem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblIdPersonagem.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIdPersonagem.Location = new System.Drawing.Point(546, 96);
            this.lblIdPersonagem.Name = "lblIdPersonagem";
            this.lblIdPersonagem.Size = new System.Drawing.Size(101, 17);
            this.lblIdPersonagem.TabIndex = 102;
            this.lblIdPersonagem.Text = "idPersonagem";
            this.lblIdPersonagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdPersonagem.Visible = false;
            // 
            // frmPersonagensVerDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(826, 515);
            this.Controls.Add(this.lblIdPersonagem);
            this.Controls.Add(this.lblIdAtor);
            this.Controls.Add(this.btnAtor);
            this.Controls.Add(this.txtAtor);
            this.Controls.Add(this.txtPapel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFilmeElenco);
            this.Controls.Add(this.dtPersonagens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPersonagensVerDados";
            this.Text = "Personagem";
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtPersonagens;
        private System.Windows.Forms.Label lblFilmeElenco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPapel;
        private System.Windows.Forms.TextBox txtAtor;
        private System.Windows.Forms.Button btnAtor;
        private System.Windows.Forms.Label lblIdAtor;
        private System.Windows.Forms.Label lblIdPersonagem;
    }
}