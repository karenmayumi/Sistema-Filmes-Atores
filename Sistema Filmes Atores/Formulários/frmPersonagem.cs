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
        PersonagemDAO dao = new PersonagemDAO();
        int LinhaSelecionada;
        public frmPersonagem()
        {
            InitializeComponent();

            dados = new DataTable();
            foreach (var atributos in typeof(PersonagemEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterPersonagem();
            dtPersonagens.DataSource = dados;
        }

        private void btnPersonagemAdd_Click(object sender, EventArgs e)
        {

            frmPersonagemAdicionar addPersonagem = new frmPersonagemAdicionar();
            //Inscreve-se no evento
            addPersonagem.FormClosed += frmPersonagem_FormClosed;
            addPersonagem.ShowDialog();
        }
        private void frmPersonagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtPersonagens.DataSource = dao.ObterPersonagem();
            LinhaSelecionada = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtPersonagens.DataSource = dao.PesquisarPersonagens(txtPesquisa.Text);
        }
    }
}
