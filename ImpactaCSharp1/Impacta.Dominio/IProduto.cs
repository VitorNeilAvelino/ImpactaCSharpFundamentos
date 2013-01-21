namespace Impacta.Dominio
{
    public interface IProduto
    {
        int? Codigo { get; set; }
        string Nome { get; set; }
        decimal Preco { get; set; }
        Familia Familia { get; set; }

        void Pesquisar(int codigo);
    }
}