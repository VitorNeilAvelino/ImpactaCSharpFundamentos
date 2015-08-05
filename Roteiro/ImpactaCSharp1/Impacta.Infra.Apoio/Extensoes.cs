using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using System.ComponentModel;

namespace Impacta.Apoio
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

        public static string ParaString(this object objeto, string parametro)
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

        /// <summary>
        /// System.Web.HttpUtility
        /// 28597 - Grego
        /// http://msdn.microsoft.com/en-us/library/system.text.encoding.aspx<param 
        /// </summary>
        public static string SemAcento(this string texto)
        {
            return HttpUtility.UrlEncode(texto, Encoding.GetEncoding(28597)).Replace("+", " ");
        }

        public static string RemoverAcento(this string texto)
        {
            return Transformar.RemoverAcentuacao(texto);
        }

        public static int ParaInteiro(this object valor)
        {
            return Convert.ToInt32(valor);
        }

        public static DateTime ParaData(this object valor)
        {
            return Convert.ToDateTime(valor);
        }

        public static Decimal ParaDecimal(this string valor)
        {
            return Convert.ToDecimal(valor);
        }

        public static T ParaTipo<T>(this object valor)
        {
            return (T)Convert.ChangeType(valor, typeof(T));
        }

        public static string ObterDescricao(this Enum itemEnumerador)
        {
            var descricao = itemEnumerador.ToString();
            var informacoesCampo = itemEnumerador.GetType().GetField(descricao);

            if (informacoesCampo == null)
            {
                return descricao;
            }

            var atributos = informacoesCampo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (atributos != null && atributos.Length > 0)
            {
                descricao = atributos[0].Description;
            }

            return descricao;
        }

        public static IEnumerable<Enum> /*List<Enum>*/ ParaLista(this Enum enumerador)
        {
            return Enum.GetValues(enumerador.GetType()).Cast<Enum>();//.ToList(); 
        }

        public static List<KeyValuePair<Enum, string>> ParaListaComDescricao(this Enum enumerador)
        {
            return Enum.GetValues(enumerador.GetType()).Cast<Enum>()
                .Select(e => new KeyValuePair<Enum, string>(e, e.ObterDescricao()))
                .ToList();
        }

        public static Dictionary<Enum, string> ParaDicionarioComDescricao(this Enum enumerador)
        {
            return Enum.GetValues(enumerador.GetType()).Cast<Enum>()
                .ToDictionary(e => e, e => e.ObterDescricao());
        }
    }
}