using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Filmes_Atores.Classes
{
    public class Login
    {
        public MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=FilmesAtoreskarenluane;User Id=root;Password=;");
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Admin { get; set; }

        public bool Logar()
        {
            string query = "Select Login, Id, Ativo, Admin from usuarios where Senha = @senha AND Login = @login AND ativo = 1";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@senha", Senha));
            comando.Parameters.Add(new MySqlParameter("@login", Usuario));
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.HasRows)
            {
                Conexao.Close();
                return true;
            }
            else
            {
                Conexao.Close();
                return false;
            }
        }
        public bool LogarAdmin()
        {
            string query = "Select Login, Id, Ativo, Admin from usuarios where Senha = @senha AND Login = @login AND ativo = 1 AND Admin = 1";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@senha", Senha));
            comando.Parameters.Add(new MySqlParameter("@login", Usuario));
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.HasRows)
            {
                Conexao.Close();
                return true;
            }
            else
            {
                Conexao.Close();
                return false;
            }
        }
    }
}
