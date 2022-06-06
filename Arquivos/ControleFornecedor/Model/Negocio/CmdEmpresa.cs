using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.VrFi;

namespace Model.Negocio
{
    public class CmdEmpresa : DataAccesObject
    {
        public void Inserir(string uf, string nm, string cnpj)
        {
                using (var conexao = AcessoDAO())
                {
                    conexao.Open();
                    using (var comando = Comando(conexao))
                    {
                        comando.CommandText = "InserirEmpresa";                        
                        comando.Parameters.Add(new SqlParameter("@uf", uf));
                        comando.Parameters.Add(new SqlParameter("@nm", nm));
                        comando.Parameters.Add(new SqlParameter("@cnpj", cnpj));
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.ExecuteNonQuery();
                    }
                }     
        }
    }
}
