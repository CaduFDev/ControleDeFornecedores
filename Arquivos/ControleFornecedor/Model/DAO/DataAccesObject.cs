using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DataAccesObject
    {
        public string stringDeConexao { get; set; }

        public DataAccesObject()
        {
            stringDeConexao = "Server=localhost;Database=ControleFornecedores;User Id=sa;Password=35487761;";
        }

        protected SqlConnection AcessoDAO()
        {
            return new SqlConnection(stringDeConexao);
        }
        
        protected DbCommand Comando (DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        protected DbDataReader Leitor (DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
