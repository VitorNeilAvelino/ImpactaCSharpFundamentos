using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Apoio.Testes
{
    /// <summary>
    ///This is a test class for LogTest and is intended
    ///to contain all LogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogTest
    {
        /// <summary>
        ///A test for LogarPorEmail
        ///</summary>
        [TestMethod()]
        public void LogarPorEmailTest()
        {
            Exception ex = new Exception("Teste");
            Logar.PorEmail(ex);
        }
    }
}