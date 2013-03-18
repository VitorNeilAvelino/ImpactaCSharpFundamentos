using System.Data;
using System.Data.Odbc;

namespace Impacta.Infra.Repositorios.SqlServer
{
    public class OdbcRepositorio : BaseRepositorio
    {
        public OdbcDataReader ExecutarProcedure()
        {
            Conexao.Open();

            var cmd = new OdbcCommand("{call spPesquisarPfcApollo(?, ?)}", Conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CNPJLoja", OdbcType.Char).Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@NroPFC", OdbcType.Int).Direction = ParameterDirection.Input;
            cmd.Parameters["@CNPJLoja"].Value = "1801";
            cmd.Parameters["@NroPFC"].Value = "1802";

            var retorno = cmd.ExecuteReader();

            Conexao.Close();

            return retorno;
        }
    }
}