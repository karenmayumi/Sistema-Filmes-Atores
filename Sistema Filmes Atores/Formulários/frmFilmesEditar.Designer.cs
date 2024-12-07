
namespace Sistema_Filmes_Atores.Formulários
{
    partial class frmFilmesEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmesEditar));
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtSinopse = new System.Windows.Forms.RichTextBox();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteAtor = new System.Windows.Forms.Button();
            this.btnEditAtor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numSegundos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numSegundosTotais = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numVlrDiaria = new System.Windows.Forms.NumericUpDown();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosTotais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlrDiaria)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Valor da diária:";
            // 
            // rtxtSinopse
            // 
            this.rtxtSinopse.Location = new System.Drawing.Point(55, 406);
            this.rtxtSinopse.Name = "rtxtSinopse";
            this.rtxtSinopse.Size = new System.Drawing.Size(272, 56);
            this.rtxtSinopse.TabIndex = 26;
            this.rtxtSinopse.Text = "";
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(52, 208);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(151, 20);
            this.numIdade.TabIndex = 25;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(50, 160);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(277, 20);
            this.txtCategoria.TabIndex = 23;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(51, 114);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(276, 20);
            this.txtTitulo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Idade Indicada(Acima de...):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sinopse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Categoria(s):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Título do filme:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(50, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "ID:";
            // 
            // btnDeleteAtor
            // 
            this.btnDeleteAtor.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteAtor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteAtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAtor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAtor.ImageKey = "deletar.png";
            this.btnDeleteAtor.ImageList = this.imageList1;
            this.btnDeleteAtor.Location = new System.Drawing.Point(88, 540);
            this.btnDeleteAtor.Name = "btnDeleteAtor";
            this.btnDeleteAtor.Size = new System.Drawing.Size(193, 39);
            this.btnDeleteAtor.TabIndex = 48;
            this.btnDeleteAtor.Text = "Deletar Filme";
            this.btnDeleteAtor.UseVisualStyleBackColor = false;
            this.btnDeleteAtor.Click += new System.EventHandler(this.btnDeleteAtor_Click);
            // 
            // btnEditAtor
            // 
            this.btnEditAtor.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditAtor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditAtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAtor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditAtor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAtor.ImageKey = "EDITAR.png";
            this.btnEditAtor.ImageList = this.imageList1;
            this.btnEditAtor.Location = new System.Drawing.Point(88, 483);
            this.btnEditAtor.Name = "btnEditAtor";
            this.btnEditAtor.Size = new System.Drawing.Size(193, 40);
            this.btnEditAtor.TabIndex = 47;
            this.btnEditAtor.Text = "Editar Filme";
            this.btnEditAtor.UseVisualStyleBackColor = false;
            this.btnEditAtor.Click += new System.EventHandler(this.btnEditAtor_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 31);
            this.label11.TabIndex = 58;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 31);
            this.label10.TabIndex = 57;
            this.label10.Text = ":";
            // 
            // numSegundos
            // 
            this.numSegundos.Location = new System.Drawing.Point(258, 356);
            this.numSegundos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSegundos.Name = "numSegundos";
            this.numSegundos.Size = new System.Drawing.Size(69, 20);
            this.numSegundos.TabIndex = 56;
            this.numSegundos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSegundos_KeyDown);
            this.numSegundos.Leave += new System.EventHandler(this.numSegundos_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Segundos";
            // 
            // numMinutos
            // 
            this.numMinutos.Location = new System.Drawing.Point(150, 356);
            this.numMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(74, 20);
            this.numMinutos.TabIndex = 54;
            this.numMinutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMinutos_KeyDown);
            this.numMinutos.Leave += new System.EventHandler(this.numMinutos_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Minutos";
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(52, 356);
            this.numHoras.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(59, 20);
            this.numHoras.TabIndex = 52;
            this.numHoras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numHoras_KeyDown);
            this.numHoras.Leave += new System.EventHandler(this.numHoras_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 51;
            this.label12.Text = "Horas";
            // 
            // numSegundosTotais
            // 
            this.numSegundosTotais.Location = new System.Drawing.Point(52, 307);
            this.numSegundosTotais.Maximum = new decimal(new int[] {
            216000,
            0,
            0,
            0});
            this.numSegundosTotais.Name = "numSegundosTotais";
            this.numSegundosTotais.Size = new System.Drawing.Size(149, 20);
            this.numSegundosTotais.TabIndex = 50;
            this.numSegundosTotais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSegundosTotais_KeyDown);
            this.numSegundosTotais.Leave += new System.EventHandler(this.numSegundosTotais_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 49;
            this.label13.Text = "Duração:";
            // 
            // numVlrDiaria
            // 
            this.numVlrDiaria.DecimalPlaces = 2;
            this.numVlrDiaria.Location = new System.Drawing.Point(52, 257);
            this.numVlrDiaria.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numVlrDiaria.Name = "numVlrDiaria";
            this.numVlrDiaria.Size = new System.Drawing.Size(149, 20);
            this.numVlrDiaria.TabIndex = 59;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EDITAR.png");
            this.imageList1.Images.SetKeyName(1, "deletar.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(126, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "Editar Filmes";
            // 
            // frmFilmesEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Filmes_Atores.Properties.Resources.fundoeditarfilmes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numVlrDiaria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numSegundos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numMinutos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numSegundosTotais);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDeleteAtor);
            this.Controls.Add(this.btnEditAtor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtSinopse);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmFilmesEditar";
            this.Text = "frmFilmesEditar";
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosTotais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlrDiaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtSinopse;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteAtor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSegundos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numSegundosTotais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numVlrDiaria;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEditAtor;
        private System.Windows.Forms.Label label3;
    }
}