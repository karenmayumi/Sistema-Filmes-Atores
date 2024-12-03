
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmFilmesAdicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.numSegundosTotais = new System.Windows.Forms.NumericUpDown();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.rtxtSinopse = new System.Windows.Forms.RichTextBox();
            this.btnAddFilme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numSegundos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numVlrDiaria = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosTotais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlrDiaria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título do filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duração";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sinopse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade Indicada(Acima de...)";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(33, 49);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(163, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(33, 121);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(163, 20);
            this.txtCategoria.TabIndex = 7;
            // 
            // numSegundosTotais
            // 
            this.numSegundosTotais.Location = new System.Drawing.Point(33, 249);
            this.numSegundosTotais.Maximum = new decimal(new int[] {
            216000,
            0,
            0,
            0});
            this.numSegundosTotais.Name = "numSegundosTotais";
            this.numSegundosTotais.Size = new System.Drawing.Size(134, 20);
            this.numSegundosTotais.TabIndex = 9;
            this.numSegundosTotais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSegundosTotais_KeyDown);
            this.numSegundosTotais.Leave += new System.EventHandler(this.numSegundosTotais_Leave);
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(33, 189);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(134, 20);
            this.numIdade.TabIndex = 10;
            // 
            // rtxtSinopse
            // 
            this.rtxtSinopse.Location = new System.Drawing.Point(243, 49);
            this.rtxtSinopse.Name = "rtxtSinopse";
            this.rtxtSinopse.Size = new System.Drawing.Size(161, 82);
            this.rtxtSinopse.TabIndex = 12;
            this.rtxtSinopse.Text = "";
            // 
            // btnAddFilme
            // 
            this.btnAddFilme.Location = new System.Drawing.Point(33, 345);
            this.btnAddFilme.Name = "btnAddFilme";
            this.btnAddFilme.Size = new System.Drawing.Size(371, 23);
            this.btnAddFilme.TabIndex = 14;
            this.btnAddFilme.Text = "Adicionar Filme";
            this.btnAddFilme.UseVisualStyleBackColor = true;
            this.btnAddFilme.Click += new System.EventHandler(this.btnAddFilme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor da diária";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Horas";
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(33, 298);
            this.numHoras.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(89, 20);
            this.numHoras.TabIndex = 18;
            this.numHoras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numHoras_KeyDown);
            this.numHoras.Leave += new System.EventHandler(this.numHoras_Leave);
            // 
            // numMinutos
            // 
            this.numMinutos.Location = new System.Drawing.Point(170, 298);
            this.numMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(89, 20);
            this.numMinutos.TabIndex = 20;
            this.numMinutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMinutos_KeyDown);
            this.numMinutos.Leave += new System.EventHandler(this.numMinutos_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Minutos";
            // 
            // numSegundos
            // 
            this.numSegundos.Location = new System.Drawing.Point(315, 298);
            this.numSegundos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSegundos.Name = "numSegundos";
            this.numSegundos.Size = new System.Drawing.Size(89, 20);
            this.numSegundos.TabIndex = 22;
            this.numSegundos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSegundos_KeyDown);
            this.numSegundos.Leave += new System.EventHandler(this.numSegundos_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Segundos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 31);
            this.label10.TabIndex = 23;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(275, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = ":";
            // 
            // numVlrDiaria
            // 
            this.numVlrDiaria.Location = new System.Drawing.Point(243, 189);
            this.numVlrDiaria.Name = "numVlrDiaria";
            this.numVlrDiaria.Size = new System.Drawing.Size(161, 20);
            this.numVlrDiaria.TabIndex = 25;
            // 
            // frmFilmesAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 394);
            this.Controls.Add(this.numVlrDiaria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numSegundos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numMinutos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddFilme);
            this.Controls.Add(this.rtxtSinopse);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.numSegundosTotais);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmesAdicionar";
            this.Text = "Adicionar Filme";
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosTotais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlrDiaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.NumericUpDown numSegundosTotais;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.RichTextBox rtxtSinopse;
        private System.Windows.Forms.Button btnAddFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSegundos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numVlrDiaria;
    }
}