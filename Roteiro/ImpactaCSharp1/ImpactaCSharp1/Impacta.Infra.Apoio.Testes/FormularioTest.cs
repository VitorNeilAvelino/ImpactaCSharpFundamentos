using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Impacta.Infra.Apoio.Testes
{
    [TestClass]
    public class FormularioTest
    {
        [TestMethod]
        public void ValidarTipoDosDadosTest()
        {
            var formulario = new Form();
            var provedorDeErro = new ErrorProvider();

            formulario.Controls.Add(new TextBox { Text = "Vítor", Tag = "TEXTOSEMNUMEROS" });
            var retorno = Formulario.ValidarTipoDosDados(formulario, provedorDeErro);
            Assert.IsTrue(retorno);

            formulario.Controls.Clear();
            formulario.Controls.Add(new TextBox { Text = "V2ítor", Tag = "TEXTOSEMNUMEROS" });
            retorno = Formulario.ValidarTipoDosDados(formulario, provedorDeErro);
            Assert.IsFalse(retorno);
        }
    }
}
