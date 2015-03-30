using System.Collections.Generic;
using System.ComponentModel;

namespace Impacta.Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
         
        public List<Modelo> Modelos { get; set; }
    }
}