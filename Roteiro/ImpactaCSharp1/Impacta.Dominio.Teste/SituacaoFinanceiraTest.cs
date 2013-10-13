using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Dominio.Teste
{
    [TestClass()]
    public class SituacaoFinanceiraTest
    {
        [TestMethod()]
        public void ConversaoDeEnumTeste()
        {
            var situacaoRecuperadaDoBanco = 0;
            var situacaoConvertidaParaEnum = (SituacaoFinanceira)situacaoRecuperadaDoBanco;

            Assert.AreEqual(situacaoConvertidaParaEnum, SituacaoFinanceira.Aberto);
            Assert.AreEqual(situacaoConvertidaParaEnum.ToString(), "Aberto");
        }
    }
}
