using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impacta.Dominio
{
    public class Frete_
    {
        public Frete_(string uf, decimal valor)
        {
            Uf = uf;
            Valor = valor;

            Calcular();
        }

        private void Calcular()
        {
            if (Uf.ToUpper() == "SP")
            {
                Percentual = 0.2m;
            }
            else
            {
                Percentual = 0.3m;
            }
        }
        
        public string Uf { get; set; }
        public decimal Valor { get; set; }

        public decimal Percentual { get; set; }
        public decimal Total { get { return Valor * Percentual; } }
    }
}
