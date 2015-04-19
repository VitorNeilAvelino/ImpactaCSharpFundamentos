using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Dominio;
using System.Linq;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculoRepositorio = new VeiculoRepositorio();

            var veiculo = new VeiculoPasseio();
            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Automatico;
            veiculo.Combustivel = Combustivel.Alcool;
            veiculo.Cor = new Cor(); //{ Id = 1, Nome = "Azul" };
            veiculo.Cor.Id = 1;
            veiculo.Cor.Nome = "Azul";
            veiculo.Modelo = new ModeloRepositorio().SelecionarPorMarca(1).First()/*[0]*/;
            veiculo.Observacao = "Observação";
            veiculo.Placa = "abc1234";

            veiculoRepositorio.Inserir(veiculo);
        }
    }
}