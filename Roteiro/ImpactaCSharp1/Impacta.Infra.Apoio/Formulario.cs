using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Impacta.Apoio
{
    public static class Formulario
    {
        public static bool Validar(Form formulario, ErrorProvider provedorDeErro)
        {
            var resultadoValidacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;
                }
                
                provedorDeErro.SetError(controle, string.Empty);

                if (controle.Tag.ToString().Contains("*") && controle.Text.Trim() == string.Empty /*|| controle.ObterTextoSemMascara() == string.Empty*/)
                {
                    DefinirErro(provedorDeErro, controle, "Campo obrigatório.");

                    //Começar assim e depois refatorar.
                    //resultadoValidacao = false;
                    //provedorDeErro.SetError(controle, "Campo obrigatório.");
                    //controle.Focus();
                }
                else
                {
                    ValidarTipoDado(controle, provedorDeErro);                    
                }                
            }

            //return FormularioEstaSemErros(formulario, provedorDeErro);

            return resultadoValidacao;
        }

        private static void ValidarTipoDado(Control controle, ErrorProvider provedorDeErro)
        {
            var controleTag = controle.Tag.ToString().ToUpper();

            if (controleTag.Contains("PLACA"))
            {
                if (!Regex.IsMatch(controle.Text, @"^[A-Z]{3}[0-9]{4}$"))
                {
                    DefinirErro(provedorDeErro, controle, "Digite a placa no formato AAA-0000.");
                }
            }
            else if (controleTag.Contains("ANO"))
            {
                if (!Regex.IsMatch(controle.Text, @"^[0-9]{4}$"))
                {                    
                    DefinirErro(provedorDeErro, controle, "Digite o ano no formato AAAA.");
                }
            }
        }

        public static bool ValidarCamposObrigatorios(Form formulario, ErrorProvider provedorDeErro)
        {
            bool validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag != null && controle.Tag.ToString().Contains("*"))
                {
                    provedorDeErro.SetError(controle, string.Empty);

                    if (controle.Text.Trim() == string.Empty /*|| controle.ObterTextoSemMascara() == string.Empty*/)
                    {
                        validacao = false;
                        provedorDeErro.SetError(controle, "Campo obrigatório.");
                        controle.Focus();
                    }
                    else
                    {

                    }
                }
            }

            return validacao;
        }

        public static bool ValidarTipoDados(Form formulario, ErrorProvider provedorDeErro)
        {
            bool validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                provedorDeErro.SetError(controle, "");

                if (controle.Tag == null)
                {
                    continue;
                }

                var controleTag = controle.Tag.ToString().ToUpper();

                if (controleTag.Contains("PLACA"))
                {
                    if (!Regex.IsMatch(controle.Text, @"^[A-Z]{3}[0-9]{4}$"))
                    {
                        DefinirErro(provedorDeErro, controle, "Digite o ano no formato AAAA.");
                    }
                }
                else if (controleTag.Contains("ANO"))
                {
                    if (!Regex.IsMatch(controle.Text, @"^[0-9]{4}$"))
                    {
                        DefinirErro(provedorDeErro, controle, "Digite o ano no formato AAAA.");
                    }
                }
            }

            return validacao;
        }

        private static void DefinirErro(ErrorProvider provedorDeErro, Control controle, string mensagem)
        {
            provedorDeErro.SetError(controle, mensagem);
            controle.Focus();
        }

        private static bool FormularioEstaSemErros(Form formulario, ErrorProvider provedorDeErro)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (provedorDeErro.GetError(controle) != string.Empty)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ValidarTipoDosDados(Form formulario, ErrorProvider provedorDeErro)
        {
            bool validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                provedorDeErro.SetError(controle, "");

                try
                {
                    if (controle.Tag == null) continue;

                    if (controle.Tag.ToString().ToUpper().Contains("DECIMAL"))
                    {
                        Convert.ToDecimal(controle.Text);
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("EMAIL"))
                    {
                        if (!Regex.IsMatch(controle.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$"))
                        //if (!Regex.IsMatch(controle.Text, @"^(.+)@(.+).(.+)$"))
                        {
                            throw new FormatException("EMAIL");
                        }
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("DATETIME"))
                    {
                        Convert.ToDateTime(controle.Text);
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("CPF"))
                    {
                        if (!Impacta.Apoio.Validar.Cpf(controle.Text))
                        {
                            throw new FormatException("CPF");
                        }
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("TEXTOSEMNUMEROS"))
                    {
                        if (Regex.IsMatch(controle.Text, @"[0-9]"))
                        {
                            throw new FormatException("TEXTOSEMNUMEROS");
                        }
                    }
                }
                catch
                {
                    validacao = false;
                    provedorDeErro.SetError(controle, "Valor inválido");
                    controle.Focus();
                }
            }

            return validacao;
        }

        public static bool ValidarTipoDosDados(IFormularioComErrorProvider formulario)
        {
            return ValidarTipoDosDados((Form)formulario, formulario.ProvedorDeErro);
        }

        public static void Limpar(this Form formulario)
        {
            Limpar((Control)formulario);

            //foreach (Control controle in formulario.Controls)
            //{
            //    if (controle is TextBox || controle is MaskedTextBox)
            //    {
            //        controle.Text = string.Empty;
            //    }
            //    else if (controle is ComboBox)
            //    {
            //        ((ComboBox)controle).SelectedIndex = -1;
            //    }
            //}
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