using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Impacta.Capitulo04.Repeticao.Teste
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void TestarForAninhado()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }
        }

        [TestMethod]
        public void TestarEstruturaFor()
        {
            int i = 1;
            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }

            /*
            for(inicializacao; condição para a execução; pós-execução)
            {
                  execucao;
            }
             */
        }

        [TestMethod]
        public void TestarContinue()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i <= 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void TestarBreak()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ExcluirDiretoriosVaziosTeste()
        {
            ExcluirDiretoriosVazios(@"C:\Temp");
        }

        private void ExcluirDiretoriosVazios(string caminhoDiretorio)
        {
            foreach (var diretorio in Directory.GetDirectories(caminhoDiretorio))
            {
                ExcluirDiretoriosVazios(diretorio);
                
                //Console.WriteLine(new DirectoryInfo(diretorio).FullName);

                if (Directory.GetFiles(diretorio).Length == 0 && Directory.GetDirectories(diretorio).Length == 0)
                {
                    Console.WriteLine(new DirectoryInfo(diretorio).FullName);
                    //Directory.Delete(directory, false);
                    Directory.Delete(diretorio);
                }
            }
        }

        [TestMethod]
        public void LerTodasLinhas()
        {
            var linhas = Properties.Resources.testetxt
                .Split(new[] {Environment.NewLine}, StringSplitOptions.None).ToList();

            const string separador = "============================== Pedido ==============================";

            var pilha = new Stack<string>();
            var dicionario = new Dictionary<string, StringBuilder>();
            var linhaEmails = string.Empty;
            var corpoPedido = new StringBuilder();

            foreach (var linha in linhas)
            {
                pilha.Push(linha);

                if (linha == separador)
                {
                    if (corpoPedido.Length != 0)
                    {
                        pilha.Pop();
                        corpoPedido.Replace(pilha.Peek(), string.Empty);
                        
                        dicionario.Add(linhaEmails, corpoPedido);

                        linhaEmails = pilha.Pop();
                        corpoPedido = new StringBuilder();
                    }
                }
                else
                {
                    if (linhaEmails == string.Empty)
                    {
                        linhaEmails = pilha.Pop();
                    }
                    else
                    {
                        corpoPedido.AppendLine(linha); 
                    }
                }
            }

            dicionario.Add(linhaEmails, corpoPedido);
            
            foreach (var item in dicionario)
            {
                Console.WriteLine(new string('-', 200));
                Console.WriteLine("Email {0}", item.Key);
                Console.WriteLine(new string('-', 200));
                Console.WriteLine();
                Console.WriteLine("Pedido".PadRight(200, '-'));

                Console.WriteLine(item.Value.ToString());
                Console.WriteLine("Fim pedido".PadRight(300, '|'));
            }
        }
    }
}