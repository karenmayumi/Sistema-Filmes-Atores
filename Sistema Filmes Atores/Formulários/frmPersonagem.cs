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

        int LinhaSelecionadaA;
        int LinhaSelecionadaF;
        int LinhaSelecionadaP;
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

            AtualizarGridFilme(filmeDao.ObterFilmesParaPersonagens());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtPersonagens.DataSource = personagemDao.PesquisarPersonagens(txtPesquisa.Text);
        }

        private void txtPesqFilme_TextChanged(object sender, EventArgs e)
        {
            dtFilme.DataSource = filmeDao.PesquisarFilmesParaPersonagens(txtPesqFilme.Text);
        }

        private void dtFilme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionadaF = e.RowIndex;

            frmPersonagemAdicionar p = new frmPersonagemAdicionar(Convert.ToInt32(dtFilme.Rows[LinhaSelecionadaF].Cells[0].Value), "Por filme");
            p.FormClosed += frmPersonagens_FormClosed;
            p.ShowDialog();
        }
        private void frmPersonagens_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtFilme.DataSource = filmeDao.ObterFilmesParaPersonagens();
            LinhaSelecionadaF = 0;
        }

        private void dtPersonagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            LinhaSelecionadaP = e.RowIndex;

            frmPersonagemAdicionar p = new frmPersonagemAdicionar(Convert.ToInt32(dtPersonagens.Rows[LinhaSelecionadaP].Cells[0].Value),"Por personagem");
            p.FormClosed += frmPersonagens_FormClosed;
            p.ShowDialog();
        }
    }
}// não esquecer de puxar os dados do personagem no formulário addPersonagens. Só ta indo o ator e o filme
