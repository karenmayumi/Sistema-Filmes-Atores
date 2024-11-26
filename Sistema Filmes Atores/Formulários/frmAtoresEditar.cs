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
    public partial class frmAtoresEditar : Form
    {
        AtorDAO dao = new AtorDAO();
        public frmAtoresEditar(int id)
        {
            InitializeComponent();

            AtorEntidade ator = new AtorEntidade();
            ator = dao.PesquisarID(id);
            txtId.Text = ator.Id.ToString();
            txtNome.Text = ator.Nome;
            txtNomeArtistico.Text = ator.NomeArtistico;
            numIdade.Value = ator.Idade;
            cbxGenero.Text = ator.Genero;
        }

        private void btnDeleteAtor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int resposta = dao.ExcluirAtor(id);

            if (resposta == 1)
            {
                MessageBox.Show("Ator excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditAtor_Click(object sender, EventArgs e)
        {
            AtorEntidade ator = new AtorEntidade();
            ator.Id = Convert.ToInt32(txtId.Text);
            ator.Nome = txtNome.Text;
            ator.NomeArtistico = txtNomeArtistico.Text;
            ator.Idade = Convert.ToInt32(numIdade.Value);
            ator.Genero = cbxGenero.Text;

            int resposta = dao.AtualizarAtor(ator);

            if (resposta == 1)
            {
                MessageBox.Show("Ator atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
