using System.Collections.Generic;
using System.ComponentModel;
namespace Impacta.Dominio
{
    public class Marca
    {
        public string Nome { get; set; }
         
        public List<Modelo> Modelos { get; set; }
    }
}