using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface IVeiculoRepositorio
    {
        void Inserir(Veiculo veiculo);
        Veiculo Selecionar(int veiculoId);
        List<Veiculo> Selecionar();
        void Atualizar(Veiculo veiculo);
        void Excluir(int veiculoId);
    }
}