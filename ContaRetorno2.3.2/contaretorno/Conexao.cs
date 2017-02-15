using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace ContaRetorno
{
    class Conexao
    {

        private string MyConectionString = "Server=localhost;Database=desistencia;Uid=root;Pwd=root";

        private MySqlConnection connection;

        public int setDados(string query)
        {
            connection = new MySqlConnection(MyConectionString);

            MySqlCommand cmd;

            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = query;
                return cmd.ExecuteNonQuery();


            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable getDados(string query)
        {
            connection = new MySqlConnection(MyConectionString);

            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                return dt;

            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
            }
        }

    }
}
