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
        private string LinhaConexao = "Server=localhost;Database=FilmesAtoreskarenluane;User Id=root;Password=;";
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
        public int AtualizarFilme(FilmeEntidade filme)
        {
            string Query = "UPDATE FILMES SET titulo=@titulo, categoria=@categoria, duracao=@duracao, idadeindicada=@idadeindicada, sinopse=@sinopse," +
                "vlr_diaria=@vlr_diaria WHERE id = @id ; ";
            Conexao.Open();
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@titulo", filme.Titulo);
            MySqlParameter par2 = new MySqlParameter("@categoria", filme.Categoria);
            MySqlParameter par3 = new MySqlParameter("@duracao", filme.Duracao);
            MySqlParameter par4 = new MySqlParameter("@idadeindicada", filme.IdadeIndicada);
            MySqlParameter par5 = new MySqlParameter("@sinopse", filme.Sinopse);
            MySqlParameter par6 = new MySqlParameter("@vlr_diaria", filme.Vlr_Diaria);
            MySqlParameter par7 = new MySqlParameter("@id", filme.Id);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);
            Comando.Parameters.Add(par5);
            Comando.Parameters.Add(par6);
            Comando.Parameters.Add(par7);

            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public DataTable ObterFilmes()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, TITULO, CATEGORIA, DURACAO, IDADEINDICADA, VLR_DIARIA, SINOPSE FROM FILMES ORDER BY ID DESC";
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
                    f.Duracao = Convert.ToInt32(Leitura[3]);
                    f.IdadeIndicada = Convert.ToInt32(Leitura[4]);
                    f.Vlr_Diaria = (float)Convert.ToDecimal(Leitura[5]);
                    f.Sinopse = Leitura[6].ToString();
                    retorno.Rows.Add(f.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public int ExcluirFilme(int indexFilme)
        {
            Conexao.Open();
            string Query = "DELETE FROM FILMES WHERE id = @id; ";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@id", indexFilme);

            Comando.Parameters.Add(par1);
            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public DataTable PesquisarFilmes(string search)
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM FILMES ORDER BY ID DESC";
            }
            else
            {
                query = "SELECT * FROM FILMES WHERE TITULO LIKE '%" + search + "%' OR CATEGORIA LIKE '%" + search + "%' ORDER BY TITULO";
            }
            MySqlCommand Comando = new MySqlCommand(query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(FilmeEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows) //terminar aqui
            {
                while (Leitura.Read())
                {
                    FilmeEntidade f = new FilmeEntidade();
                    f.Id = Convert.ToInt32(Leitura[0]);
                    f.Titulo = Leitura[1].ToString();
                    f.Categoria = Leitura[2].ToString();
                    f.Duracao = Convert.ToInt32(Leitura[3]);
                    f.IdadeIndicada = Convert.ToInt32(Leitura[4]);
                    f.Sinopse = Leitura[5].ToString();
                    f.Vlr_Diaria = Convert.ToInt32(Leitura[6]);
                    retorno.Rows.Add(f.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public FilmeEntidade PesquisarID(int id)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM FILMES Where Id = @id Order by Id desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            Comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader resultado = Comando.ExecuteReader();

            FilmeEntidade f = new FilmeEntidade();
            if (resultado.Read())
            {
                f.Id = resultado.GetInt32(0);
                f.Titulo = resultado.GetString(1);
                f.Categoria = resultado.GetString(2);
                f.Duracao = resultado.GetInt32(3);
                f.IdadeIndicada = resultado.GetInt32(4);
                f.Sinopse = resultado.GetString(5);
                f.Vlr_Diaria = resultado.GetFloat(6);
            }

            Conexao.Close();
            return f;
        }
        public int HoraCompostaParaSegundos(int[] tempo)
        {
            int segundosTotais = (tempo[0] * 3600) + (tempo[1] * 60) + (tempo[2] * 1);
            return segundosTotais;
        }
        public int[] SegundosParaHoraComposta(int totalSegundos)
        {
            int horas = Convert.ToInt32(totalSegundos / 3600);
            int minutos = Convert.ToInt32((totalSegundos % 3600) / 60);
            int segundos = totalSegundos % 60;
            Console.WriteLine($"Hora composta: {horas:00}:{minutos:00}:{segundos:00}");
            int[] HoraComposta = new int[] { horas, minutos, segundos };
            return HoraComposta;
        }
    }
}
