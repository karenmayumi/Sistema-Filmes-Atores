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
    public partial class frmAtoresAdicionar : Form
    {
        public frmAtoresAdicionar()
        {
            InitializeComponent();
        }

        private void btnAddAtor_Click(object sender, EventArgs e)
        {
            AtorEntidade ator = new AtorEntidade();
            ator.Nome = txtNome.Text;
            ator.NomeArtistico = txtNomeArtistico.Text;
            ator.Idade = Convert.ToInt32(numIdade.Value);
            ator.Genero = cbxGenero.Text;

            AtorDAO dao = new AtorDAO();

            

            int resposta = dao.Inserir(ator);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
