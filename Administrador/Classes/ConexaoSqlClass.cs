using System;
using System.Data.SqlClient;

namespace Administrador
{
    class ConexaoSqlClass
    {
        public string stringconnection = @"Data Source = DESKTOP-6F20152\SQLEXPRESS; integrated Security = SSPI; Initial Catalog = Administrador";//apontar caminho do banco de dados
        public SqlConnection conexaoDB;//abrir a conexao com banco de dados de acordo com caminho expecificado (Connect)
        SqlDataReader dr;// objeto DataReader

        public void ConexaoOpen()
        {
            try
            {
                conexaoDB = new SqlConnection(this.stringconnection); //Conexão SQL
                conexaoDB.Open();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public Boolean Command(String arg1,String arg2)
        {
            SqlCommand comando = new SqlCommand();//Objeto Command
            comando.CommandText = $"Select Email, senha from Usuarios where Email = ('{arg1}') and senha = ('{arg2}')";
            comando.Connection = conexaoDB;
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public void Close()
        {
            conexaoDB.Close();
        }
    }   
}
