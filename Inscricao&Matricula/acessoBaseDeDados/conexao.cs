using MySql.Data;
using System.Data.SqlClient;
using System;
using MySql.Data.MySqlClient;

namespace Inscricao_Matricula.acessoBaseDeDados
{
    internal class Conexao
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;

        public Conexao()
        {
            
            server = "localhost";
            database = "universidade";
            username = "root"; 
            password = "Halix2020."; 

            string connectionString = $"Server={server};Database={database};User Id={username};Password={password};";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection AbrirConexao()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                // Trate exceções de conexão aqui
                throw ex;
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                // Trate exceções de conexão aqui
                throw ex;
            }
        }
    }
}
