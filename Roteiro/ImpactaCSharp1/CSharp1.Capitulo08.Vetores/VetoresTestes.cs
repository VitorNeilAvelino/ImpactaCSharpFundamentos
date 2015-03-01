using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CSharp1.Capitulo08.Vetores
{
    [TestClass]
    public class VetoresTestes
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var meuVetorDeStrings = new string[10];
            var meuVetorDeInteiros = new int[5];
            var decimais = new decimal[/*pode ser omitido*/] { 0.5m, 0.9m, 1.59m };
            //var decimais = new decimal[3] { 0.5m, 0.9m, 1.59m };
            //decimal[] decimais = { 0.5m, 0.9m, 1.59m };

            //meuVetorDeStrings[-1] = "Teset";
            //meuVetorDeStrings[10] = "Teset9";

            foreach (var numeroDecimal in decimais)
            {
                Console.WriteLine(numeroDecimal);
            }

            Console.WriteLine("Tamanho do vetor: {0}", decimais.Length);            
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 0.9m, 1.59m };

            Array.Resize(ref decimais, 5);

            decimais[4] = 4.4m;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 1.5m, 0.9m, 1.59m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], 0.9m);
        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 1.5m, 0.9m, 1.59m };

            Console.WriteLine(CalcularMedia(decimais));
            //Console.WriteLine(CalcularMedia(1.5m, 0.9m, 1.59m)); // descomentar os params abaixo.
        }

        public decimal CalcularMedia(/*params*/ decimal[] valores)
        {
            return valores.Average();
        }

        [TestMethod]
        public void MatrizTeste()
        {
            var matriz = new int[3, 3];

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = linha * coluna;
                    Console.Write("| {0} ", matriz[linha, coluna]);
                }
                Console.WriteLine();
            }
        }
    }
}