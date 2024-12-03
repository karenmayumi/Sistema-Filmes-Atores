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
    public partial class frmFilmesAdicionar : Form
    {
        FilmeDAO dao = new FilmeDAO();
        public frmFilmesAdicionar()
        {
            InitializeComponent();
        }

        private void btnAddFilme_Click(object sender, EventArgs e)
        {
            FilmeEntidade filme = new FilmeEntidade();
            filme.Titulo = txtTitulo.Text;
            filme.Categoria = txtCategoria.Text;
            filme.Duracao = Convert.ToInt32(numSegundosTotais.Value);
            filme.IdadeIndicada = Convert.ToInt32(numIdade.Value);
            filme.Vlr_Diaria = Convert.ToDecimal(numVlrDiaria.Text);
            filme.Sinopse = rtxtSinopse.Text;


            int resposta = dao.Inserir(filme);

            if (resposta == 1)
            {
                MessageBox.Show("Filme adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numHoras_Leave(object sender, EventArgs e)
        {
            decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
            int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

            numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
        }

        private void numMinutos_Leave(object sender, EventArgs e)
        {
            decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
            int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

            numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
        }

        private void numSegundos_Leave(object sender, EventArgs e)
        {
            decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
            int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

            numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
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

        private void numSegundosTotais_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
                int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

                int[] tempoComposto = dao.SegundosParaHoraComposta(Convert.ToInt32(numSegundosTotais.Value));
                numHoras.Value = tempoComposto[0];
                numMinutos.Value = tempoComposto[1];
                numSegundos.Value = tempoComposto[2];
            }
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

        private void numMinutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                decimal[] tempoDecimal = new decimal[] { numHoras.Value, numMinutos.Value, numSegundos.Value, numSegundosTotais.Value };
                int[] tempoInteiro = tempoDecimal.Select(d => (int)d).ToArray();

                numSegundosTotais.Value = dao.HoraCompostaParaSegundos(tempoInteiro);
            }
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
    }
}
