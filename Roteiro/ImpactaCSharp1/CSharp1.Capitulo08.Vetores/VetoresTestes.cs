using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Microsoft.VisualBasic.Devices;

namespace CSharp1.Capitulo08.Vetores
{
    [TestClass]
    public class VetoresTestes
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];
            var inteiros = new int[5];
            var decimais = new decimal[/*pode ser omitido - 2 e 4 quebram o build*/] { 0.5m, 0.9m, 1.59m };
            
            // Se informado, confere a quantidade informada
            //var decimais = new decimal[3] { 0.5m, 0.9m, 1.59m };
            
            // /*var não promove a inferência*/ decimal[] decimais = { 0.5m, 0.9m, 1.59m };

            // Erro de execução
            strings[-1] = "Teset";
            strings[10] = "Teset9";

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

            //ref: aula 12
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

        [TestMethod]
        public void TamanhoMaximoTeste()
        {
            // sizeof: tamanho em bytes. 
            // Console.WriteLine(sizeof(bool));           

            var vetorDeStrings = new string[0]; // bisonho, mas possível.
            //vetorDeStrings[0] = "teste"; // erro de execução.

            //var outroVetorDeStrings = new string[-1]; // build quebrado.

            var vetorDeBooleanos = new bool[int.MaxValue]; // OutOfMemoryException.

            var memoriaDisponivel = new ComputerInfo().AvailablePhysicalMemory * 0.65m;
            Console.WriteLine((memoriaDisponivel/1024m/1024m/1024m).ToString("n2"));

            var vetorDeBytes = new byte[Math.Min(int.MaxValue, Convert.ToInt32(memoriaDisponivel))]; // comentar o vetorDeBooleanos.
            var vetorDeInteiros = new int[Math.Min(int.MaxValue, Convert.ToInt32(memoriaDisponivel/4m))]; // comentar o vetorDeBytes.
        }
    }
}