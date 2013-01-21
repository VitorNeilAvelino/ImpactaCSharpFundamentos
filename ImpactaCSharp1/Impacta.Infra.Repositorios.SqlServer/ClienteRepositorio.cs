using System.Collections.Generic;
using System.Linq;
using Impacta.Dominio;

namespace Impacta.Infra.Repositorios.SqlServer
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private ImpactaCSharp1Entities _impactaCSharp1Entities = new ImpactaCSharp1Entities();

        public List<Cliente> SelecionarTodos()
        {
            return _impactaCSharp1Entities.Clientes.ToList();
        }

        public void Salvar(Cliente cliente)
        {
            _impactaCSharp1Entities.Clientes.AddObject(cliente);
            _impactaCSharp1Entities.SaveChanges();
        }

        public void Gravar(Dominio.Cliente cliente)
        {
            throw new System.NotImplementedException();
        }


        public List<Dominio.Cliente> Selecionar()
        {
            throw new System.NotImplementedException();
        }
    }
}