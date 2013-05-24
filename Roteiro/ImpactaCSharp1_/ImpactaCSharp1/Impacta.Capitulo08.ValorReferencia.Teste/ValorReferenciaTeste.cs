using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Capitulo08.ValorReferencia.Teste
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ValorReferenciaTeste
    {
        /// <summary>
        /// Testa a passagem de variáveis (structs) como parâmetros de métodos - passagem por valor
        /// </summary>
        [TestMethod]
        public void TestarPassagemPorValor()
        {
            int x = 1;
            Transformar(x);

            // O valor original não foi transformado
            Assert.AreEqual(x, 1);

            int y = x;
            x = 2;
            Assert.AreEqual(y, 1);
        }

        /// <summary>
        /// Testa a passagem de classes como parâmetros de métodos - passagem por referência
        /// </summary>
        [TestMethod]
        public void TestarPassagemPorReferencia()
        {
            var cliente = new Cliente();
            cliente.Nome = "Anders";
            Transformar(cliente);

            // Quando uma classe é passada como parâmetro de um método, seu conteúdo é passado por referência, ou seja,
            // é passado o endereço da classe na memória e não seu conteúdo propriamente.
            // Assim, quando uma propriedade é modificada dentro do método (Transformar), o "objeto original" (trata-se do mesmo objeto)
            // também é modificado
            Assert.AreEqual(cliente.Nome, "HEJLSBERG");

            var cliente2 = cliente;
            cliente.Nome = "Outro Nome";
            Assert.AreEqual(cliente2.Nome, "OUTRO NOME");
        }

        [TestMethod]
        public void TestarPassagemPorValorUsandoRef()
        {
            int x = 1;
            Transformar(ref x);

            // O valor original muda, pois agora é passado por referência (palavra-chave ref).
            Assert.AreEqual(x, 2);
        }

        [TestMethod]
        public void TestarPassagemDeStructs()
        {
            //var aluno = new Aluno();
            //aluno.Documentos.Add(new Documento{TipoDocumento = TipoDocumento.CPF, Numero = "123.456.789-00"});
            //Transformar(aluno);

            //Assert.AreEqual(aluno.Documentos[0].Numero, "000.000.000-00");
            var documento = new Documento();
            documento.Numero = "123.456.789-00";
            Transformar(documento);
            Assert.AreEqual(documento.Numero, "123.456.789-00");
        }

        public void Transformar(int x)
        {
            x++;
        }

        public void Transformar(ref int x)
        {
            x++;
        }

        public void Transformar(Cliente candidato)
        {
            candidato.Nome = "Hejlsberg";
        }

        public void Transformar(Documento documento)
        {
            documento.Numero = "000.000.000-00";
        }
    }
}