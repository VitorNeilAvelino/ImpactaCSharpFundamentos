using System.Collections.Generic;
using System.Linq;

namespace Impacta.Infra.Repositorios.SqlServer
{
    public class CidadeRepositorio
    {
        public List<Cidade> SelecionarPorEstado(string siglaEstado)
        {
            return new ImpactaCSharp1Entities().Cidades.Where(x => x.SiglaEstado == siglaEstado).ToList();
        }
    }
}