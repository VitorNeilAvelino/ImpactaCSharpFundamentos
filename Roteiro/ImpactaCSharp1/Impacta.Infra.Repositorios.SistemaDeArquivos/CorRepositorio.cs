using Impacta.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public class CorRepositorio
    {
        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(ConfigurationManager.AppSettings["caminhoArquivoCor"]))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Split('|')[0]);
                cor.Nome = linha.Split('|')[1];
                
                cores.Add(cor);
            }

            return cores;
        }
    }
}