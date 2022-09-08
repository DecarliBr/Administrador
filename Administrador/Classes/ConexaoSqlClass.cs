using System;
using System.Data.SqlClient;

namespace Administrador
{
    class ConexaoSqlClass
    {
        public string stringconnection;//apontar caminho do banco de dados
        public SqlConnection conexaoDB;//abrir a conexao com banco de dados de acordo com caminho expecificado (Connect)
        SqlCommand comando = new SqlCommand();//Objeto Command
        SqlDataReader dr;// objeto DataReader

        public void ConexaoOpen()
        {
            try
            {
                //referencia linha 12
                stringconnection = @"Data Source = DESKTOP-O28HAT6; integrated Security = SSPI; Initial Catalog = Administrador";
                //indicando que função da linha 13 deve conectar ao banco no caminho expecificado na linha 20
                conexaoDB = new SqlConnection(stringconnection);
                //comando para abrir conexao
                conexaoDB.Open();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public Boolean Command(String arg1,String arg2)
        {
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
