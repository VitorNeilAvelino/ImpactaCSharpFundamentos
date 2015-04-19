using System;
using System.Collections.Generic;

namespace Impacta.Dominio
{
    public class Caminhao : Veiculo
    {
        public QuantidadeEixos QuantidadeEixos { get; set; }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}