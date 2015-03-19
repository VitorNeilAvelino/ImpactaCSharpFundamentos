using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        [TestMethod()]
        public void SelecionarTest()
        {
            var corRepositorio = new CorRepositorio();

            var cores = corRepositorio.Selecionar();

            foreach (var cor in cores)
            {
                Console.WriteLine(cor.Nome);
            }
        }
    }
}