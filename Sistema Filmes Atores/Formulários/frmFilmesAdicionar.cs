using Sistema_Filmes_Atores.DAO;
using Sistema_Filmes_Atores.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Filmes_Atores.Formulários
{
    public partial class frmFilmesAdicionar : Form
    {
        public frmFilmesAdicionar()
        {
            InitializeComponent();
        }

        private void btnAddFilme_Click(object sender, EventArgs e)
        {
            FilmeEntidade filme = new FilmeEntidade();
            filme.Titulo = txtTitulo.Text;
            filme.Categoria = txtCategoria.Text;
            filme.Duracao = Convert.ToInt32(numDuracao.Value);
            filme.IdadeIndicada = Convert.ToInt32(numIdade.Value);
            filme.Vlr_Diaria = (float)Convert.ToDecimal(txtVlrDiaria.Text);
            filme.Sinopse = rtxtSinopse.Text;

            FilmeDAO dao = new FilmeDAO();


            int resposta = dao.Inserir(filme);

            if (resposta == 1)
            {
                MessageBox.Show("Ator adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
