namespace Impacta.Dominio
{
    public class Veiculo
    {
        #region Propriedades
        public string Placa { get; set; }
        public Modelo Modelo { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cor Cor { get; set; }
        public Cambio Cambio { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        #endregion
    }
}