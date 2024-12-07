using MapaSala.Classes;
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
    public partial class frmLogin : Form
    {
        private Login login;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login.Usuario = txtLogin.Text;
            login.Senha = txtSenha.Text;
            if (login.Logar())
            {
                frmMenu m = new frmMenu();
                m.FormClosed += FecharForm;
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
