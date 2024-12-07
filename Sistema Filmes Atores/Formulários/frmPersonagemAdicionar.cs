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
using Sistema_Filmes_Atores.Classes;

namespace Sistema_Filmes_Atores.Formulários
{
    public partial class frmPersonagemAdicionar : Form
    {

        AtorDAO atorDao = new AtorDAO();
        FilmeDAO filmeDao = new FilmeDAO();
        PersonagemDAO personagemDao = new PersonagemDAO();
        FilmeEntidade filme;
        Control[] campos;
        string mode = "none";

        int LinhaSelecionadaA;
        int LinhaSelecionadaP;
        private void AtualizarGridAtor(DataTable dados)
        {
            dtAddAtor.DataSource = dados;
        }
        private void AtualizarGridPersonagens(DataTable dados)
        {
            dtPersonagens.DataSource = dados;
        }private void resetCampos()
        {
            txtNomePersonagem.Text = "";
            txtPapel.Text = "";
        }

        public frmPersonagemAdicionar(int id, string MetodoSelecionado)
        {
            InitializeComponent();

            AtualizarGridAtor(atorDao.ObterAtores());

            if(MetodoSelecionado == "Por filme")
            {
            filme = filmeDao.PesquisarID(id);
                lblnomeFilme.Text = filme.Titulo;
                txtFilme.Text = filme.Titulo;
            }
            else
            {
                PersonagemEntidade personagem = new PersonagemEntidade();
                personagem = personagemDao.PesquisarID(id);
                filme = filmeDao.PesquisarID(personagem.filmeID);
                txtPapel.Text = personagem.Papel;
                txtNomePersonagem.Text = personagem.Nome;
                lblIdPersonagem.Text = Convert.ToString(personagem.personagemID);
                txtAtor.Text = personagem.nomeAtor;
                lblIdAtor.Text = Convert.ToString(personagem.atorID);
                lblnomeFilme.Text = personagem.tituloFilme;
                txtFilme.Text = personagem.tituloFilme;
                mode = "Editar";
                lblTitulo.Text = "Editar Personagem";
            }

            AtualizarGridAtor(atorDao.ObterAtores());
            AtualizarGridPersonagens(personagemDao.PesquisarPersonagensDoFilme(filme.Titulo));

            campos = new Control[] { txtNomePersonagem, txtPapel, txtAtor, txtFilme };
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            int resposta = 0;
            if (Ferramentas.VerificarCamposPreenchidos(campos))
            {
                if (mode == "Adicionar")
                {
                    PersonagemEntidade personagem1 = new PersonagemEntidade();
                    personagem1.atorID = Convert.ToInt32(lblIdAtor.Text);
                    personagem1.filmeID = filme.Id;
                    personagem1.Nome = txtNomePersonagem.Text;
                    personagem1.Papel = txtPapel.Text;
                    resposta = personagemDao.Inserir(personagem1);
                }
                else if (mode == "Editar")
                {
                    PersonagemEntidade personagem = new PersonagemEntidade();
                    personagem.personagemID = Convert.ToInt32(lblIdPersonagem.Text);
                    personagem.atorID = Convert.ToInt32(lblIdAtor.Text);
                    personagem.filmeID = filme.Id;
                    personagem.Nome = txtNomePersonagem.Text;
                    personagem.Papel = txtPapel.Text;
                    resposta = personagemDao.AtualizarPersonagem(personagem);

                }
                if (resposta == 1)
                {
                    //MessageBox.Show("Personagem editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridPersonagens(personagemDao.PesquisarPersonagensDoFilme(filme.Titulo));
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtAddAtor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            resetCampos();
            LinhaSelecionadaA = e.RowIndex;

            lblIdAtor.Text = dtAddAtor.Rows[LinhaSelecionadaA].Cells[0].Value.ToString();
            txtAtor.Text = dtAddAtor.Rows[LinhaSelecionadaA].Cells[1].Value.ToString();

            lblTitulo.Text = "Adicionar Personagem";
            mode = "Adicionar";
            lblIdPersonagem.Text = "";
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            dtAddAtor.DataSource = atorDao.PesquisarAtores(txtPesquisar.Text);
        }

        private void dtPersonagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            resetCampos();
            lblTitulo.Text = "Editar Personagem";
            mode = "Editar";

            LinhaSelecionadaP = e.RowIndex;

            lblIdPersonagem.Text = dtPersonagens.Rows[LinhaSelecionadaP].Cells[0].Value.ToString();
            txtNomePersonagem.Text = dtPersonagens.Rows[LinhaSelecionadaP].Cells[1].Value.ToString();
            txtPapel.Text = dtPersonagens.Rows[LinhaSelecionadaP].Cells[2].Value.ToString();
            txtAtor.Text = dtPersonagens.Rows[LinhaSelecionadaP].Cells[3].Value.ToString();
            lblIdAtor.Text = dtPersonagens.Rows[LinhaSelecionadaP].Cells[4].Value.ToString();
        }

        private void dtPersonagens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var resp = MessageBox.Show(
                "Tem certeza que deseja excluir o personagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resp == DialogResult.Yes)
            {
            int idpersonagem = Convert.ToInt32(dtPersonagens.Rows[LinhaSelecionadaP].Cells[0].Value);
            personagemDao.ExcluirPersonagem(idpersonagem);
            AtualizarGridPersonagens(personagemDao.PesquisarPersonagensDoFilme(filme.Titulo));
            resetCampos();
            }

        }

        private void frmPersonagemAdicionar_Load(object sender, EventArgs e)
        {

        }

        private void lblnomeFilme_Click(object sender, EventArgs e)
        {

        }

        private void dtPersonagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
