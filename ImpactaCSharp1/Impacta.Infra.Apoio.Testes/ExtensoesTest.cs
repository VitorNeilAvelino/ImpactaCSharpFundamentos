using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Infra.Apoio.Testes
{
    [TestClass]
    public class ExtensoesTest
    {
        [TestMethod]
        public void ConverterParaDateTimeTest()
        {
            string possivelData = "00/00/0000";
            DateTime esperado = DateTime.MinValue;
            DateTime retornado;
            retornado = possivelData.ConverterParaDateTime();
            Assert.AreEqual(esperado, retornado);
        }
    }
}
