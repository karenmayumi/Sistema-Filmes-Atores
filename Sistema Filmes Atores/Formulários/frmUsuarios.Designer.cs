
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(434, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 22);
            this.label1.TabIndex = 81;
            this.label1.Text = "Clique duas vezes no usuário que";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(461, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 60);
            this.label3.TabIndex = 80;
            this.label3.Text = "Usuários";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(457, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "deseja ver mais informações";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(31, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 22);
            this.label10.TabIndex = 85;
            this.label10.Text = "Pesquisar por nome:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Location = new System.Drawing.Point(35, 55);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(349, 20);
            this.txtPesquisar.TabIndex = 84;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dtUsuarios
            // 
            this.dtUsuarios.AllowUserToAddRows = false;
            this.dtUsuarios.AllowUserToDeleteRows = false;
            this.dtUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtUsuarios.ColumnHeadersHeight = 30;
            this.dtUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtUsuarios.EnableHeadersVisualStyles = false;
            this.dtUsuarios.Location = new System.Drawing.Point(35, 100);
            this.dtUsuarios.MultiSelect = false;
            this.dtUsuarios.Name = "dtUsuarios";
            this.dtUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Crimson;
            this.dtUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtUsuarios.Size = new System.Drawing.Size(349, 316);
            this.dtUsuarios.TabIndex = 83;
            this.dtUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsuarios_CellClick);
            this.dtUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsuarios_CellDoubleClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(513, 281);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(194, 30);
            this.btnAdicionar.TabIndex = 107;
            this.btnAdicionar.Text = "Adicionar novo usuário";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(476, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 108;
            this.label2.Text = "ou";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dtUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsuarios_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dtUsuarios;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
    }
}