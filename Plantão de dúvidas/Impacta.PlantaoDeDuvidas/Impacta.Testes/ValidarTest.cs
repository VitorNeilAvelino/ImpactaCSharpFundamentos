using System.Xml;
using Impacta.Infra.Apoio;
using Impacta.Testes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;

namespace Impacta.Testes
{
    [TestClass]
    public class ValidarTest
    {
        [TestMethod]
        public void XmlTest()
        {
            var xml = XDocument.Parse(Resources.K033Xml);
            var xsd = Resources.K033Xsd;
            Validar.Xml(xml, xsd);
        }

        [TestMethod]
        [ExpectedException(typeof(XmlException))]
        public void XmlMalFormadoTest()
        {
            var xml = XDocument.Parse(Resources.K033XmlMalFormado);
            var xsd = Resources.K033Xsd;
            Validar.Xml(xml, xsd);
        }
    }
}