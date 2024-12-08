﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sistema_Filmes_Atores.Classes
{
    public class Usuarios
    {

        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=FilmesAtoreskarenluane;User Id=root;Password=;");
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public bool Admin { get; set; }

        public bool Inserir()
        {
            Conexao.Open();
            string query = "Insert into Usuarios (Login , Senha, Ativo, admin) " +
                "               Values (@login, @senha, @ativo, @admin) ";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            MySqlParameter parametro1 = new MySqlParameter("@login", Login);
            MySqlParameter parametro2 = new MySqlParameter("@senha", Senha);
            MySqlParameter parametro3 = new MySqlParameter("@ativo", Ativo);
            MySqlParameter parametro4 = new MySqlParameter("@admin", Admin);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            bool resposta = Convert.ToBoolean(comando.ExecuteNonQuery());
            if (resposta)
            {
                MessageBox.Show("Usuário inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao inserir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return resposta;
        }

        public DataTable PreencherGrid()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Id, Login, Ativo, Admin FROM Usuarios order by Id desc";
            Conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados para preencher grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return dataTable;
        }

        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT Id, Login, Ativo, Admin FROM Usuarios order by Id desc";
            }
            else
            {
                query = "SELECT Id, Login, Ativo, Admin FROM Usuarios Where Login like '%" + pesquisa + "%' Order by Id desc";
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados para preencher grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return dataTable;
        }

        public bool Editar()
        {
            string query = "update Usuarios set Login = @login, Senha = @senha, Ativo = @ativo, Admin = @admin WHERE  Id = @id";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@login", Login));
            comando.Parameters.Add(new MySqlParameter("@senha", Senha));
            comando.Parameters.Add(new MySqlParameter("@ativo", Ativo));
            comando.Parameters.Add(new MySqlParameter("@admin", Admin));
            comando.Parameters.Add(new MySqlParameter("@id", Id));
            bool resposta = Convert.ToBoolean(comando.ExecuteNonQuery());
            if (resposta)
            {
                MessageBox.Show("Usuário atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return resposta;
        }

        public bool Excluir()
        {
            string query = "Delete from Usuarios WHERE  Id = @id";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", Id));
            bool resposta = Convert.ToBoolean(comando.ExecuteNonQuery());
            if (resposta)
            {
                MessageBox.Show("Usuário Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return resposta;
        }

        public void PesquisarPorId(int id)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Login, Senha, Ativo, Admin FROM Usuarios Where Id = @id Order by Id desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            Comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader resultado = Comando.ExecuteReader();

            if (resultado.Read())
            {
                Id = resultado.GetInt32(0);
                Login = resultado.GetString(1);
                Senha = resultado.GetString(2);
                Ativo = resultado.GetBoolean(3);
                Admin = resultado.GetBoolean(4);
            }

            Conexao.Close();
        }
    }
}