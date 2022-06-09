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
    public class CmdFornPJ : DataAccesObject
    {
        public void Inserir(string nome, string cpj, DateTime dtc, string tel, int fkEmp)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "InserirPJ";
                    cmd.Parameters.Add(new SqlParameter("@nm", nome));
                    cmd.Parameters.Add(new SqlParameter("@cpj", cpj));
                    cmd.Parameters.Add(new SqlParameter("@dtc", dtc));
                    cmd.Parameters.Add(new SqlParameter("@tel", tel));
                    cmd.Parameters.Add(new SqlParameter("@fkEmp", fkEmp));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
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

        public DataTable ClientePj(int fk, int id)
        {
            using (var acesso = AcessoDAO())
            {
                acesso.Open();
                using (var cmd = Comando(acesso))
                {
                    cmd.CommandText = "VerRegistrosPJ";
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
                    cmd.CommandText = "FiltrarPJ";
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

