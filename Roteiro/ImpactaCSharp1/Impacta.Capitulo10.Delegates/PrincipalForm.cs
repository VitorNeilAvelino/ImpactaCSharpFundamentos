using System;
using System.Windows.Forms;

namespace Impacta.Capitulo10.Delegates
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        #region Delegates

        // Definição do delegate DelegaSomar
        delegate decimal DelegaSomar(decimal valor1, decimal valor2);

        static private decimal Somar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }
        // Instanciação do objeto delegaSomar a atribuição do mesmo ao resultado do método Somar
        DelegaSomar delegaSomar = new DelegaSomar(Somar);

        private void delegateButton_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Add(delegaSomar(10, 15));
        }

        #endregion

        #region Métodos Anônimos

        delegate decimal DelegaSubtrair(decimal valor1, decimal valor2);
        DelegaSubtrair delegaSubtrair = delegate(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        };

        private void anonimosButton_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Add(delegaSubtrair(10, 15));
        }

        #endregion

        #region Expressões Lâmbda

        delegate decimal DelegaMultiplicar(decimal valor1, decimal valor2);
        // => - o objeto delegaMultiplicar aponta para a execução x1 * x2.
        DelegaMultiplicar delegaMultiplicar = (x1, x2) => x1 * x2;

        private void lambdaButton_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Add(delegaMultiplicar(10, 15));
        }

        #endregion
    }
}