using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Impacta.Infra.Repositorios.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        [TestMethod()]
        public void SelecionarTest()
        {
            var marcaRepositorio = new MarcaRepositorio();
            var marcas = marcaRepositorio.Selecionar();

            foreach (var marca in marcas)
            {
                Console.WriteLine("{0}-{1}", marca.Id, marca.Nome);    
            }
        }
    }
}