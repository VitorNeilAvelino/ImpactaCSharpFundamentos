using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Testes
{
    [TestClass]
    public class IntervaloDatasTest
    {
        [TestMethod]
        public void TestarIntervaloDatas()
        {
            var dataInicial = DateTime.Now;
            var dataFinal = DateTime.Now.AddDays(10);

            var intervaloDatas = dataFinal - dataInicial;

            Assert.AreEqual(intervaloDatas.Days, 10);
        }
    }
}