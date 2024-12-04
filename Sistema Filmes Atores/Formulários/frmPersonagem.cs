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
    public partial class frmPersonagem : Form
    {
        DataTable dados;
        AtorDAO atorDao = new AtorDAO();
        FilmeDAO filmeDao = new FilmeDAO();
        PersonagemDAO personagemDao = new PersonagemDAO();
        int LinhaSelecionada;
        private void AtualizarGridAtor(DataTable dados)
        {
            dtAtor.DataSource = dados;
        }
        private void AtualizarGridFilme(DataTable dados)
        {
            dtFilme.DataSource = dados;
        }
        public frmPersonagem()
        {
            InitializeComponent();

            dados = new DataTable();
            foreach (var atributos in typeof(PersonagemEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = personagemDao.ObterPersonagem();
            dtPersonagens.DataSource = dados;

            AtualizarGridAtor(atorDao.ObterAtores());
            AtualizarGridFilme(filmeDao.ObterFilmes());
        }

        private void btnPersonagemAdd_Click(object sender, EventArgs e)
        {

            //frmPersonagemAdicionar addPersonagem = new frmPersonagemAdicionar();
            ////Inscreve-se no evento
            //addPersonagem.FormClosed += frmPersonagem_FormClosed;
            //addPersonagem.ShowDialog();



            // ----------------------------------------------------
            // encontrar maneira de adicionar id no objeto e mostrar nome no txt com ator e com filme
            // deixar txt disabled
            // adicionar acao de ao dar enter ou clicar, adicionar/mudar lá no txt
            // ----------------------------------------------------



            //PersonagemEntidade personagem = new PersonagemEntidade();
            //personagem.atorID = txtAtor.Text;
            //personagem.filmeID = Convert.ToInt32(txtFilme.SelectedValue);
            //personagem.Nome = txtNomePersonagem.Text;
            //personagem.Papel = txtPapel.Text;


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
        private void frmPersonagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtPersonagens.DataSource = personagemDao.ObterPersonagem();
            LinhaSelecionada = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtPersonagens.DataSource = personagemDao.PesquisarPersonagens(txtPesquisa.Text);
        }

        private void txtPesqAtor_TextChanged(object sender, EventArgs e)
        {
            dtAtor.DataSource = atorDao.PesquisarAtores(txtPesqAtor.Text);
        }

        private void txtPesqFilme_TextChanged(object sender, EventArgs e)
        {
            dtFilme.DataSource = filmeDao.PesquisarFilmes(txtPesqFilme.Text);
        }
    }
}
