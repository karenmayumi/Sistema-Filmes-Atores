using Sistema_Filmes_Atores.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Filmes_Atores.DAO
{
    class FilmeDAO
    {
        private string LinhaConexao = "Server=localhost;Database=FilmesAtoreskarenluane;User Id=ROOT;Password=;";
        private SqlConnection Conexao;
        public FilmeDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(FilmeEntidade filme)
        {
            Conexao.Open();
            string Query = "INSERT into FILMES (Titulo, Categoria, Duracao, IdadeIndicada, Vlr_diaria, Sinopse) VALUES (@titulo,@categoria,@duracao,@idadeindicada,@vlr_diaria,@sinopse); ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@titulo", filme.Titulo);
            SqlParameter par2 = new SqlParameter("@categoria", filme.Categoria);
            SqlParameter par3 = new SqlParameter("@duracao", filme.Duracao);
            SqlParameter par4 = new SqlParameter("@idadeindicada", filme.IdadeIndicada);
            SqlParameter par5 = new SqlParameter("@vlr_diaria", filme.Vlr_Diaria);
            SqlParameter par6 = new SqlParameter("@sinopse", filme.Sinopse);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);
            Comando.Parameters.Add(par5);
            Comando.Parameters.Add(par6);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterFilmes()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, TITULO, CATEGORIA, IDADEINDICADA, VLR_DIARIA, SINOPSE FROM FILMES ORDER BY ID DESC";
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(FilmeEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    FilmeEntidade f = new FilmeEntidade();
                    f.Id = Convert.ToInt32(Leitura[0]);
                    f.Titulo = Leitura[1].ToString();
                    f.Categoria = Leitura[2].ToString();
                    f.IdadeIndicada = Convert.ToInt32(Leitura[3]);
                    f.Vlr_Diaria = (float)Convert.ToDecimal(Leitura[4]);
                    f.Sinopse = Leitura[4].ToString();
                    retorno.Rows.Add(f.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
    }
}
