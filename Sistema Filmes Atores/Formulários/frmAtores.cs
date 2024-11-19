using Sistema_Filmes_Atores.DAO;
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
        }

        private void btnAtorAdd_Click(object sender, EventArgs e)
        {
            frmAtoresAdicionar atoresadd = new frmAtoresAdicionar();
            atoresadd.Show();
        }

        private void dtAtores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
        }
    }
}
