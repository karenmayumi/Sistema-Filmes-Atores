using Sistema_Filmes_Atores.DAO;
using Sistema_Filmes_Atores.Entidades;
using Sistema_Filmes_Atores.Formulários;
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
        DataTable dados;
        FilmeDAO dao = new FilmeDAO();
        int LinhaSelecionada;
        public frmFilmes()
        {
            InitializeComponent();

            dados = new DataTable();
            foreach (var atributos in typeof(FilmeEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterFilmes();
            dtFilmes.DataSource = dados;
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
