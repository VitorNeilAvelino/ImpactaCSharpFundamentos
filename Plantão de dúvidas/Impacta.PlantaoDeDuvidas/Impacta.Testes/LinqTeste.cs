using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Dominio.Teste
{
    [TestClass]
    public class LinqTeste
    {
        [TestMethod]
        public void RetornarUltimoArquivoDaPastaPorOrdemAlfabetica()
        {
            var ultimoArquivo = new DirectoryInfo(@"C:\Linq")
                .GetFiles("*.txt")
                .OrderBy(x => Convert.ToInt32(x.Name.Replace(x.Extension, "")))
                .LastOrDefault();

            var proximoNome = int.Parse(ultimoArquivo.Name.Replace(ultimoArquivo.Extension, "")) + 1;

            Assert.AreEqual(2, proximoNome);
        }
    }
}
