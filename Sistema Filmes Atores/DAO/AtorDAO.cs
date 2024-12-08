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
    public class AtorDAO
    {
        private string LinhaConexao = "Server=localhost;Database=FilmesAtoreskarenluane;User Id=root;Password=;";
        private MySqlConnection Conexao;
        public AtorDAO()
        {
            Conexao = new MySqlConnection(LinhaConexao);
        }
        public int Inserir(AtorEntidade ator)
        {
            Conexao.Open();
            string Query = "INSERT into ATORES (Nome, NomeArtistico, Idade, Genero) VALUES (@nome,@nomeartistico,@idade,@genero); ";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@nome", ator.Nome);
            MySqlParameter par2 = new MySqlParameter("@nomeartistico", ator.NomeArtistico);
            MySqlParameter par3 = new MySqlParameter("@idade", ator.Idade);
            MySqlParameter par4 = new MySqlParameter("@genero", ator.Genero);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);

            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public int AtualizarAtor(AtorEntidade ator)
        {
            string Query = "UPDATE ATORES SET nome=@nome, nomeartistico=@nomeartistico, idade=@idade, genero=@genero WHERE id = @id ; ";
            Conexao.Open();
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@nome", ator.Nome);
            MySqlParameter par2 = new MySqlParameter("@nomeartistico", ator.NomeArtistico);
            MySqlParameter par3 = new MySqlParameter("@idade", ator.Idade);
            MySqlParameter par4 = new MySqlParameter("@genero", ator.Genero);
            MySqlParameter par5 = new MySqlParameter("@id", ator.Id);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);
            Comando.Parameters.Add(par5);

            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome, Nomeartistico FROM Atores";

            using (MySqlConnection connection = new MySqlConnection(LinhaConexao))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }

        public DataTable ObterAtores()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, NOME, NOMEARTISTICO, IDADE, GENERO FROM ATORES ORDER BY ID DESC";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(AtorEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    AtorEntidade a = new AtorEntidade();
                    a.Id = Convert.ToInt32(Leitura[0]);
                    a.Nome = Leitura[1].ToString();
                    a.NomeArtistico = Leitura[2].ToString();
                    a.Idade = Convert.ToInt32(Leitura[3]);
                    a.Genero = Leitura[4].ToString();
                    retorno.Rows.Add(a.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public int ExcluirAtor(int indexCurso)
        {
            Conexao.Open();
            string Query = "DELETE FROM ATORES WHERE id = @id; ";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@id", indexCurso);

            Comando.Parameters.Add(par1);
            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public DataTable PesquisarAtores(string search)
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM ATORES ORDER BY ID DESC";
            }
            else
            {
                query = "SELECT * FROM ATORES WHERE NOME LIKE '%" + search + "%' OR NOMEARTISTICO LIKE '%" + search + "%' ORDER BY ID DESC";
            }
            MySqlCommand Comando = new MySqlCommand(query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(AtorEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows) //terminar aqui
            {
                while (Leitura.Read())
                {
                    AtorEntidade a = new AtorEntidade();
                    a.Id = Convert.ToInt32(Leitura[0]);
                    a.Nome = Leitura[1].ToString();
                    a.NomeArtistico = Leitura[2].ToString();
                    a.Idade = Convert.ToInt32(Leitura[3]);
                    a.Genero = Leitura[4].ToString();
                    retorno.Rows.Add(a.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public DataTable PesquisarAtoresParaPersonagens(string search)
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT Id, nome, nomeartistico FROM ATORES ORDER BY ID DESC";
            }
            else
            {
                query = "SELECT Id, nome, nomeartistico FROM ATORES WHERE NOME LIKE '%" + search + "%' OR NOMEARTISTICO LIKE '%" + search + "%' ORDER BY ID DESC";
            }
            MySqlCommand Comando = new MySqlCommand(query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

            retorno.Columns.Add("ID");
            retorno.Columns.Add("Nome");
            retorno.Columns.Add("Apelido");

            if (Leitura.HasRows) //terminar aqui
            {
                while (Leitura.Read())
                {
                    AtorEntidade a = new AtorEntidade();
                    a.Id = Convert.ToInt32(Leitura[0]);
                    a.Nome = Leitura[1].ToString();
                    a.NomeArtistico = Leitura[2].ToString();
                    retorno.Rows.Add(a.LinhaParaPersonagem());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public AtorEntidade PesquisarID(int id)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, NomeArtistico, Idade, Genero FROM Atores Where Id = @id Order by Id desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            Comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader resultado = Comando.ExecuteReader();

            AtorEntidade a = new AtorEntidade();
            if (resultado.Read())
            {
                a.Id = resultado.GetInt32(0);
                a.Nome = resultado.GetString(1);
                a.NomeArtistico = resultado.GetString(2);
                a.Idade = resultado.GetInt32(3);
                a.Genero = resultado.GetString(4);
            }

            Conexao.Close();
            return a;
        }
    }
}
