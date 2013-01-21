using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CSharp1.Capitulo04.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a resposta para a vida, o universo e tudo mais?");

            string resposta = Console.ReadLine();
            int contador = 2;

            while (resposta != "42" && contador > 0)
            {
                Console.WriteLine("Resposta incorreta!");
                Console.WriteLine("Você tem mais {0} tentativa(s).", contador);
                resposta = Console.ReadLine();
                contador--;
            }

            if (resposta == "42")
            {
                Console.WriteLine("Resposta correta!");
            }
            else
            {
                Console.WriteLine("Suas chances esgotaram-se!");
                Process.Start("http://www.google.com.br/#sclient=psy&hl=pt-BR&source=hp&q=answer+to+life+the+universe+and+everything&aq=0&aqi=g5&aql=&oq=&pbx=1&bav=on.2,or.r_gc.r_pw.&fp=ac979b4efde4458c&biw=1317&bih=686");
            }

            //Console.Write("\n"); // = Console.WriteLine();
            //Console.WriteLine("\n"); // pula duas linhas
            //Console.Write("\r"); // retorna, sem pular de linha

            //Console.WriteLine("Pressione Enter para sair.");
            //var teclaPressionada = Console.ReadKey();

            //while (teclaPressionada.Key != ConsoleKey.Enter)
            //{
            //    Console.WriteLine("Pressione Enter para sair.");
            //    teclaPressionada = Console.ReadKey();
            //}

            do
            {
                Console.WriteLine("Pressione Enter para sair.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
