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
    public partial class frmAtores : Form
    {
        DataTable dados;
        AtorDAO dao = new AtorDAO();
        int LinhaSelecionada;
        public frmAtores()
        {
            InitializeComponent();

            dados = new DataTable();
            foreach (var atributos in typeof(AtorEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterAtores();
            dtAtores.DataSource = dados;
        }
        private void dtAtores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }
        private void btnAtorAdd_Click(object sender, EventArgs e)
        {
            frmAtoresAdicionar atoresadd = new frmAtoresAdicionar();

            //Inscreve-se no evento
            atoresadd.FormClosed += frmCursos_FormClosed;
            atoresadd.ShowDialog();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtAtores.DataSource = dao.PesquisarAtores(txtPesquisar.Text);
        }
        private void frmCursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtAtores.DataSource = dao.ObterAtores();
            LinhaSelecionada = 0;
        }

        private void dtAtores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(dtAtores.Rows[LinhaSelecionada].Cells[0].Value);
            frmAtoresEditar editar = new frmAtoresEditar(id);

            //Inscreve-se no evento
            editar.FormClosed += frmCursos_FormClosed;
            editar.ShowDialog();
        }

        private void frmAtores_Load(object sender, EventArgs e)
        {

        }
    }
}
