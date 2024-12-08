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
    public partial class frmPersonagensVerDados : Form
    {
        FilmeDAO fDAO = new FilmeDAO();
        PersonagemDAO pDAO = new PersonagemDAO();
        FilmeEntidade filme = new FilmeEntidade();
        PersonagemEntidade personagem = new PersonagemEntidade();
        AtorEntidade ator = new AtorEntidade();
        int LinhaSelecionada;
        string mode = "None";
        public frmPersonagensVerDados(int id, string metodo)
        {
            InitializeComponent();

            DesabilitarAlteracao();
            txtAtor.BackColor = Color.FromArgb(36, 1, 0);
            txtAtor.ForeColor = Color.FromArgb(255, 255, 255);

            if (metodo == "dtFilme")
            {
                filme = fDAO.PesquisarID(id);

                lblFilmeElenco.Text = filme.Titulo;
            }
            else
            {
                personagem = pDAO.PesquisarID(id);
                txtNome.Text = personagem.Nome;
                txtPapel.Text = personagem.Papel;
                lblFilmeElenco.Text = personagem.tituloFilme;
                txtAtor.Text = personagem.nomeAtor;

                filme = fDAO.PesquisarID(personagem.filmeID);
                AtivarBtn(btnExcluir);
                AtivarBtn(btnEditar);
            }
            AtualizarGrid(pDAO.PesquisarPersonagensDoFilme(filme.Titulo));
        }
        private void AtivarBtn(Control btn)
        {
            btn.BackColor = Color.FromArgb(255,255,255);
            btn.Enabled = true;
        }
        private void DesativarBtn(Control btn)
        {
            btn.BackColor = Color.FromArgb(202, 202, 202);
            btn.Enabled = false;
        }
        private void DesabilitarAlteracao()
        {
            txtNome.ReadOnly = true;
            txtNome.BackColor = Color.FromArgb(36, 1, 0);
            txtNome.ForeColor = Color.FromArgb(255, 255, 255);

            txtPapel.ReadOnly = true;
            txtPapel.BackColor = Color.FromArgb(36, 1, 0);
            txtPapel.ForeColor = Color.FromArgb(255, 255, 255);
            DesativarBtn(btnAtor);
            DesativarBtn(btnSalvar);
            DesativarBtn(btnExcluir);
            
            mode = "none";
        }
        private void HabilitarAlteracao(string mode1)
        {
            txtNome.ReadOnly = false;
            txtNome.BackColor = Color.FromArgb(127, 7, 8);
            txtNome.ForeColor = Color.FromArgb(255,255,255);
            txtPapel.ReadOnly = false;
            txtPapel.BackColor = Color.FromArgb(127, 7, 8);
            txtPapel.ForeColor = Color.FromArgb(255, 255, 255);
            AtivarBtn(btnAtor);
            AtivarBtn(btnSalvar);
            mode = mode1;
        }
        private void AtualizarGrid(DataTable dados)
        {
            dtPersonagens.DataSource = dados;
        }
        private void limparCampos()
        {
            txtNome.Text = "";
            txtPapel.Text = "";
            txtAtor.Text = "";
            lblIdAtor.Text = "idAtor";
            lblIdAtor.Visible = false;
            lblIdPersonagem.Text = "idPersonagem";
            lblIdPersonagem.Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarAlteracao("Adicionar");
            limparCampos();

            DesativarBtn(btnExcluir);
            DesativarBtn(btnEditar);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PersonagemEntidade pAdd = new PersonagemEntidade();
            pAdd.Nome = txtNome.Text;
            pAdd.Papel = txtPapel.Text;
            pAdd.filmeID = filme.Id;
            pAdd.atorID = Convert.ToInt32(lblIdAtor.Text);
            int resp = 0;

            if(mode == "Adicionar")
            {
            resp = pDAO.Inserir(pAdd);
            }else if(mode ==  "Editar")
            {
                pAdd.personagemID = Convert.ToInt32(lblIdPersonagem.Text);
                resp = pDAO.AtualizarPersonagem(pAdd);
            }
            if(resp == 1)
            {
                DesabilitarAlteracao();
                AtualizarGrid(pDAO.PesquisarPersonagensDoFilme(filme.Titulo));
            }
            else
            {
                MessageBox.Show("Erro ao adicionar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtPersonagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limparCampos();
            LinhaSelecionada = e.RowIndex;
            int id = Convert.ToInt32(dtPersonagens.Rows[LinhaSelecionada].Cells[0].Value);
            personagem = pDAO.PesquisarID(id);
            lblIdPersonagem.Text = personagem.personagemID.ToString();
            txtNome.Text =  personagem.Nome.ToString();
            txtPapel.Text = personagem.Papel.ToString();
            txtAtor.Text =  personagem.nomeAtor.ToString();
            lblIdAtor.Text= personagem.atorID.ToString();

            DesabilitarAlteracao();
            AtivarBtn(btnEditar);
            AtivarBtn(btnExcluir);
        }

        private void btnAtor_Click(object sender, EventArgs e)
        {
            frmpSelecionarAtor frmator = new frmpSelecionarAtor();
            frmator.ShowDialog();
            ator = frmator.atorDevolvido;
            lblIdAtor.Text = ator.Id.ToString();
            txtAtor.Text = ator.Nome;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarAlteracao("Editar");

            DesativarBtn(btnExcluir);
            AtivarBtn(btnAdicionar);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show(
                "Tem certeza que deseja excluir o personagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                int idpersonagem = Convert.ToInt32(dtPersonagens.Rows[LinhaSelecionada].Cells[0].Value);
                pDAO.ExcluirPersonagem(idpersonagem);
                AtualizarGrid(pDAO.PesquisarPersonagensDoFilme(filme.Titulo));
                limparCampos();
                DesabilitarAlteracao();
            }
        }
    }
}
