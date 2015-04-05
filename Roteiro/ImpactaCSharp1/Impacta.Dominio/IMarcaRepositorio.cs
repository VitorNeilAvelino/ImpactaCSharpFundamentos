using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface IMarcaRepositorio
    {
        void Inserir(Marca marca);
        Marca Selecionar(int marcaId);
        List<Marca> Selecionar();
        void Atualizar(Marca marca);
        void Excluir(int marcaId);
    }
}