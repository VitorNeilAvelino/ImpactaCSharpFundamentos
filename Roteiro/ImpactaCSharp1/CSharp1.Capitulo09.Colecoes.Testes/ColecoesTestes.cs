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

            Console.WriteLine("Tamanho da lista de inteiros: {0}", inteiros.Count);

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine("{0}: {1}", inteiros.IndexOf(inteiro), inteiro);
            }
            Console.WriteLine(new string('-', 50));

            Assert.AreEqual(inteiros.IndexOf(1), 0);

            inteiros.Insert(0, 11);
            Assert.AreEqual(inteiros[0], 11);

            inteiros.Remove(2); // Primeiro "2" encontrado. Não causa erro se não encontrado.
            foreach (var inteiro in inteiros)
            {
                Console.WriteLine("{0}: {1}", inteiros.IndexOf(inteiro), inteiro);
            }
            Console.WriteLine(new string('-', 50));

            //inteiros.RemoveAt(10); ArgumentOutOfRangeException.
            inteiros.RemoveAt(3);

            inteiros.Sort();
            foreach (var inteiro in inteiros)
            {
                Console.WriteLine("{0}: {1}", inteiros.IndexOf(inteiro), inteiro);
            }
            Console.WriteLine(new string('-', 50));
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

            var dicionario = new Dictionary<int, string>() ;//{ { 1, "Teste" }, { 2, "Outro teste" } };
            dicionario.Add(1, "Um");
            dicionario.Add(2, "Registro com Id 2");
            //dicionario.Add(2, "Registro com Id 3");

            Assert.IsTrue(dicionario.ContainsKey(1));
            Assert.IsTrue(dicionario.ContainsValue("Um"));

            Console.WriteLine(dicionario[1]);

            foreach (var verbete in dicionario)
            {
                Console.WriteLine("{0}: {1}", verbete.Key, verbete.Value);
            }
        }

        [TestMethod]
        public void HashSetTeste()
        {
            var conjuntoDeDispersao = new HashSet<string>();
            conjuntoDeDispersao.Add("Um");
            conjuntoDeDispersao.Add("Cinquenta");
            conjuntoDeDispersao.Add("Quinze");
            conjuntoDeDispersao.Add("Quinze"); //Não quebra a execução.

            //Console.WriteLine(conjuntoDeDispersao[0]);
            Assert.IsTrue(conjuntoDeDispersao.Contains("Um"));
        }

        [TestMethod]
        public void StackTeste()
        {
            var pilha = new Stack/*<int>*/();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);

            Assert.AreEqual(pilha.Pop(), 3);
            Assert.AreEqual(pilha.Peek(), 2);
        }

        [TestMethod]
        public void QueueTeste()
        {
            var fila = new Queue/*<int>*/();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);

            Assert.AreEqual(fila.Dequeue(), 1);
            Assert.AreEqual(fila.Peek(), 2);
        }
    }
}