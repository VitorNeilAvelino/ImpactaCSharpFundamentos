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

        /// <summary>
        /// Tenta converter uma possível data do formato string para DateTime
        /// </summary>
        /// <param name="possivelData"></param>
        /// <returns>Se não for possível converter, retorna o valor mínimo do tipo DateTime</returns>
        public static DateTime ExtrairData(this string possivelData)
        {
            try
            {
                return Convert.ToDateTime(possivelData);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
    }
}