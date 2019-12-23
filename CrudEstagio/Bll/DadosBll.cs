using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudEstagio.Dao;
using System.Data;
namespace CrudEstagio.Bll
{
    public class DadosBll
    {
        DadosDao dadosDao = new DadosDao();

        public void salvar(Dados dado)
        {
            try
            {
                dadosDao.salvar(dado);
            }
            catch(Exception erro)
            {
                throw erro;
            }   

        }

        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = dadosDao.listar();

                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }

        }

        public DataTable listarPorCidade()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = dadosDao.listarPorCidade();

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void alterar(Dados dados)
        {
            try
            {
               
                dadosDao.alterar(dados);

            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(Dados dados)
        {
            try
            {
                dadosDao.excluir(dados);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
