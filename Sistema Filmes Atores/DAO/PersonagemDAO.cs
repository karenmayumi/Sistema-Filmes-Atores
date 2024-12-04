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
        public void Inserir(PersonagemEntidade personagem)
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
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterPersonagem()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            //string query = "SELECT c.Nome, d.Nome  FROM curso as c INNER JOIN disciplina as d in id.d = id.c  Order by c.Id desc";
            string query = @"SELECT P.personagemid, F.titulo, A.nome, P.nome, P.papel FROM Personagens as P 
                            INNER JOIN ATORES as A ON A.Id = P.atorid
                            INNER JOIN FILMES as F ON F.Id = P.filmeid
                            Order by P.personagemId desc; ";
            //string query = @"SELECT * FROM Personagens ";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataReader Leitura = comando.ExecuteReader();

            //dt.Columns.Add("personagemID");
            //dt.Columns.Add("filmeID");
            //dt.Columns.Add("atorID");
            //dt.Columns.Add("Nome do Personagem");
            //dt.Columns.Add("Papel");

            dt.Columns.Add("personagemID");
            dt.Columns.Add("Nome do Filme");
            dt.Columns.Add("Nome do Ator");
            dt.Columns.Add("Nome do Personagem");
            dt.Columns.Add("Papel");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    PersonagemEntidade p = new PersonagemEntidade();
                    p.personagemID = Convert.ToInt32(Leitura[0]);
                    p.tituloFilme = Leitura[1].ToString();
                    p.nomeAtor = Leitura[2].ToString();
                    p.Nome = Leitura[3].ToString();
                    p.Papel = Leitura[4].ToString();
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
                Query = @"SELECT P.personagemid, F.titulo, A.nome, P.nome, P.papel FROM Personagens as P 
                            INNER JOIN ATORES as A ON A.Id = P.atorid
                            INNER JOIN FILMES as F ON F.Id = P.filmeid
                            Order by P.personagemId desc; ";
            }
            else
            {
                Query = @"
                        SELECT P.personagemid, F.titulo, A.nome, P.nome, P.papel 
                        FROM Personagens as P
                        INNER JOIN ATORES as A ON A.Id = P.atorid
                        INNER JOIN FILMES as F ON F.Id = P.filmeid
                        WHERE P.NOME LIKE '%" + search + @"%' 
                           OR A.NOME LIKE '%" + search + @"%'
                           OR F.TITULO LIKE '%" + search + @"%'
                        ORDER BY P.personagemId DESC;
                                        ";
            }
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Leitura = Comando.ExecuteReader();

            dt.Columns.Add("personagemID");
            dt.Columns.Add("Nome do Filme");
            dt.Columns.Add("Nome do Ator");
            dt.Columns.Add("Nome do Personagem");
            dt.Columns.Add("Papel");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    PersonagemEntidade p = new PersonagemEntidade();
                    p.personagemID = Convert.ToInt32(Leitura[0]);
                    p.tituloFilme = Leitura[1].ToString();
                    p.nomeAtor = Leitura[2].ToString();
                    p.Nome = Leitura[3].ToString();
                    p.Papel = Leitura[4].ToString();
                    dt.Rows.Add(p.LinhaLegivel());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
