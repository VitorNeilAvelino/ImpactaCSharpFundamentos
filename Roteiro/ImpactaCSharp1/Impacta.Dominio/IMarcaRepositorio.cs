using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface IMarcaRepositorio
    {
        void Inserir(Marca marca);
        List<Marca> Selecionar(int? marcaId = null);
        void Atualizar(Marca marca);
        void Excluir(int marcaId);
    }
}