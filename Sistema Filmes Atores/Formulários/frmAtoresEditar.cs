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
    public partial class frmAtoresEditar : Form
    {
        AtorDAO dao = new AtorDAO();
        public frmAtoresEditar(int id)
        {
            InitializeComponent();

            AtorEntidade ator = new AtorEntidade();
            ator = dao.PesquisarID(id);
            txtId.Text = ator.Id.ToString();
            txtNome.Text = ator.Nome;
            txtNomeArtistico.Text = ator.NomeArtistico;
            numIdade.Value = ator.Idade;
            cbxGenero.Text = ator.Genero;
        }
    }
}
