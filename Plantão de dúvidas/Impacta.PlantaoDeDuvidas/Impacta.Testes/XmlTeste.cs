using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xml.XMLGen;

namespace Impacta.Testes
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class XmlTeste
    {
        [TestMethod]
        public void TestMethod1()
        {
            XmlTextWriter textWriter = new XmlTextWriter(@"C:\po.xml", null);
            textWriter.Formatting = Formatting.Indented;
            XmlQualifiedName qname = new XmlQualifiedName("PurchaseOrder", "http://tempuri.org");

            string enderecoXsd = @"C:\po.xsd";

            XmlSampleGenerator generator = new XmlSampleGenerator(enderecoXsd, qname);
            generator.WriteXml(textWriter);
        }
    }
}
