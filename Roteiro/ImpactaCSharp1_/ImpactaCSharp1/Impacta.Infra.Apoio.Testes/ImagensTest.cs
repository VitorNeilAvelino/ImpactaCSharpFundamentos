using Impacta.Infra.Apoio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace Impacta.Infra.Apoio.Testes
{
    /// <summary>
    ///This is a test class for ImagensTest and is intended
    ///to contain all ImagensTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImagensTest
    {
        /// <summary>
        ///A test for Capturar
        ///</summary>
        [TestMethod()]
        public void CapturarTest()
        {
            Imagens.CapturarTela(string.Format("C:\\InterneSpy_{0}.png", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")));
        }
    }
}