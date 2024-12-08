//using MySql.Data.MySqlClient;
using MySqlConnector;
using Sistema_Filmes_Atores.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Filmes_Atores.DAO
{
    public class PersonagemDAO
    {
        private string LinhaConexao = "Server=localhost;Database=FilmesAtoreskarenluane;User Id=root;Password=;";
        private MySqlConnection Conexao;
        public PersonagemDAO()
        {
            Conexao = new MySqlConnection(LinhaConexao);
        }
        public int Inserir(PersonagemEntidade personagem)
        {
            Conexao.Open();
            string query = "Insert into PERSONAGENS (filmeID, atorID, Nome, Papel) Values (@filmeid, @atorid, @nome, @papel) ";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            MySqlParameter parametro1 = new MySqlParameter("@filmeid", personagem.filmeID);
            MySqlParameter parametro2 = new MySqlParameter("@atorid", personagem.atorID);
            MySqlParameter parametro3 = new MySqlParameter("@nome", personagem.Nome);
            MySqlParameter parametro4 = new MySqlParameter("@papel", personagem.Papel);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            int retorno = comando.ExecuteNonQuery();
            Conexao.Close();
            return retorno;
        }
        public int AtualizarPersonagem(PersonagemEntidade per)
        {
            string Query = "UPDATE PERSONAGENS SET nome=@nome, atorID=@atorID, filmeID=@filmeID, papel=@papel " +
                "WHERE personagemid = @personagemid ; ";
            Conexao.Open();
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@nome", per.Nome);
            MySqlParameter par2 = new MySqlParameter("@atorid", per.atorID);
            MySqlParameter par3 = new MySqlParameter("@filmeid", per.filmeID);
            MySqlParameter par4 = new MySqlParameter("@papel", per.Papel);
            MySqlParameter par5 = new MySqlParameter("@personagemid", per.personagemID);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);
            Comando.Parameters.Add(par5);

            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public DataTable ObterPersonagem()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            //string query = "SELECT c.Nome, d.Nome  FROM curso as c INNER JOIN disciplina as d in id.d = id.c  Order by c.Id desc";
            string query = @"SELECT P.personagemid, P.nome, P.papel, F.titulo FROM Personagens as P 
                            INNER JOIN FILMES as F ON F.Id = P.filmeid
                            Order by P.personagemId desc; ";
            //string query = @"SELECT * FROM Personagens ";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataReader Leitura = comando.ExecuteReader();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Papel");
            dt.Columns.Add("Filme");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    PersonagemEntidade p = new PersonagemEntidade();
                    p.personagemID = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Papel = Leitura[2].ToString();
                    p.tituloFilme = Leitura[3].ToString();
                    dt.Rows.Add(p.LinhaLegivel());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable PesquisarPersonagens(string search)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string Query = "";
            if (string.IsNullOrEmpty(search))
            {
                Query = @"SELECT P.personagemid, P.nome, P.papel, F.titulo FROM Personagens as P 
                            INNER JOIN ATORES as A ON A.Id = P.atorid
                            INNER JOIN FILMES as F ON F.Id = P.filmeid
                            Order by P.personagemId desc; ";
            }
            else
            {
                Query = @"
                        SELECT P.personagemid, P.nome, P.papel, F.titulo
                        FROM Personagens as P
                        INNER JOIN ATORES as A ON A.Id = P.atorid
                        INNER JOIN FILMES as F ON F.Id = P.filmeid
                        WHERE P.NOME LIKE '%" + search + @"%' 
                           OR F.TITULO LIKE '%" + search + @"%'
                        ORDER BY P.personagemId DESC;
                                        ";
            }
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Papel");
            dt.Columns.Add("Filme");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    PersonagemEntidade p = new PersonagemEntidade();
                    p.personagemID = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Papel = Leitura[2].ToString();
                    p.tituloFilme = Leitura[3].ToString();
                    dt.Rows.Add(p.LinhaLegivel());
                }
            }
            Conexao.Close();
            return dt;
        }
        public PersonagemEntidade PesquisarID(int id)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = @"
                        SELECT P.personagemid, P.filmeid, P.atorid, P.nome, P.papel, F.titulo, A.nome
                        FROM Personagens as P
                        INNER JOIN ATORES as A ON A.Id = P.atorid
                        INNER JOIN FILMES as F ON F.Id = P.filmeid
                        WHERE P.personagemid = @id ORDER BY P.personagemId DESC;";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            Comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader resultado = Comando.ExecuteReader();

            PersonagemEntidade p = new PersonagemEntidade();
            if (resultado.Read())
            {
                p.personagemID = resultado.GetInt32(0);
                p.filmeID = resultado.GetInt32(1);
                p.atorID = resultado.GetInt32(2);
                p.Nome = resultado.GetString(3);
                p.Papel = resultado.GetString(4);
                p.tituloFilme = resultado.GetString(5);
                p.nomeAtor = resultado.GetString(6);
            }

            Conexao.Close();
            return p;
        }
        public DataTable PesquisarPersonagensDoFilme(string search)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string Query = "";
            if (string.IsNullOrEmpty(search))
            {
                Query = @"SELECT personagemid, nome,papel FROM Personagens
                            Order by personagemId desc; ";
            }
            else
            {
                Query = @"
                        SELECT P.personagemid, P.nome, P.papel
                        FROM Personagens as P
                        INNER JOIN FILMES as F ON F.Id = P.filmeid
                        WHERE F.TITULO = '" + search + @"'
                        ORDER BY P.personagemId DESC;
                                        ";
            }
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Papel");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    PersonagemEntidade p = new PersonagemEntidade();
                    p.personagemID = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Papel = Leitura[2].ToString();
                    dt.Rows.Add(p.LinhaParaPersonagemAddEdit());
                }
            }
            Conexao.Close();
            return dt;
        }
        public int ExcluirPersonagem(int i)
        {
            Conexao.Open();
            string Query = "DELETE FROM PERSONAGENS WHERE personagemid = @personagemid; ";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlParameter par1 = new MySqlParameter("@personagemid", i);

            Comando.Parameters.Add(par1);
            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public int PesquisarFilmeDoPersonagem(int search)
        {
            Conexao.Open();
            string
                Query = @"
                        SELECT F.ID 
                        FROM Personagens as P
                        INNER JOIN FILMES as F ON F.Id = P.filmeid
                        WHERE P.PERSONAGEMID = '" + search + "';";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Leitura = Comando.ExecuteReader();
            Leitura.Read();
            int idFilme = Convert.ToInt32(Leitura[0]);
            Conexao.Close();
            return idFilme;
        }
    }
}
