using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Impacta.Capitulo08.ValorReferencia.Teste
{
    [TestClass]
    public class ValorReferenciaTeste
    {
        [TestMethod]
        public void TestarPassagemPorValor()
        {
            int x = 1;
            Transformar(x);

            // O valor original não foi transformado.
            Assert.AreEqual(x, 1);

            int y = x;
            x = 2;
            Assert.AreEqual(y, 1);
        }

        [TestMethod]
        public void TestarPassagemPorReferencia()
        {
            var cliente = new Cliente();
            cliente.Nome = "Anders";
            Transformar(cliente);

            // Quando uma classe é passada como parâmetro de um método, seu conteúdo é passado por referência, ou seja,
            // é passado o endereço da classe na memória e não seu conteúdo propriamente.
            // Assim, quando uma propriedade é modificada dentro do método (Transformar), o "objeto original" 
            // (trata-se do mesmo objeto) também é modificado.
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
        public void TestarStructsVsClasses()
        {
            int x = 42;
            Assert.IsTrue(x.GetType().IsValueType);

            var y = new Int32();
            y = 5;
            Assert.IsTrue(y.GetType().IsValueType);

            var meuObjeto = new object();
            Assert.IsTrue(meuObjeto.GetType().IsClass);

            var minhaString = new string('a', 1);
            Assert.IsTrue(minhaString.GetType().IsClass);

            var estrutura = new Estrutura();
            estrutura.Id = 1;

            Transformar(estrutura);

            Assert.IsTrue(estrutura.GetType().IsValueType);
            Assert.AreEqual(1, estrutura.Id);
        }

        private void Transformar(Estrutura estrutura)
        {
            estrutura.Id = 2;
        }

        private struct Estrutura /* : estruturas não admitem herança*/ 
        {
            // Estruturas não permitem construtores explícitos sem parâmetros.
            //public Estrutura()
            //{
                    
            //}

            // É preciso chamar o construtor padrão antes do construtor parametrizado.
            //public Estrutura(Veiculo veiculo, int id) : this()
            //{
            //    Veiculo = veiculo;
            //    Id = id;
            //}
            public int Id { get; set; }

            public void Fazer()
            {

            }
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