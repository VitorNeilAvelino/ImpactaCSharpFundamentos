using Impacta.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        public void Inserir(Veiculo veiculo)
        {
            var caminhoArquivoVeiculo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["caminhoArquivoVeiculo"]);
            
            var veiculos = XDocument.Load(caminhoArquivoVeiculo);

            var registro = new StringWriter();
            new XmlSerializer(typeof(Veiculo)).Serialize(registro, veiculo);

            veiculos.Root.Add(XElement.Parse(registro.ToString()));

            veiculos.Save(caminhoArquivoVeiculo);            
        }

        public List<Veiculo> Selecionar()
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int veiculoId)
        {
            throw new NotImplementedException();
        }
        
        public Veiculo Selecionar(int veiculoId)
        {
            throw new NotImplementedException();
        }
    }
}