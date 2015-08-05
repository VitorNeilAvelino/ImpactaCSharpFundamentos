using System;
using System.Collections.Generic;

namespace Impacta.Dominio
{
    public abstract class Veiculo
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

        protected List<string> ValidarBase()
        {
            List<string> erros = new List<string>();

            if (Ano <= 1800 || (Ano - DateTime.Now.Year >= 2))
            {
                erros.Add(string.Format("O ano informado ({0}) não é válido.", Ano));
            }

            if (!Enum.IsDefined(typeof(Cambio), Cambio))
            {
                erros.Add(string.Format("O câmbio informado ({0}) não é válido.", Cambio));
            }

            return erros;
        }

        public abstract List<string> Validar();

        #endregion
    }
}