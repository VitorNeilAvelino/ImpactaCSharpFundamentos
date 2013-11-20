using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Infra.Apoio.Testes
{
    [TestClass]
    public class TransformarTest
    {
        [TestMethod]
        public void OrdenarTest()
        {
            int[] vetor = { 1, 2, 0, 9, 20, 11 };
            Transformar.Ordenar(vetor);

            foreach (var elemento in vetor)
            {
                Console.Write("{0} ", elemento);
            }
        }
    }
}