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
        public DataTable InfoFornPf(int id)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "SELECT * FROM dbo.FORN_PF WHERE FK_EMP = @CNPJ;";
                    cmd.Parameters.Add(new SqlParameter("@CNPJ", id));
                    cmd.CommandType = CommandType.Text;
                    var resultado = Leitor(cmd);
                    DataTable data = new DataTable();
                    data.Load(resultado);
                    return data;
                }
            }
        }

        public DataTable ClientePf(int fk, int id)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "VerRegistrosPF";
                    cmd.Parameters.Add(new SqlParameter("@Emp", fk));
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.CommandType = CommandType.Text;
                    var resultado = cmd.ExecuteReader();
                    DataTable data = new DataTable();
                    data.Load(resultado);
                    return data;
                }
            }
        }
        public DataTable FiltroPf(int fk, string busca)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "FiltrarPF";
                    cmd.Parameters.Add(new SqlParameter("@Emp", fk));
                    cmd.Parameters.Add(new SqlParameter("@Busca", busca));
                    cmd.CommandType = CommandType.StoredProcedure;
                    var resultado = cmd.ExecuteReader();
                    DataTable data = new DataTable();
                    data.Load(resultado);
                    return data;
                }
            }
        }
    }
}
