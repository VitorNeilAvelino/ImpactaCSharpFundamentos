using Impacta.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public class CorRepositorio
    {
        string _caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["caminhoArquivoCor"]);

        public List<Cor> Selecionar(string nome = null)
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(_caminho))
            {
                if (nome != null && nome.ToUpper() != linha.Substring(5).ToUpper())
                {
                    continue;
                }

                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);
                
                cores.Add(cor);                
            }
            return cores;
        }
    }
}