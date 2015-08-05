using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Apoio.Testes
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

        [TestMethod]
        public void ConversaoTeste()
        {
            var valor = 3.14m;
            var valor2 = 4.5m;
            Console.WriteLine((int)valor);
            Console.WriteLine((int)valor2);
            Console.WriteLine(Convert.ToInt32(valor));
            Console.WriteLine(Convert.ToInt32(valor2));
        }
    }
}