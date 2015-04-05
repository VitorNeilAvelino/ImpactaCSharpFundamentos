using Impacta.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public class MarcaRepositorio: IMarcaRepositorio
    {
        public List<Marca> Selecionar()
        {
            var marcas = new List<Marca>();

            foreach (var linha in File.ReadAllLines(ConfigurationManager.AppSettings["caminhoArquivoMarca"]))
            {
                var vetorPropriedades = linha.Split('|');
                
                var marca = new Marca();
                marca.Id = Convert.ToInt32(vetorPropriedades[0]);
                marca.Nome = vetorPropriedades[1];

                marcas.Add(marca);
            }

            return marcas;
        }

        public void Inserir(Marca marca)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Marca marca)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int marcaId)
        {
            throw new NotImplementedException();
        }
        
        public Marca Selecionar(int marcaId)
        {
            Marca marca = null;

            foreach (var linha in File.ReadAllLines(ConfigurationManager.AppSettings["caminhoArquivoMarca"]))
            {
                var vetorPropriedades = linha.Split('|');

                if (vetorPropriedades[0] == marcaId.ToString())
                {
                    marca = new Marca();
                    marca.Id = Convert.ToInt32(vetorPropriedades[0]);
                    marca.Nome = vetorPropriedades[1];                 
                }
            }

            return marca;
        }
    }
}