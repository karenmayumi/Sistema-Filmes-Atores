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
    public partial class frmPersonagemAdicionar : Form
    {

        AtorDAO atorDao = new AtorDAO();
        FilmeDAO filmeDao = new FilmeDAO();
        PersonagemDAO personagemDao = new PersonagemDAO();
        private void AtualizarGridAtor(DataTable dados)
        {
            dtAtor.DataSource = dados;
        }
        private void AtualizarGridFilme(DataTable dados)
        {
            dtFilme.DataSource = dados;
        }
        public frmPersonagemAdicionar()
        {
            InitializeComponent();

            cbAddAtor.DataSource = atorDao.PreencherComboBox();
            cbAddAtor.DisplayMember = "Nome";
            cbAddAtor.ValueMember = "Id";

            cbAddFilme.DataSource = filmeDao.PreencherComboBox();
            cbAddFilme.DisplayMember = "Titulo";
            cbAddFilme.ValueMember = "Id";

            AtualizarGridAtor(atorDao.ObterAtores());
            AtualizarGridFilme(filmeDao.ObterFilmes());
        }

        private void cbAddAtor_TextChanged(object sender, EventArgs e)
        {
            dtAtor.DataSource = atorDao.PesquisarAtores(cbAddAtor.Text);
        }

        private void cbAddFilme_TextChanged(object sender, EventArgs e)
        {
            dtFilme.DataSource = filmeDao.PesquisarFilmes(cbAddFilme.Text);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PersonagemEntidade personagem = new PersonagemEntidade();
            personagem.atorID = Convert.ToInt32(cbAddAtor.SelectedValue);
            personagem.filmeID = Convert.ToInt32(cbAddFilme.SelectedValue);
            personagem.Nome = txtNomePersonagem.Text;
            personagem.Papel = txtPapel.Text;


            int resposta = personagemDao.Inserir(personagem);

            if (resposta == 1)
            {
                MessageBox.Show("Personagem adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
