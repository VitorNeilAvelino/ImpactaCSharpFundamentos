using System;
using System.Web.UI.WebControls;
using Impacta.Infra.Apoio;

namespace PlantaoDeDuvidas.WebApplication.UserControls
{
    public partial class Cadastro : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cnpjCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Validar.Cpf(cnpjTextBox.Text))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}