using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface IModeloRepositorio
    {
        void Inserir(Modelo modelo);
        Modelo Selecionar(int modeloId);
        List<Modelo> SelecionarPorMarca(int marcaId);
        void Atualizar(Modelo modelo);
        void Excluir(int modeloId);
    }
}