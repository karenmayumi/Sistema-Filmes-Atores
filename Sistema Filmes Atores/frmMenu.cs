using Sistema_Filmes_Atores.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Filmes_Atores
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

       

        private void btnPersonagens_Click_1(object sender, EventArgs e)
        {
            frmPersonagem personagem = new frmPersonagem();
            personagem.Show();
        }

        private void btnFilmes_Click_1(object sender, EventArgs e)
        {
            frmFilmes filmes = new frmFilmes();
            filmes.Show();
        }

        private void btnAtores_Click_1(object sender, EventArgs e)
        {
            frmAtores atores = new frmAtores();
            atores.Show();
        }
    }
}
