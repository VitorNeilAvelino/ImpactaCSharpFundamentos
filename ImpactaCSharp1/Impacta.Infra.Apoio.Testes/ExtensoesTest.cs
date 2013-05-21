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
            const string textoAConverter = "12345678900";
            //const string parametro = "CPF";
            const string expected = "123.456.789-00";
            var actual = textoAConverter.ParaString("CPF");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringP1Test()
        {
            const decimal meuDecimal = 0.2M;
            const string expected = "20,0%";
            var actual = meuDecimal.ToString("P1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongToStringTest()
        {
            const long longAConverter = 12345678900;
            const string expected = "123.456.789-00";
            var actual = longAConverter.ParaString("CPF");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsObjectAPrimitiveType()
        {
            var objeto = new object();
            Assert.IsFalse(typeof(object).IsPrimitive);
            Assert.IsFalse(objeto.GetType().IsValueType);
        }

        [TestMethod]
        public void SemAcentoTest()
        {
            const string texto = "Pêssego pássaro canção e um Í maiúsculo";
            const string expected = "Pessego passaro cancao e um I maiusculo";
            var actual = texto.SemAcento();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SemCaracteresEspeciaisTest()
        {
            const string texto = "Pêssego pássaro canção e um Í maiúsculo: 1 + 1";
            const string expected = "Pessego passaro cancao e um I maiusculo: 1 + 1";
            var actual = texto.SemAcento();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for RemoverAcento
        ///</summary>
        [TestMethod()]
        public void RemoverAcentoTest()
        {
            const string texto = "Pêssego pássaro canção e um Í maiúsculo: 1 + 1";
            const string expected = "Pessego passaro cancao e um I maiusculo: 1 + 1";
            var actual = texto.RemoverAcento();
            Assert.AreEqual(expected, actual);
        }
    }
}