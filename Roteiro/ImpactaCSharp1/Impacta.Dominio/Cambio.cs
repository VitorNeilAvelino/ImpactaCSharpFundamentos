using System.ComponentModel;

namespace Impacta.Dominio
{
    public enum Cambio
    {
        Manual = 1,

        [Description("Automático")]
        Automatico = 2
    }
}