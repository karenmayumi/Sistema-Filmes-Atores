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
    public partial class frmFilmesEditar : Form
    {
        FilmeDAO dao = new FilmeDAO();
        public frmFilmesEditar(int id)
        {
            InitializeComponent();

            FilmeEntidade filme = new FilmeEntidade();
            filme = dao.PesquisarID(id);
            txtId.Text = filme.Id.ToString();
            txtTitulo.Text = filme.Titulo;
            txtCategoria.Text = filme.Categoria;
            numSegundosTotais.Value = filme.Duracao;
            int[] tempo = dao.SegundosParaHoraComposta(filme.Duracao);
            numHoras.Value = tempo[0];
            numMinutos.Value = tempo[1];
            numSegundos.Value = tempo[2];
            numIdade.Value = filme.IdadeIndicada;
            rtxtSinopse.Text = filme.Sinopse;
            numVlrDiaria.Text = filme.Vlr_Diaria.ToString();
        }

        private void btnEditAtor_Click(object sender, EventArgs e)
        {
            FilmeEntidade f = new FilmeEntidade();
            f.Id = Convert.ToInt32(txtId.Text);
            f.Titulo = txtTitulo.Text;
            f.Categoria = txtCategoria.Text;
            f.Duracao = Convert.ToInt32(numIdade.Value);
            f.IdadeIndicada = Convert.ToInt32(numIdade.Value);
            f.Sinopse = rtxtSinopse.Text;
            f.Vlr_Diaria= Convert.ToInt32(numVlrDiaria.Text);

            int resposta = dao.AtualizarFilme(f);

            if (resposta == 1)
            {
                MessageBox.Show("Filme atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditAtor_Click_1(object sender, EventArgs e)
        {
            FilmeEntidade filme = new FilmeEntidade();
            filme.Id = Convert.ToInt32(txtId.Text);
            filme.Titulo = txtTitulo.Text;
            filme.Categoria = txtCategoria.Text;
            filme.Duracao = Convert.ToInt32(numSegundosTotais.Value);
            filme.IdadeIndicada = Convert.ToInt32(numIdade.Value);
            filme.Vlr_Diaria = (float)Convert.ToDecimal(numVlrDiaria.Text);
            filme.Sinopse = rtxtSinopse.Text;

            FilmeDAO dao = new FilmeDAO();

            int resposta = dao.AtualizarFilme(filme);

            if (resposta == 1)
            {
                MessageBox.Show("Filme atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAtor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int resposta = dao.ExcluirFilme(id);

            if (resposta == 1)
            {
                MessageBox.Show("Filme excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numSegundosTotais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
                int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

                int[] tempoComposto = dao.SegundosParaHoraComposta(Convert.ToInt32(numSegundosTotais.Value));
                numHoras.Value = tempoComposto[0];
                numMinutos.Value = tempoComposto[1];
                numSegundos.Value = tempoComposto[2];
            }
        }

        private void numSegundosTotais_Leave(object sender, EventArgs e)
        {
            decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
            int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();
            
            int[] tempoComposto = dao.SegundosParaHoraComposta(Convert.ToInt32(numSegundosTotais.Value));
            numHoras.Value = tempoComposto[0];
            numMinutos.Value = tempoComposto[1];
            numSegundos.Value = tempoComposto[2];
        }

        private void numHoras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
                int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

                numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
            }
        }

        private void numHoras_Leave(object sender, EventArgs e)
        {
            decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
            int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

            numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
        }

        private void numMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
                int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

                numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
            }
        }

        private void numMinutos_Leave(object sender, EventArgs e)
        {
             decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
             int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();
             
             numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
        }

        private void numSegundos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
                int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

                numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
            }
        }

        private void numSegundos_Leave(object sender, EventArgs e)
        {
            decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
            int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

            numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
        }
    }
}
