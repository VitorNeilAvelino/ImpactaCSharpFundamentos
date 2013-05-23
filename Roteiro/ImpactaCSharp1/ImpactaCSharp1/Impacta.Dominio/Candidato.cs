using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impacta.Dominio
{
    public class Candidato : Pessoa
    {
        private ConheceuAtravesDe _conheceuAtravesDe;
        public ConheceuAtravesDe ConheceuAtravesDe
        {
            get { return _conheceuAtravesDe; }
            set { _conheceuAtravesDe = value; }
        }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}