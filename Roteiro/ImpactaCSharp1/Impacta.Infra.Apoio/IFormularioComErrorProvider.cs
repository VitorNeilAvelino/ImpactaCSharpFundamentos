using System.Windows.Forms;
namespace Impacta.Infra.Apoio
{
    public interface IFormularioComErrorProvider
    {
        ErrorProvider ProvedorDeErro { get; }
    }
}