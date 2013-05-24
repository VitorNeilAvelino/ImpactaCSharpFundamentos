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

        public List<Cliente> Selecionar()
        {
            var retorno = new List<Cliente>();
            var propriedades = new string[7];// 7 é o total de elementos (de 0 a 6).
            var arquivoTexto = new StreamReader(ConfigurationManager.AppSettings["caminhoArquivoClientes"]);

            while (!arquivoTexto.EndOfStream)
            {
                propriedades = arquivoTexto.ReadLine().Split(';');

                var cliente = new Cliente();
                cliente.Id = new Guid(propriedades[0]);
                cliente.Nome = propriedades[1];
                cliente.Endereco = propriedades[2];
                cliente.DataNascimento = Convert.ToDateTime(propriedades[3]);
                cliente.Cpf = propriedades[4];
                cliente.Email = propriedades[5];
                cliente.Renda = Convert.ToDecimal(propriedades[6]);

                retorno.Add(cliente);
            }

            return retorno;
        }
    }
}