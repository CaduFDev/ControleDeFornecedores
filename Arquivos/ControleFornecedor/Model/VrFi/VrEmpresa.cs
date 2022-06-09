using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using Model.DAO;
using System.Data;

namespace Model.VrFi
{
    public class VrEmpresa : DataAccesObject
    {
        public bool UfEmpresa(string uf)
        {
            if (uf == "PR")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int IdEmpLogada(string cnpj)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "SELECT * FROM dbo.EMPRESA WHERE CNPJ = @CNPJ;";
                    cmd.Parameters.Add(new SqlParameter("@CNPJ", cnpj));
                    cmd.CommandType = CommandType.Text;
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    return resultado;
                }
            }
        }
        public string[] InfoEmpresa (string cnpj)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "SELECT * FROM dbo.EMPRESA WHERE CNPJ = @CNPJ;";
                    cmd.Parameters.Add(new SqlParameter("@CNPJ", cnpj));
                    cmd.CommandType = CommandType.Text;
                    string[] data = new string[4];
                    var resultado = Leitor(cmd);
                    while (resultado.Read())
                    {
                        data[0] = resultado[0].ToString();
                        data[1] = resultado[1].ToString();
                        data[2] = resultado[2].ToString();
                        data[3] = resultado[3].ToString();
                    }                    
                    return data;
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
        public DataTable InfoFornPj(int id)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {                    
                    cmd.CommandText = "SELECT * FROM dbo.FORN_PJ WHERE FK_EMP = @CNPJ;";
                    cmd.Parameters.Add(new SqlParameter("@CNPJ", id));
                    cmd.CommandType = CommandType.Text;
                    var resultado = cmd.ExecuteReader();
                    DataTable data = new DataTable();
                    data.Load(resultado);
                    return data;
                }
            }
        }

        public DataTable ClienteInfoPj(int fk, int id)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "VerRegistrosPF;";
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
        public DataTable FiltroPj(int fk, string busca)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "FiltrarPJ;";
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

        /*-------------*/
        public DataTable ClienteInfoPf(int fk, int id)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "VerRegistrosPF;";
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
                    cmd.CommandText = "FiltrarPJ;";
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
