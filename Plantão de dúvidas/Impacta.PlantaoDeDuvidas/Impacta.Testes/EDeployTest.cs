using Impacta.Infra.Apoio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Testes
{
    [TestClass()]
    public class EDeployTest
    {
        [TestMethod()]
        public void BuzzBizzTest()
        {
            EDeploy.BuzzBizz();
        }

        /// <summary>
        ///A test for SomaDeQuadrados
        ///</summary>
        [TestMethod()]
        public void SomaDeQuadradosTest()
        {
            int[] lista = { 1, 2, 3, 4, 5 }; // TODO: Initialize to an appropriate value
            int expected = 55; // TODO: Initialize to an appropriate value
            int actual;
            actual = EDeploy.SomaDeQuadrados(lista);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Fibonacci
        ///</summary>
        [TestMethod()]
        public void FibonacciTest()
        {
            Console.WriteLine(EDeploy.Fibonacci(5));
        }

        /// <summary>
        ///A test for CaminhoArvore
        ///</summary>
        [TestMethod()]
        public void CaminhoArvore9Test()
        {
            var noh1 = ConstruirArvore();
            int nohProcurado = 9;
            int[] esperado = { 1, 4, 2, 12, 13, 9 };

            var eDeploy = new EDeploy();
            eDeploy.CaminhoArvore(ref noh1, nohProcurado);

            Assert.IsTrue(Comparar.Vetores<int>(esperado, eDeploy._caminhoNohs.ToArray()));
        }

        [TestMethod()]
        public void CaminhoArvore1Test()
        {
            var noh1 = ConstruirArvore();
            int nohProcurado = 1;
            int[] esperado = { 1 };

            var eDeploy = new EDeploy();
            eDeploy.CaminhoArvore(ref noh1, nohProcurado);

            Assert.IsTrue(Comparar.Vetores<int>(esperado, eDeploy._caminhoNohs.ToArray()));
        }

        [TestMethod()]
        public void CaminhoArvore17Test()
        {
            var noh1 = ConstruirArvore();
            int nohProcurado = 17;

            var eDeploy = new EDeploy();
            eDeploy.CaminhoArvore(ref noh1, nohProcurado);

            Assert.AreEqual(0, eDeploy._caminhoNohs.Count);
        }

        [TestMethod()]
        public void CaminhoArvore4Test()
        {
            var noh1 = ConstruirArvore();
            int nohProcurado = 4;
            int[] esperado = {1, 4};

            var eDeploy = new EDeploy();
            eDeploy.CaminhoArvore(ref noh1, nohProcurado);

            Assert.IsTrue(Comparar.Vetores<int>(esperado, eDeploy._caminhoNohs.ToArray()));
        }

        private Arvore ConstruirArvore()
        {
            var noh1 = new Arvore { Id = 1 };
            var noh4 = new Arvore { Id = 4 };
            var noh7 = new Arvore { Id = 7 };
            var noh10 = new Arvore { Id = 10 };
            var noh2 = new Arvore { Id = 2 };
            var noh3 = new Arvore { Id = 3 };
            var noh11 = new Arvore { Id = 11 };
            var noh8 = new Arvore { Id = 8 };
            var noh12 = new Arvore { Id = 12 };
            var noh6 = new Arvore { Id = 6 };
            var noh5 = new Arvore { Id = 5 };
            var noh13 = new Arvore { Id = 13 };
            var noh9 = new Arvore { Id = 9 };

            noh1.Filhos = new Arvore[] { noh4, noh7 };
            noh4.Filhos = new Arvore[] { noh10, noh2 };
            noh7.Filhos = new Arvore[] { noh3, noh11 };
            noh10.Filhos = new Arvore[] { noh8, null };
            noh2.Filhos = new Arvore[] { noh12, null };
            noh11.Filhos = new Arvore[] { noh6, noh5 };
            noh12.Filhos = new Arvore[] { noh13, null };
            noh13.Filhos = new Arvore[] { noh9, null };

            noh8.Filhos = new Arvore[] { null, null };
            noh3.Filhos = new Arvore[] { null, null };
            noh6.Filhos = new Arvore[] { null, null };
            noh5.Filhos = new Arvore[] { null, null };
            noh9.Filhos = new Arvore[] { null, null };
            return noh1;
        }
    }
}