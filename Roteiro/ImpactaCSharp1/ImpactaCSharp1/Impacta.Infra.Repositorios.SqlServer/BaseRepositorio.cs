using System.Configuration;
using System.Data.Odbc;

namespace Impacta.Infra.Repositorios.SqlServer
{
    public class BaseRepositorio
    {
        private OdbcConnection _conexao;
        public OdbcConnection Conexao
        {
            get { return _conexao ?? (_conexao = new OdbcConnection(ConfigurationManager.ConnectionStrings["OdbcConnectionString"].ConnectionString)); }
        }
    }
}