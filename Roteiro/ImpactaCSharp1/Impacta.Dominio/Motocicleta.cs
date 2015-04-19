using System.Collections.Generic;

namespace Impacta.Dominio
{
    public class Motocicleta : Veiculo
    {
        public TipoMotocicleta Tipo { get; set; }
        public override List<string> Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}