using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Filmes_Atores.Classes;

namespace Sistema_Filmes_Atores.Formulários
{
    public partial class frmUsuarios : Form
    {
        Usuarios usuario = new Usuarios();
        int LinhaSelecionada;
        public frmUsuarios()
        {
            InitializeComponent();

            AtualizarGrid(usuario.Pesquisar(txtPesquisar.Text));
        }
        private void AtualizarGrid(DataTable dados)
        {
            dtUsuarios.DataSource = dados;
            dtUsuarios.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtUsuarios.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtUsuarios.Columns["Admin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid(usuario.Pesquisar(txtPesquisar.Text));
        }

        private void dtUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            if (LinhaSelecionada != -1)
            {
                frmUsuariosEditar ue = new frmUsuariosEditar(Convert.ToInt32(dtUsuarios.Rows[LinhaSelecionada].Cells[0].Value), "editar");
                ue.FormClosed += frmUsuarios_FormClosed;
                ue.ShowDialog();
            }
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            AtualizarGrid(usuario.Pesquisar(txtPesquisar.Text));
            LinhaSelecionada = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmUsuariosEditar ue = new frmUsuariosEditar(Convert.ToInt32(dtUsuarios.Rows[LinhaSelecionada].Cells[0].Value), "adicionar");
            ue.FormClosed += frmUsuarios_FormClosed;
            ue.ShowDialog();
        }
    }
}
