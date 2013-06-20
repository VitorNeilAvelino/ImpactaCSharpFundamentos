using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Infra.Repositorios.MsOffice.Testes
{
    [TestClass]
    public class ExcelRepositorioTest
    {
        [TestMethod]
        public void SalvarTest()
        {
            const string caminho = @"C:\Users\vavelino\Documents\Excel.xls";
            const string registro = "Vítor;Avelino";
            ExcelRepositorio.Salvar(caminho, new List<string> { registro, registro, registro, registro, registro, registro, registro, registro, registro, 
                registro, registro }, 10);
        }
    }
}