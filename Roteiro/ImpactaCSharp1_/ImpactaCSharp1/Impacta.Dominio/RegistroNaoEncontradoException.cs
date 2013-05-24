using System;

namespace Impacta.Dominio
{
    public class RegistroNaoEncontradoException : Exception
    {
        // base - forma de acessar os elementos da classe pai (base)
        // Abaixo, toda vez que a exceção personalizada RegistroNaoEncontradoException for arremessada,
        // será retornada a mensagem "Registro não encontrado.".
        public RegistroNaoEncontradoException() : base("Registro não encontrado.")
        {
            
        }
    }
}