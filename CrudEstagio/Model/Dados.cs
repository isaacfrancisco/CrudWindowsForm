using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEstagio
{
    public class Dados
    {
        int codContato;
        string nome, sexo, dataDado, cidade;

        public int CodContato 
        { 
            get { return codContato; }
            set { codContato = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string DataDado
        {
            get { return dataDado; }
            set { dataDado = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
}
