using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoquePIM
{
    class ControleProduto_MODEL
    {
        public int codigo;
        public string descricao;
        public string fornecedor;
        public int quantidade;
        public string entrada;
        public decimal preco;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }            
            
        }
       
        public string Entrada
        {
            get { return entrada; }
            set { entrada = value; }

        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
    }
}
