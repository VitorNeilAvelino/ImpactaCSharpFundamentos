using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Apoio.Testes
{
    /// <summary>
    /// Summary description for Exception
    /// </summary>
    [TestClass]
    public class ExceptionTeste
    {
        [TestMethod]
        public void TestarExceptionToString()
        {
            try
            {
                throw new System.Exception("Teste");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}