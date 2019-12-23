using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CrudEstagio.Dao
{
    public class Conexao
    {
        string bdConnection = "SERVER=localhost; DATABASE=contatos; UID=root; PWD=";
        protected MySqlConnection conexao = null;

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(bdConnection);
                conexao.Open();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(bdConnection);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
