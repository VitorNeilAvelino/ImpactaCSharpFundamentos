using System;
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

        public static DateTime DataPadrao(this string data)
        {
            try
            {
                return Convert.ToDateTime(data);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }
    }
}