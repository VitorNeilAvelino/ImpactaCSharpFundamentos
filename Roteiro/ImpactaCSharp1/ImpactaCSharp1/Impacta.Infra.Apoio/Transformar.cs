namespace Impacta.Infra.Apoio
{
    public static class Transformar
    {
        public static string RemoverAcentuacao(string texto)
        {
            const string comAcento = "çÇáàâãäÁÀÂÃÄëéèêËÉÈÊiíïîìÍÏÌÎöóòôõÖÓÒÔÕüúùûÜÚÙÛ";
            const string semAcento = "cCaaaaaAAAAAeeeeEEEEiiiiiIIIIoooooOOOOOuuuuUUUU";

            for (var i = 0; i < comAcento.Length - 1; i++)
            {
                texto = texto.Replace(comAcento[i], semAcento[i]);
            }

            return texto;
        }
    }
}