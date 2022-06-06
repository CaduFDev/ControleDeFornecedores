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
    public class CmdFornPF : DataAccesObject
    {
        public void Inserir(string nome, string cpf, DateTime dtc, string tel, string rg, string nasc, int fkEmp)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "InserirPF";
                    cmd.Parameters.Add(new SqlParameter("@nm",nome));
                    cmd.Parameters.Add(new SqlParameter("@cpf", cpf));
                    cmd.Parameters.Add(new SqlParameter("@dtc", dtc));
                    cmd.Parameters.Add(new SqlParameter("@tel", tel));
                    cmd.Parameters.Add(new SqlParameter("@rg", rg));
                    cmd.Parameters.Add(new SqlParameter("@nasc", nasc));
                    cmd.Parameters.Add(new SqlParameter("@fkEmp", fkEmp));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
