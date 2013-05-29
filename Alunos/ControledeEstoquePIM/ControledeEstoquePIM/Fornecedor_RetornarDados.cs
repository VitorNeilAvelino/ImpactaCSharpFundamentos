using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoquePIM
{
    class Fornecedor_RetornarDados
    {
        public int codigo;
        public string nome;
        public string endereco;
        public string cep;
        public string cnpj;
        public string cidade;
        public string estado;
        public string telefone;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        
    }
}
