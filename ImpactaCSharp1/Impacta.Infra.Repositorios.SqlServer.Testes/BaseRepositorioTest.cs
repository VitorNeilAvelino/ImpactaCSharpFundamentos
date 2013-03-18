using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Infra.Repositorios.SqlServer.Testes
{
    [TestClass]
    public class BaseRepositorioTest
    {
        [TestMethod]
        public void ConexaoTest()
        {
            new BaseRepositorio().Conexao.Open();
        }

        [TestMethod]
        public void ExecutarProcedureTest()
        {
            var target = new OdbcRepositorio();
            target.ExecutarProcedure();
        }
    }
}