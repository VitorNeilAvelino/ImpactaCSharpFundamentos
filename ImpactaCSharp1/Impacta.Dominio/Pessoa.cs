using System.Collections.Generic;
using System;

namespace Impacta.Dominio
{
    // abstract - classes abstratas representam um conceito (não são concretas) e não podem ser instanciadas (new)
    public abstract class Pessoa
    {
        public Pessoa()
        {
            Documentos = new List<Documento>();
        }

        // private - membros com este modificador só são acessados pela própria classe
        // protected - acesso permitido apenas para classes derivadas (que herdam desta)
        private string _nome;
        public string Nome
        {
            // acessador get - bloco que é executado toda vez que é preciso recuperar o valor da propriedade
            get { return _nome.ToUpper(); }
            // set - bloco executado ao se atribuir valores à propriedade
            set { _nome = value.ToUpper(); }
        }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Documento> Documentos { get; set; }
        public string Email { get; set; }        

        public abstract void Validar();
    }
}