using System;

namespace Impacta.Dominio
{
    public class RegraNegocioException : Exception
    {
        public RegraNegocioException(string mensagem) : base(mensagem)
        {
            //Message = mensagem;
        }
    }
}