using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Filmes_Atores.DAO;
using Sistema_Filmes_Atores.Entidades;

namespace Sistema_Filmes_Atores.Formulários
{
    public partial class frmpSelecionarAtor : Form
    {
        AtorDAO atorDao = new AtorDAO();
        public AtorEntidade atorDevolvido = new AtorEntidade();
        int LinhaSelecionada;
        public frmpSelecionarAtor()
        {
            InitializeComponent();

            dtAtor.DataSource = atorDao.PesquisarAtoresParaPersonagens(txtPesquisar.Text);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            dtAtor.DataSource = atorDao.PesquisarAtoresParaPersonagens(txtPesquisar.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtAtor.Rows[LinhaSelecionada].Cells[0].Value);
            atorDevolvido = atorDao.PesquisarID(id);
            this.Dispose();
        }

        private void dtAtor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }
    }
}
