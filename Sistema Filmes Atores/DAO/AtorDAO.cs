﻿using Sistema_Filmes_Atores.Entidades;
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
        private string LinhaConexao = "Server=localhost;Database=FilmesAtoreskarenluane;User Id=ROOT;Password='';";
        private SqlConnection Conexao;
        public AtorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public int Inserir(AtorEntidade ator)
        {
            Conexao.Open();
            string Query = "INSERT into ATORES (Nome, NomeArtistico, Idade, Genero) VALUES (@nome,@nomeartistico,@idade,@genero); ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@nome", ator.Nome);
            SqlParameter par2 = new SqlParameter("@nomeartistico", ator.NomeArtistico);
            SqlParameter par3 = new SqlParameter("@idade", ator.Idade);
            SqlParameter par4 = new SqlParameter("@genero", ator.Genero);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.Parameters.Add(par4);

            int retorno = Comando.ExecuteNonQuery();

            Conexao.Close();
            return retorno;
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome, Nomeartistico FROM Atores";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

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
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

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
        public void ExcluirAtor(int indexCurso)
        {
            Conexao.Open();
            string Query = "DELETE FROM ATORES WHERE id = @id; ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@id", indexCurso);

            Comando.Parameters.Add(par1);
            Comando.ExecuteNonQuery();
            Conexao.Close();
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
                query = "SELECT * FROM ATORES WHERE NOME LIKE '%" + search + "%' OR NOMEARTISTICO LIKE '%" + search + "%' ORDER BY NOME DESC";
            }
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

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
    }
}
