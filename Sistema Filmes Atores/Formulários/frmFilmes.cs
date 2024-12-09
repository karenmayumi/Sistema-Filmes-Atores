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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtFilmes.DataSource = dao.PesquisarFilmes(txtPesquisa.Text);
        }

        private void frmFilmes_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtFilmes.DataSource = dao.ObterFilmes();
            LinhaSelecionada = 0;
        }
        private void dtFilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(dtFilmes.Rows[LinhaSelecionada].Cells[0].Value);
            frmFilmesEditar editar = new frmFilmesEditar(id);

            //Inscreve-se no evento
            editar.FormClosed += frmFilmes_FormClosed;
            editar.ShowDialog();
        }

        private void dtFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            LinhaSelecionada = e.RowIndex;
        }

        private void btnFilmeAdd_Click_1(object sender, EventArgs e)
        {

            frmFilmesAdicionar addFilme = new frmFilmesAdicionar();
            //Inscreve-se no evento
            addFilme.FormClosed += frmFilmes_FormClosed;
            addFilme.ShowDialog();
        }
    }
}
