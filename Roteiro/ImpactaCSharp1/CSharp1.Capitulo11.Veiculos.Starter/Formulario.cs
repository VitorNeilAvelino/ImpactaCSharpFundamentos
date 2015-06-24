using System.Windows.Forms;

namespace Impacta.Apoio
{
    public static class Formulario
    {
        public static bool ValidarCamposObrigatorios(Form formulario, ErrorProvider provedorDeErro)
        {
            bool validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag != null && controle.Tag.ToString().Contains("*"))
                {
                    provedorDeErro.SetError(controle, string.Empty);

                    if (controle.Text.Trim() == string.Empty)
                    {
                        validacao = false;
                        provedorDeErro.SetError(controle, "Campo obrigatório.");
                        controle.Focus();
                    }
                }
            }

            return validacao;
        }

        public static void Limpar(Control controle)
        {
            foreach (Control controleFor in controle.Controls)
            {
                if (controleFor is TextBox || controleFor is MaskedTextBox)
                {
                    controleFor.Text = string.Empty;
                }
                else if (controleFor is ComboBox)
                {
                    ((ComboBox)controleFor).SelectedIndex = -1;
                }
                Limpar(controleFor);
            }
        }
    }
}