using Impacta.Dominio;
using System.Configuration;
using System;
using System.IO;
using System.Collections.Generic;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public void Gravar(Cliente cliente)
        {
            var registro = string.Format("{0};{1:d};{2};{3};{4};{5}",
                cliente.Nome, cliente.DataNascimento.ToShortDateString(), cliente.Endereco, cliente.Documentos[0].Numero, cliente.Email, cliente.Renda);

            var caminho = ConfigurationManager.AppSettings["caminhoArquivoClientes"];

            if (caminho == null)
            {
                throw new Exception("AppSetting caminhoArquivoClientes não encontrado. Verifique seu arquivo app ou web.config.");
            }

            //var repositorio = new TextoPuroRepositorio();
            //repositorio.Gravar(caminho, registro);
            //repositorio.Dispose();

            using (var repositorio = new TextoPuroRepositorio())
            {
                repositorio.Gravar(caminho, registro);
            }
        }

        //public static void Teste()
        //{

        //}


        public List<Cliente> Selecionar()
        {
            var retorno = new List<Cliente>();
            var propriedades = new String[5];
            var sr = new StreamReader(ConfigurationManager.AppSettings["caminhoArquivoClientes"]);

            while (!sr.EndOfStream)
            {
                propriedades = sr.ReadLine().Split(';');

                var cliente = new Cliente();
                cliente.Nome = propriedades[0];
                cliente.DataNascimento = Convert.ToDateTime(propriedades[1]);
                cliente.Endereco = propriedades[2];
                cliente.Cpf = propriedades[3];
                cliente.Email = propriedades[4];
                cliente.Renda = Convert.ToDecimal(propriedades[5]);

                retorno.Add(cliente);
            }

            return retorno;
        }
    }
}