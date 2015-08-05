using Impacta.Apoio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Apoio.Testes
{
    [TestClass]
    public class ChuckTest
    {
        [TestMethod]
        public void KickSortTest()
        {
            int[] vetor = { 1, 7, 1, 5, 20, 11 };
            Chuck.KickSort(vetor);

            foreach (var elemento in vetor)
            {
                Console.Write("{0} ", elemento);
            }
        }
    }
}