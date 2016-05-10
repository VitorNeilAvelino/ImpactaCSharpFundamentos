using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;

namespace CSharp1.Capitulo09.Colecoes.Testes
{
    [TestClass]
    public class ColecoesTestes
    {
        [TestMethod]
        public void ListTeste()
        {
            var objetos = new ArrayList() /*{1, true, 0.4m }*/;
            objetos.Add("teste");
            objetos.Add(5);
            objetos.Add(DateTime.Now);

            var inteiros = new List<int>() { 1, 4, 0, 2, 2 }; // Começar comentado.
            inteiros.Add(9);
            inteiros.Add(8);
            inteiros.Add(4);
            inteiros[6] = 15; // nesse caso, o índice 6 tem que existir.

            var maisInteiros = new List<int> { 1, 8, 3, 0 };
            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, 11); // Não substitui, empurra. ArgumentOutOfRangeException se o índice não for encontrado.
            inteiros.Remove(2); // Primeiro "2" encontrado. Não causa erro se não encontrado.
            inteiros.RemoveAt(3); // ArgumentOutOfRangeException se o índice não for encontrado.
            inteiros.Sort();

            var primeiro = inteiros[0];
            var ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine("{0}: {1}", inteiros.IndexOf(inteiro), inteiro);
            }

            Console.WriteLine("Tamanho da lista de inteiros: {0}", inteiros.Count);
        }

        [TestMethod]
        public void ListUsaUmArrayInternamenteTeste()
        {
            var lista = new List<int>(/*10 - para testar capacidade*/);

            // Depurar para enxergar o vetor _items.
            var vetorInterno = typeof(List<int>).GetField("_items", BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine((vetorInterno.GetValue(lista) as int[]).Length);

            lista.Add(1);
            Console.WriteLine((vetorInterno.GetValue(lista) as int[]).Length);

            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            Console.WriteLine((vetorInterno.GetValue(lista) as int[]).Length);

            lista.Add(5);
            Console.WriteLine((vetorInterno.GetValue(lista) as int[]).Length);
        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var tabelaDeDispersao = new Hashtable();
            tabelaDeDispersao.Add(1, "Primeiro elemento");
            tabelaDeDispersao.Add("C#", "Anders Hejlsberg");
            tabelaDeDispersao.Add(true, 1);
            //tabelaDeDispersao.Add(1, "Outro elemento"); //ArgumentException.

            var feriados = new Dictionary<DateTime, string>();//{ { 1, "Teste" }, { 2, "Outro teste" } };

            feriados.Add(new DateTime(2015, 12, 25), "Natal");
            //dicionario.Add(Convert.ToDateTime("01/01/2016", new CultureInfo("pt-br")), "Ano novo");
            feriados.Add(Convert.ToDateTime("01/01/2016"), "Ano novo");
            feriados.Add(Convert.ToDateTime("25/01/2016"), "Aniversário de São Paulo");

            var nomeFeriado = feriados[new DateTime(2015, 12, 25)];

            feriados.Add(new DateTime(2015, 12, 25), "Natal"); // quebra a execução - a chave deve ser única.

            foreach (var feriado in feriados)
            {
                Console.WriteLine("{0}: {1}", feriado.Key.ToString("dd/MM/yyyy"), feriado.Value);
            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("25/12/2015")));
            Console.WriteLine(feriados.ContainsValue("Ano Novo"));
        }

        [TestMethod]
        public void HashSetTeste()
        {
            var conjuntoDeDispersao = new HashSet<string>();
            conjuntoDeDispersao.Add("Um");
            conjuntoDeDispersao.Add("Cinquenta");
            conjuntoDeDispersao.Add("Quinze");
            conjuntoDeDispersao.Add("Quinze"); //Não quebra a execução.

            //Console.WriteLine(conjuntoDeDispersao[0]); // Não é indexado, quebra o build.
            Assert.IsTrue(conjuntoDeDispersao.Contains("Um"));
        }

        [TestMethod]
        public void StackTeste()
        {
            var pilha = new Stack<int>(); // Não obrigatoriamente genérica.
            pilha.Push(3);
            pilha.Push(8);
            pilha.Push(56);

            Assert.AreEqual(pilha.Pop(), 56);
            Assert.AreEqual(pilha.Peek(), 8); // Peek: espiar.

            Console.WriteLine("A pilha está vazia? {0}.", pilha.Count == 0);
        }

        [TestMethod]
        public void QueueTeste()
        {
            var fila = new Queue<int>(); // Não obrigatoriamente genérica.
            fila.Enqueue(3);
            fila.Enqueue(8);
            fila.Enqueue(56);

            Assert.AreEqual(fila.Dequeue(), 3);
            Assert.AreEqual(fila.Peek(), 8);
        }
    }
}