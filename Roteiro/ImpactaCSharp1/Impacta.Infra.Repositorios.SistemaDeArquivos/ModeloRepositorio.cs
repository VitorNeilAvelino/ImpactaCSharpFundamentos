using Impacta.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Xml.Linq;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public class ModeloRepositorio : IModeloRepositorio
    {
        public List<Modelo> SelecionarPorMarca(int marcaId)
        {
            var modelos = new List<Modelo>();
            var arquivoXml = XDocument.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["caminhoArquivoModelo"]));

            foreach (var noh in arquivoXml.Descendants("modelo"))
            {
                if (noh.Element("marcaId").Value != marcaId.ToString())
                {
                    continue;
                }

                var modelo = new Modelo();
                modelo.Id = Convert.ToInt32(noh.Element("id").Value);
                modelo.Descricao = noh.Element("descricao").Value;
                modelo.Marca = new MarcaRepositorio().Selecionar(marcaId);

                modelos.Add(modelo);
            }
            
            return modelos;
        }

        public void Inserir(Modelo modelo)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Modelo modelo)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int modeloId)
        {
            throw new NotImplementedException();
        }
        
        public Modelo Selecionar(int modeloId)
        {
            throw new NotImplementedException();
        }
    }
}