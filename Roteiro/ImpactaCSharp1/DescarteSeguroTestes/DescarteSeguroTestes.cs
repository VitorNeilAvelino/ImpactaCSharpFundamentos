using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Data.SqlClient;

namespace DescarteSeguro.Testes
{
    [TestClass]
    public class DescarteSeguroTestes
    {
        [TestMethod]
        public void ArquivosDeTextoTeste()
        {
            using (var descartavel = new Descartavel())
            {
                descartavel.ArquivoTexto = new StreamReader(@"c:\Fretes.txt");
                descartavel.Consulta = new SqlCommand();
            }
        }
    }

    public class Descartavel : IDisposable
    {
        public StreamReader ArquivoTexto { get; set; }
        public SqlCommand Consulta { get; set; }

        public void Dispose()
        {
            ArquivoTexto.Dispose();
            Consulta.Dispose();
        }
    }
}