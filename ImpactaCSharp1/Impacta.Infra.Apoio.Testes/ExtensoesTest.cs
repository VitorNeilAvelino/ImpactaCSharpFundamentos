using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Infra.Apoio.Testes
{
    [TestClass]
    public class ExtensoesTest
    {
        [TestMethod]
        public void ConverterParaDateTimeDataInvalida()
        {
            const string possivelData = "00/00/0000";
            var esperado = new DateTime(1900, 1, 1);
            Assert.AreEqual(esperado, possivelData.ConverterParaDateTime());
        }

        [TestMethod]
        public void ConverterParaDateTimeDataValida()
        {
            const string possivelData = "28/02/2013";
            var esperado = new DateTime(2013, 2, 28);
            Assert.AreEqual(esperado, possivelData.ConverterParaDateTime());
        }
    }
}