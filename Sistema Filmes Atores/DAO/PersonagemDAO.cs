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
    public class PersonagemDAO
    {
        private string LinhaConexao = "Server=localhost;Database=FilmesAtoreskarenluane;User Id=ROOT;Password=;";
        private SqlConnection Conexao;
        public PersonagemDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(PersonagemEntidade personagem)
        {
            Conexao.Open();
            string query = "Insert into PERSONAGENS (personagemID, filmeID, atorID, Nome, Papel) Values (@personagemid, @filmeid, @atorid, @nome, @papel) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@personagemid", personagem.personagemID);
            SqlParameter parametro2 = new SqlParameter("@filmeid", personagem.filmeID);
            SqlParameter parametro3 = new SqlParameter("@atorid", personagem.atorID);
            SqlParameter parametro4 = new SqlParameter("@nome", personagem.Nome);
            SqlParameter parametro5 = new SqlParameter("@papel", personagem.Papel);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterPersonagem()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            //string query = "SELECT c.Nome, d.Nome  FROM curso as c INNER JOIN disciplina as d in id.d = id.c  Order by c.Id desc";
            string query = @"SELECT personagemid, filmeid, atorid, nome FROM Personagens as P 
                            INNER JOIN ATORES as A ON A.Id = P.atorid
                            INNER JOIN FILMES as F ON F.Id = F.filmeid
                            Order by P.Id desc; ";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();

            dt.Columns.Add("personagemID");
            dt.Columns.Add("filmeID");
            dt.Columns.Add("atorID");
            dt.Columns.Add("Nome do Ator");
            dt.Columns.Add("Papel");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    PersonagemEntidade p = new PersonagemEntidade();
                    p.personagemID = Convert.ToInt32(Leitura[0]);
                    p.filmeID = Convert.ToInt32(Leitura[1]);
                    p.atorID = Convert.ToInt32(Leitura[2]);
                    p.Nome = Leitura[3].ToString();
                    p.Papel = Leitura[4].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
