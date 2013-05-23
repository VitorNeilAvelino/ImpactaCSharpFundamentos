using System;
using System.Diagnostics;
namespace Impacta.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a resposta para a vida, o universo e tudo mais?");

            if (Console.ReadLine() == "42")
            {
                Console.WriteLine("Resposta correta!");
            }
            else
            {
                Console.WriteLine("Resposta errada!");
            }

            //Console.Write("\n"); // = Console.WriteLine();
            //Console.WriteLine("\n"); // pula duas linhas
            //Console.Write("\r"); // retorna, sem pular de linha

            Console.WriteLine("Pressione qualquer caractere para sair.");
            Console.ReadKey();
            // answer to life the universe and everything
            Process.Start("http://www.google.com.br/#sclient=psy&hl=pt-BR&source=hp&q=answer+to+life+the+universe+and+everything&aq=0&aqi=g5&aql=&oq=&pbx=1&bav=on.2,or.r_gc.r_pw.&fp=ac979b4efde4458c&biw=1317&bih=686");
        }
    }
}