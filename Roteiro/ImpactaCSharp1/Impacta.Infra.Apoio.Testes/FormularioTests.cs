using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Impacta.Apoio.Tests
{
    [TestClass()]
    public class FormularioTests
    {
        static ErrorProvider provedorDeErro = new ErrorProvider();
        static Form formulario = new Form();

        [ClassInitialize]
        public static void Inicializar(TestContext contexto)
        {
            provedorDeErro.ContainerControl = formulario;
        }

        [TestMethod()]
        public void ValidacaoObrigatorioTest()
        {
            var nomeTextBox = new TextBox();
            nomeTextBox.Tag = "*";
            nomeTextBox.Text = "Texto";

            formulario.Controls.Add(nomeTextBox);

            var validacao = Formulario.Validar(formulario, provedorDeErro);

            Assert.IsTrue(validacao);          
            
            nomeTextBox.Text = "";

            validacao = Formulario.Validar(formulario, provedorDeErro);

            Assert.IsFalse(validacao);

            formulario.Controls.Remove(nomeTextBox);
        }

        [TestMethod]
        public void ValidacaoTipoDadoTeste()
        {
            var placaTextBox = new TextBox();
            placaTextBox.Tag = "PLACA";
            placaTextBox.Text = "ABC1234";

            formulario.Controls.Add(placaTextBox);

            var validacao = Formulario.Validar(formulario, provedorDeErro);

            Assert.IsTrue(validacao);
        }
    }
}