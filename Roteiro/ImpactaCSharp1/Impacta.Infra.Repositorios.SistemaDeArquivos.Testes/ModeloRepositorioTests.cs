using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        [TestMethod()]
        public void SelecionarTest()
        {
            var modeloRepositorio = new ModeloRepositorio();

            var modelos = modeloRepositorio.Selecionar(1);

            foreach (var modelo in modelos)
            {
                Console.WriteLine("{0}-{1}-{2}", modelo.Id, modelo.Descricao, modelo.Marca.Nome);
            }
        }
    }
}