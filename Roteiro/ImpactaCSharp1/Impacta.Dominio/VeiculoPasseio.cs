using System;
using System.Collections.Generic;

namespace Impacta.Dominio
{
    public class VeiculoPasseio : Veiculo
    {
        public Carroceria Carroceria { get; set; }

        public override List<string> Validar()
        {
            List<string> erros = base.ValidarBase();

            if (!Enum.IsDefined(typeof(Carroceria), Carroceria))
            {
                erros.Add(string.Format("A carroceria informada ({0}) não é válida.", Carroceria));
            }

            return erros;
        }
    }
}