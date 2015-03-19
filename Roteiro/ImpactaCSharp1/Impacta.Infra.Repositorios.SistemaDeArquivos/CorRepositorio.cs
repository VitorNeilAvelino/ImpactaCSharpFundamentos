using Impacta.Dominio;
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

            foreach (var cor in File.ReadAllLines(ConfigurationManager.AppSettings["caminhoArquivoCor"]))
            {
                cores.Add(new Cor { Nome = cor });
            }

            return cores;
        }
    }
}