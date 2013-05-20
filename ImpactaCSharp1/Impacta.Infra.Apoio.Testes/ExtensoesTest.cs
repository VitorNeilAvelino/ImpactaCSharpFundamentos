using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Impacta.Infra.Apoio;

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

        [TestMethod]
        public void ToStringTest()
        {
            object objeto = "12345678900";
            const string parametro = "CPF";
            const string expected = "123.456.789-00";
            var actual = objeto.ToString(parametro);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsObjectAPrimitiveType()
        {
            var objeto = new object();
            Assert.IsFalse(typeof(object).IsPrimitive);
            Assert.IsFalse(objeto.GetType().IsValueType);
        }
    }
}