
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmUsuariosEditar
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radNaoAdmin = new System.Windows.Forms.RadioButton();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.grbAtivo = new System.Windows.Forms.GroupBox();
            this.radNaoAtivo = new System.Windows.Forms.RadioButton();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grbTipo.SuspendLayout();
            this.grbAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblId.ForeColor = System.Drawing.SystemColors.Window;
            this.lblId.Location = new System.Drawing.Point(42, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(66, 17);
            this.lblId.TabIndex = 112;
            this.lblId.Text = "idUsuario";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Location = new System.Drawing.Point(46, 163);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(263, 24);
            this.txtSenha.TabIndex = 108;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Location = new System.Drawing.Point(45, 90);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(263, 24);
            this.txtLogin.TabIndex = 107;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(143, 368);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(167, 33);
            this.btnAdicionar.TabIndex = 106;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(6, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 105;
            this.label10.Text = "• Tipo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(42, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 104;
            this.label8.Text = "• Senha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(42, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 103;
            this.label4.Text = "• Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.radAdmin.Location = new System.Drawing.Point(142, 25);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(73, 24);
            this.radAdmin.TabIndex = 113;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // radNaoAdmin
            // 
            this.radNaoAdmin.AutoSize = true;
            this.radNaoAdmin.Checked = true;
            this.radNaoAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNaoAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.radNaoAdmin.Location = new System.Drawing.Point(18, 25);
            this.radNaoAdmin.Name = "radNaoAdmin";
            this.radNaoAdmin.Size = new System.Drawing.Size(112, 24);
            this.radNaoAdmin.TabIndex = 114;
            this.radNaoAdmin.TabStop = true;
            this.radNaoAdmin.Text = "Funcionário";
            this.radNaoAdmin.UseVisualStyleBackColor = true;
            // 
            // grbTipo
            // 
            this.grbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbTipo.Controls.Add(this.radAdmin);
            this.grbTipo.Controls.Add(this.radNaoAdmin);
            this.grbTipo.Controls.Add(this.label10);
            this.grbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.grbTipo.Location = new System.Drawing.Point(47, 204);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(261, 61);
            this.grbTipo.TabIndex = 115;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo";
            // 
            // grbAtivo
            // 
            this.grbAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbAtivo.Controls.Add(this.radNaoAtivo);
            this.grbAtivo.Controls.Add(this.radAtivo);
            this.grbAtivo.Controls.Add(this.label1);
            this.grbAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbAtivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAtivo.ForeColor = System.Drawing.SystemColors.Control;
            this.grbAtivo.Location = new System.Drawing.Point(45, 285);
            this.grbAtivo.Name = "grbAtivo";
            this.grbAtivo.Size = new System.Drawing.Size(261, 61);
            this.grbAtivo.TabIndex = 116;
            this.grbAtivo.TabStop = false;
            this.grbAtivo.Text = "Tipo";
            this.grbAtivo.Visible = false;
            // 
            // radNaoAtivo
            // 
            this.radNaoAtivo.AutoSize = true;
            this.radNaoAtivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNaoAtivo.ForeColor = System.Drawing.SystemColors.Control;
            this.radNaoAtivo.Location = new System.Drawing.Point(144, 25);
            this.radNaoAtivo.Name = "radNaoAtivo";
            this.radNaoAtivo.Size = new System.Drawing.Size(58, 24);
            this.radNaoAtivo.TabIndex = 113;
            this.radNaoAtivo.Text = "Não";
            this.radNaoAtivo.UseVisualStyleBackColor = true;
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.Checked = true;
            this.radAtivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAtivo.ForeColor = System.Drawing.SystemColors.Control;
            this.radAtivo.Location = new System.Drawing.Point(39, 25);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(50, 24);
            this.radAtivo.TabIndex = 114;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "Sim";
            this.radAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(6, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "• Ativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(45, 368);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 33);
            this.btnExcluir.TabIndex = 117;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.Logo_Locadora_removebg_preview__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 29);
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            // 
            // frmUsuariosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(359, 446);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grbAtivo);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(433, 551);
            this.MinimumSize = new System.Drawing.Size(307, 424);
            this.Name = "frmUsuariosEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarioEditar";
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grbAtivo.ResumeLayout(false);
            this.grbAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radNaoAdmin;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.GroupBox grbAtivo;
        private System.Windows.Forms.RadioButton radNaoAtivo;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}