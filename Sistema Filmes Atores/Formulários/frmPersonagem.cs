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

        int LinhaSelecionadaF;
        int LinhaSelecionadaP;
        private void AtualizarGridFilme(DataTable dados)
        {
            dtFilme.DataSource = dados;
            dtFilme.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtFilme.Columns["Título"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtFilme.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void AtualizarGridPersonagens(DataTable dados)
        {
            dtPersonagens.DataSource = dados;
            dtPersonagens.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtPersonagens.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtPersonagens.Columns["Papel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtPersonagens.Columns["Filme"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        public frmPersonagem()
        {
            InitializeComponent();

            AtualizarGridPersonagens(personagemDao.ObterPersonagem());
            AtualizarGridFilme(filmeDao.ObterFilmesParaPersonagens());
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGridPersonagens(personagemDao.PesquisarPersonagens(txtPesquisa.Text));
        }

        private void txtPesqFilme_TextChanged(object sender, EventArgs e)
        {
            AtualizarGridFilme(filmeDao.PesquisarFilmesParaPersonagens(txtPesqFilme.Text));
        }

        private void dtFilme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionadaF = e.RowIndex;
            if(LinhaSelecionadaF != -1)
            {
            frmPersonagensVerDados p = new frmPersonagensVerDados(Convert.ToInt32(dtFilme.Rows[LinhaSelecionadaF].Cells[0].Value), "dtFilme");
            p.FormClosed += frmPersonagens_FormClosed;
            p.ShowDialog();
            }
        }
        private void frmPersonagens_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtFilme.DataSource = filmeDao.ObterFilmesParaPersonagens();
            LinhaSelecionadaF = 0;
        }

        private void dtPersonagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            LinhaSelecionadaP = e.RowIndex;
            if (LinhaSelecionadaP != -1)
            {
                frmPersonagensVerDados p = new frmPersonagensVerDados(Convert.ToInt32(dtPersonagens.Rows[LinhaSelecionadaP].Cells[0].Value), "dtPersonagem");
            p.FormClosed += frmPersonagens_FormClosed;
            p.ShowDialog();
            }
        }
    }
}// não esquecer de puxar os dados do personagem no formulário addPersonagens. Só ta indo o ator e o filme
