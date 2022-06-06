using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using Model.DAO;

namespace Model.VrFi
{
    public class CessaoLogin : DataAccesObject
    {
        public bool VfLogin (string cnpj)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    try
                    {
                        cmd.CommandText = "SELECT * FROM dbo.EMPRESA WHERE CNPJ = @CNPJ;";
                        cmd.Parameters.Add(new SqlParameter("@CNPJ", cnpj));
                        cmd.CommandType = CommandType.Text;
                        var lerDados = Leitor(cmd);
                        if (lerDados.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }
    }
}
