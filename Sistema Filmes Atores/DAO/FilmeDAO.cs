using MySqlConnector;
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
        private MySqlConnection Conexao;
        public FilmeDAO()
        {
            Conexao = new MySqlConnection(LinhaConexao);
        }
        public int Inserir(FilmeEntidade filme)
        {
            Conexao.Open();
            string Query = "INSERT into FILMES (Titulo, Categoria, Duracao, IdadeIndicada, Vlr_diaria, Sinopse) VALUES (@titulo,@categoria,@duracao,@idadeindicada,@vlr_diaria,@sinopse); ";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@titulo", filme.Titulo);
            MySqlParameter par2 = new MySqlParameter("@categoria", filme.Categoria);
            MySqlParameter par3 = new MySqlParameter("@duracao", filme.Duracao);
            MySqlParameter par4 = new MySqlParameter("@idadeindicada", filme.IdadeIndicada);
            MySqlParameter par5 = new MySqlParameter("@vlr_diaria", filme.Vlr_Diaria);
            MySqlParameter par6 = new MySqlParameter("@sinopse", filme.Sinopse);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);
            Comando.Parameters.Add(par5);
            Comando.Parameters.Add(par6);
            int retorno = Comando.ExecuteNonQuery();
            Conexao.Close();
            return retorno;
        }
        public DataTable ObterFilmes()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, TITULO, CATEGORIA, IDADEINDICADA, VLR_DIARIA, SINOPSE FROM FILMES ORDER BY ID DESC";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

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
