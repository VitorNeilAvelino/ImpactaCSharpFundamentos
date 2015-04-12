namespace Impacta.Dominio
{
    public /*abstract*/ class Veiculo
    {
        //public Veiculo(string placa)
        //{
        //    Placa = placa;
        //}

        #region Propriedades

        private string _placa;
        public string Placa
        {
            get
            {
                return _placa.ToUpper();
            }
            set
            {
                _placa = value.ToUpper();
            }
        }

        //public string Placa { get; set; }
        public Modelo Modelo { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cor Cor { get; set; }
        public Cambio Cambio { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        #endregion

        #region Métodos
        //public abstract void Validar();

        // Quebra o polimorfismo.
        //public void Validar()
        //{

        //}
        #endregion
    }
}