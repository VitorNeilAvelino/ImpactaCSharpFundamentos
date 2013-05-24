using System;

namespace Impacta.Dominio
{
    public /*internal*/ class Frete
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Valor { get; set; }
        public string Uf { get; set; }
        public decimal Percentual { get; set; }
        public decimal Total { get; set; }

        /// <summary>
        /// Define o Percentual e o Total
        /// </summary>
        /// <param name="uf">UF de destino da carga</param>
        /// <param name="valor">Valor declarado da carga</param>
        public void Calcular(string uf, decimal valor)
        {
            switch (uf.ToUpper())
            {
                case "SP":
                    Percentual = 0.2M;
                    break;
                case "RJ": Percentual = 0.3M; break;
                case "BA":
                case "MG":
                    Percentual = 0.35M;
                    break;
                case "AM":
                    Percentual = 0.6m;
                    break;
                default:
                    Percentual = 0.75M;
                    break;
            }

            Total = Percentual * valor;

            //if (uf.ToUpper() == "SP")
            //{
            //    Percentual = 0.2M;
            //}
            //else if (uf.ToUpper() == "RJ")
            //{
            //    Percentual = 0.3m;
            //}
            //else if (uf.ToUpper() == "MG" || uf.ToUpper() == "BA")
            //{
            //    Percentual = 0.35m;
            //}
            //else
            //{
            //    Percentual = 0.75m;
            //}
        }
    }
}
