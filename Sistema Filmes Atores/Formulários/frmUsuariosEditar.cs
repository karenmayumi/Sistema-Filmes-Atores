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
    public partial class frmUsuariosEditar : Form
    {
        Usuarios usuario = new Usuarios();
        string metodo;
        public frmUsuariosEditar(int idUsuario, string metodo1)
        {
            metodo = metodo1;
            InitializeComponent();
            if(metodo == "editar")
            {
                usuario.PesquisarPorId(idUsuario);
                txtLogin.Text = usuario.Login;
                txtSenha.Text = usuario.Senha;
                lblId.Text = usuario.Id.ToString();
                lblId.Visible = true;
                grbAtivo.Visible = true;
                btnAdicionar.Text = "Editar";
                btnExcluir.Enabled = true;
                btnExcluir.Visible = true;
                if (usuario.Ativo){radAtivo.Checked = true;}
                else{radNaoAtivo.Checked = true;}
                if (usuario.Admin){radAdmin.Checked = true;}
                else{radNaoAdmin.Checked = true;}
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Ativo = radAtivo.Checked;
            usuario.Admin = radAdmin.Checked;
            if(metodo == "editar")
            {
                if (usuario.Editar())
                {
                    this.Close();
                }
            }
            else
            {
                 if(usuario.Inserir())
                {
                    this.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (usuario.Excluir())
            {
                this.Close();
            }
            
        }
    }
}
