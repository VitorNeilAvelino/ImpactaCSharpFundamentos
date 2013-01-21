using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Impacta.Dominio;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos.Testes
{
    [TestClass()]
    public class ClienteRepositorioTest
    {
        [TestMethod()]
        public void GravarTest()
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            Cliente cliente = new Cliente();

            cliente.DataNascimento = Convert.ToDateTime("25/12/1970");
            cliente.Email = "avelino.vitor@gmail.com";
            cliente.Endereco = "R. Tal, 40";
            cliente.Nome = "Vítor";
            cliente.Renda = 123;
            
            var documento = new Documento();
            documento.Numero = "12845662858";
            documento.TipoDocumento = TipoDocumento.Cpf;

            cliente.Documentos.Add(documento);

            repositorio.Gravar(cliente);
        }
    }
}