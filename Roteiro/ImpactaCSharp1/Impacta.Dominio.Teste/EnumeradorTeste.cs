using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Infra.Apoio;

namespace Impacta.Dominio.Teste
{
    [TestClass]
    public class EnumeradorTeste
    {
        [TestMethod]
        public void ConverterEnumeradorParaLista()
        {
            var veiculo = new VeiculoPasseio();

            Console.WriteLine(Cambio.Automatico.ObterDescricao());
            //Console.WriteLine(new Cambio().ObterDescricao()); // É preciso um elemento para obter sua descrição.

            foreach (var item in new Cambio().ParaListaComDescricao())
            {
                Console.WriteLine(item.Key);
            }

            foreach (var item in veiculo.Cambio.ParaListaComDescricao())
            {
                Console.WriteLine(item.Value);
            }

            foreach (var item in veiculo.Cambio.ParaLista())
            {
                Console.WriteLine(item);
            }
        }
    }
}