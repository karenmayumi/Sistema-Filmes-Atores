﻿using Sistema_Filmes_Atores.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Filmes_Atores
{
    public partial class frmFilmes : Form
    {
        public frmFilmes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilmeAdd_Click(object sender, EventArgs e)
        {
            frmFilmesAdicionar addFilme = new frmFilmesAdicionar();
            addFilme.Show();
        }
    }
}
