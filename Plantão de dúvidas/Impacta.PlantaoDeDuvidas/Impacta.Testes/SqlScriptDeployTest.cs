using Impacta.Infra.Apoio.Setup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Impacta.Testes
{
    [TestClass]
    public class SqlScriptDeployTest
    {
        [TestMethod]
        public void InstallTest()
        {
            var target = new SqlScriptDeploy();
            IDictionary statesaver = new Hashtable();
            target.Install(statesaver);
        }
    }
}
