using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Impacta.Infra.Apoio
{
    public static class Extensoes
    {
        public static string ObterTextoSemMascara(this Control controle)
        {
            if (!(controle is MaskedTextBox))
                return controle.Text;

            var caixaDeTextoDeMascara = controle as MaskedTextBox;
            var retorno = string.Empty;
            var textMaskFormatOriginal = caixaDeTextoDeMascara.TextMaskFormat;

            caixaDeTextoDeMascara.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            retorno = caixaDeTextoDeMascara.Text;
            caixaDeTextoDeMascara.TextMaskFormat = textMaskFormatOriginal;

            return retorno;
        }

        /// <summary>
        /// Tenta converter uma possível data do formato string para DateTime
        /// </summary>
        /// <param name="possivelData"></param>
        /// <returns>Se não for possível converter, retorna uma data determinada.</returns>
        public static DateTime ConverterParaDateTime(this string possivelData)
        {
            try
            {
                return Convert.ToDateTime(possivelData);
            }
            catch
            {
                return new DateTime(1900, 1, 1);
            }
        }

        public static string ToString(this object objeto, string parametro)
        {
            var texto = objeto.ToString();

            if (parametro.ToUpper() == "CPF")
            {
                if (Regex.IsMatch(texto, @"[0-9]{11}"))
                {
                    return string.Format("{0}.{1}.{2}-{3}", texto.Substring(0, 3), texto.Substring(3, 3),
                                         texto.Substring(6, 3), texto.Substring(9, 2));
                }
            }

            return texto;
        }
    }
}