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
            var veiculo = new Veiculo();

            Console.WriteLine(Cambio.Automatico.ObterDescricao());
            Console.WriteLine(new Cambio().ObterDescricao());

            foreach (var item in new Cambio().ParaListaComDescricao())
            {
                Console.WriteLine(item.Key);
            }

            foreach (var item in veiculo.Cambio.ParaListaComDescricao())
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}