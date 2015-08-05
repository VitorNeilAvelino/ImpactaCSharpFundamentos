using System.Collections.Generic;
using Impacta.Infra.Repositorios.MsOffice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Apoio.Testes
{
    [TestClass]
    public class ExcelRepositorioTest
    {
        [TestMethod]
        public void InserirTest()
        {
            const string caminho = @"C:\CadastroDeClientes.xls";
            var registro = "VÍTOR;25/12/1970 00:00:00;R. Tal;12845662858;vitor@gmail.com;123;" + DateTime.Now.ToLongTimeString();
            ExcelRepositorio.Salvar(caminho, new List<string> { registro });
        }
    }
}