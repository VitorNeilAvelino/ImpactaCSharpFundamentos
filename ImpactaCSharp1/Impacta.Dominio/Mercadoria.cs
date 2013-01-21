using System;
using System.IO;
using System.Windows.Forms;

namespace Impacta.Dominio
{
    public class Mercadoria : IProduto, IDisposable
    {
        #region Propriedades

        // ? - tipo anulável, a propriedade Código pode ser nula (null).
        public int? Codigo
        {
            get;
            set;
        }
        public string Nome
        {
            get;
            set;
        }
        public decimal Preco
        {
            get;
            set;
        }
        private Familia _familia = new Familia();
        public Familia Familia
        {
            get { return _familia; }
            set { _familia = value; }
        }
        public int QtdEstoque
        {
            get;
            set;
        }

        #endregion

        # region Campos

        private StreamReader sr;

        # endregion

        #region Métodos

        public void Pesquisar(int codigo)
        {
            string[] propriedades = new string[5];
            string registro = "";

            try
            {
                sr = new StreamReader("C:\\Produtos.txt", new System.Text.UTF7Encoding());

                while (!sr.EndOfStream)
                {
                    registro = sr.ReadLine();
                    // Split - retorna um vetor de strings; no caso, contendo cada uma das
                    // propriedades dentro do arquivo Produtos.txt. O parâmetro de entrada
                    // do método é o caractere separador da string.
                    propriedades = registro.Split(';');

                    if (propriedades[0] == codigo.ToString())
                    {
                        Codigo = Convert.ToInt32(propriedades[0]);
                        Nome = propriedades[1];
                        Preco = Convert.ToDecimal(propriedades[2]);
                        QtdEstoque = Convert.ToInt32(propriedades[3]);
                        Familia.Nome = propriedades[4];

                        return;
                    }
                }
            }
            // finally - sempre é executado, não importa se houve exceção ou não.
            finally
            {
                if (sr != null) sr.Close();
            }

            throw new RegistroNaoEncontradoException();
        }

        public void Dispose()
        {
            if (sr != null)
                sr.Dispose();

            MessageBox.Show("Dispose chamado.");
        }

        #endregion
    }
}