using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface IModeloRepositorio
    {
        void Inserir(Modelo modelo);
        List<Modelo> Selecionar(int marcaId);
        void Atualizar(Modelo modelo);
        void Excluir(int modeloId);
    }
}