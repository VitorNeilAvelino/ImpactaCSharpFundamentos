using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Impacta.Capitulo04.Repeticao.Teste
{
    /// <summary>
    /// Classe de testes para estrutura de repetição
    /// </summary>
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
    }
}