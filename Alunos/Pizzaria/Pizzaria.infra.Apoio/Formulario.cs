using System;
using System.Windows.Forms;

namespace Pizzaria.infra.Apoio
{
    #region classformulariopizza
    public class Formulariopizza
    {
        /// <summary>
        /// Método que avalia se os campos obrigatórios estão preenchidos.
        /// </summary>
        /// <param name="formulario">Formulário a ser validado</param>
        /// <param name="provedorDeErros">ErrorProvider do formulário</param>
        /// <returns>True se todos os campos estiverem preenchidos</returns>
        public static bool ValidarCamposObrigatorios(Form formulario, ErrorProvider provedorDeErros)
        {
            //bool validacao = true;
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag != null &&
                    controle.Tag.ToString().Contains("*"))
                {
                    if (controle.Text == string.Empty)
                    {
                        provedorDeErros.SetError(controle, "Campo obrigatório.");
                        controle.Focus();
                        validacao = false;
                    }
                    else
                    {
                        provedorDeErros.SetError(controle, string.Empty);
                    }
                }
            }

            return validacao;
        }

        public static bool ValidarTipoDados(Form formulario, ErrorProvider provedorDeErros)
        {
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                try
                {
                    if (controle.Tag != null &&
                controle.Tag.ToString().ToUpper().Contains("*DECIMAL"))
                    {
                        Convert.ToDecimal(controle.Text);
                    }
                    else if (controle.Tag != null &&
                        controle.Tag.ToString().ToUpper().Contains("APENASTEXTO"))
                    {
                        foreach (char caractere in controle.Text)
                        {
                            if ((int)caractere >= 48 && (int)caractere <= 57)
                            {
                                throw new Exception();
                            }
                        }
                    }

                }
                catch
                {
                    provedorDeErros.SetError(controle, "Valor inválido.");
                    controle.Focus();
                    validacao = false;
                }
            }

            return validacao;
        }

        public static void Limpar(Form formulario)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle is TextBox || controle is MaskedTextBox)
                {
                    controle.Text = string.Empty;
                }
                else if (controle is ComboBox)
                {
                    //((ComboBox)controle).SelectedIndex = -1;
                    (controle as ComboBox).SelectedIndex = -1;
                }
            }
        }
    }
    #endregion

    #region calssformulariorefri
    public class Formulariorefri
    {
        /// <summary>
        /// Método que avalia se os campos obrigatórios estão preenchidos.
        /// </summary>
        /// <param name="formulario">Formulário a ser validado</param>
        /// <param name="provedorDeErros">ErrorProvider do formulário</param>
        /// <returns>True se todos os campos estiverem preenchidos</returns>
        public static bool ValidarCamposObrigatorios(Form formulario, ErrorProvider provedorDeErros)
        {
            //bool validacao = true;
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag != null &&
                    controle.Tag.ToString().Contains("¨"))
                {
                    if (controle.Text == string.Empty)
                    {
                        provedorDeErros.SetError(controle, "Campo obrigatório.");
                        controle.Focus();
                        validacao = false;
                    }
                    else
                    {
                        provedorDeErros.SetError(controle, string.Empty);
                    }
                }
            }

            return validacao;
        }

        public static bool ValidarTipoDados(Form formulario, ErrorProvider provedorDeErros)
        {
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                try
                {
                    if (controle.Tag != null &&
                controle.Tag.ToString().ToUpper().Contains("¨DECIMAL"))
                    {
                        Convert.ToDecimal(controle.Text);
                    }
                    else if (controle.Tag != null &&
                        controle.Tag.ToString().ToUpper().Contains("APENASTEXTO"))
                    {
                        foreach (char caractere in controle.Text)
                        {
                            if ((int)caractere >= 48 && (int)caractere <= 57)
                            {
                                throw new Exception();
                            }
                        }
                    }

                }
                catch
                {
                    provedorDeErros.SetError(controle, "Valor inválido.");
                    controle.Focus();
                    validacao = false;
                }
            }

            return validacao;
        }

        public static void Limpar(Form formulario)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle is TextBox)
                {
                    controle.Text = string.Empty;
                }
                else if (controle is ComboBox)
                {
                    //((ComboBox)controle).SelectedIndex = -1;
                    (controle as ComboBox).SelectedIndex = -1;
                }
            }
        }
    }
    #endregion

    #region calssformularioesfiha
    public class Formularioesfiha
    {
        /// <summary>
        /// Método que avalia se os campos obrigatórios estão preenchidos.
        /// </summary>
        /// <param name="formulario">Formulário a ser validado</param>
        /// <param name="provedorDeErros">ErrorProvider do formulário</param>
        /// <returns>True se todos os campos estiverem preenchidos</returns>
        public static bool ValidarCamposObrigatorios(Form formulario, ErrorProvider provedorDeErros)
        {
            //bool validacao = true;
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag != null &&
                    controle.Tag.ToString().Contains("°"))
                {
                    if (controle.Text == string.Empty)
                    {
                        provedorDeErros.SetError(controle, "Campo obrigatório.");
                        controle.Focus();
                        validacao = false;
                    }
                    else
                    {
                        provedorDeErros.SetError(controle, string.Empty);
                    }
                }
            }

            return validacao;
        }

        public static bool ValidarTipoDados(Form formulario, ErrorProvider provedorDeErros)
        {
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                try
                {
                    if (controle.Tag != null &&
                controle.Tag.ToString().ToUpper().Contains("°DECIMAL"))
                    {
                        Convert.ToDecimal(controle.Text);
                    }
                    else if (controle.Tag != null &&
                        controle.Tag.ToString().ToUpper().Contains("APENASTEXTO"))
                    {
                        foreach (char caractere in controle.Text)
                        {
                            if ((int)caractere >= 48 && (int)caractere <= 57)
                            {
                                throw new Exception();
                            }
                        }
                    }

                }
                catch
                {
                    provedorDeErros.SetError(controle, "Valor inválido.");
                    controle.Focus();
                    validacao = false;
                }
            }

            return validacao;
        }

        public static void Limpar(Form formulario)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle is TextBox)
                {
                    controle.Text = string.Empty;
                }
                else if (controle is ComboBox)
                {
                    //((ComboBox)controle).SelectedIndex = -1;
                    (controle as ComboBox).SelectedIndex = -1;
                }
            }
        }
    }
    #endregion

}
