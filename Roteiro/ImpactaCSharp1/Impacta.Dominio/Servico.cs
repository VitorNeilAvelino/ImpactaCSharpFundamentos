using System;

namespace Impacta.Dominio
{
    public class Servico : IProduto
    {
        #region IProduto Members

        public int? Codigo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Nome
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal Preco
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Familia Familia
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Pesquisar(int codigo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}