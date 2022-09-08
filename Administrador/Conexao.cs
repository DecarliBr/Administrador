using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Administrador
{
    class Conexao
    {
        //Resposavel pelo apontamento ao banco de dados utilizado
        private String stringConexao;
        //Responsavel por efetuar o comando de conexão com o banco de dados
        private SqlConnection conexao;
        public String StringConexao
        {
            get { return this.stringConexao; }
            set { this.stringConexao = value; }
        }
        public SqlConnection ObjetoConexao
        {
            get { return this.ObjetoConexao; }
            set { this.conexao = value; }
        }
        public Conexao (String dadosConexao)
        {
            //criação do objeto de tipo SqlConnection
            this.conexao = new SqlConnection();
            //definindo String de conexão 
            this.StringConexao = dadosConexao;
            //informando para objeto conexão (this.conexao), qual a string de conexão que o mesmo ira utilizar (.ConnectionString= dadosConexao)
            this.conexao.ConnectionString = dadosConexao;
        }
        public void Conectar()
        {
            this.conexao.Open();
        }
        public void Desconectar()
        {
            this.conexao.Close();
        }
        
        

    }
}
