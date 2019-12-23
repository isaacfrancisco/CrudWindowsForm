using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace CrudEstagio.Dao
{
    public class DadosDao : Conexao
    {
        MySqlCommand comando = null;
        public void salvar(Dados dados)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO dados (nome, sexo, dataDado, cidade) VALUES (@nome, @sexo, @dataDado, @cidade)", conexao);

                comando.Parameters.AddWithValue("@nome", dados.Nome);
                comando.Parameters.AddWithValue("@sexo", dados.Sexo);
                comando.Parameters.AddWithValue("@dataDado", dados.DataDado);
                comando.Parameters.AddWithValue("@cidade", dados.Cidade);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable listar()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM dados ORDER BY nome", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable listarPorCidade()
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT distinct cidade as Cidade, MONTH(DataDado) MES, COUNT(*) AS TotalPorMes, Sexo FROM dados GROUP BY MONTH(DataDado),Cidade,Sexo ORDER BY MES", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public void alterar(Dados dados)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE dados SET nome = @nome, sexo = @sexo, dataDado = @datadado, cidade = @cidade WHERE codContato = @codContato", conexao);

                comando.Parameters.AddWithValue("@codContato",dados.CodContato);
                comando.Parameters.AddWithValue("@nome", dados.Nome);
                comando.Parameters.AddWithValue("@sexo", dados.Sexo);
                comando.Parameters.AddWithValue("@dataDado", dados.DataDado);
                comando.Parameters.AddWithValue("@cidade", dados.Cidade);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void excluir(Dados dados)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM dados WHERE codContato = @codContato", conexao);

                comando.Parameters.AddWithValue("@codContato",dados.CodContato);

                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
