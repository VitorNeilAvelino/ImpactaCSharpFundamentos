using System.Collections.Generic;
namespace Impacta.Dominio
{
    public interface IClienteRepositorio
    {
        void Gravar(Cliente cliente);
        List<Cliente> Selecionar();
    }
}