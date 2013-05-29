using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControledeEstoquePIM
{
    class Usuario_MODEL
    {
        public int id_usuario;
        public string nome;
        public string usuario;
        public string senha;
        public string fone;
        public string rg;
        public string cpf;
        public string nasc;
        public string endereco;
        public string cidade;
        public string estado;

        public int id_Usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
       

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Fone
        {
            get { return fone; }
            set { fone = value;}
        }

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Nasc
        {
            get { return nasc; }
            set { nasc = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
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
    }
}
