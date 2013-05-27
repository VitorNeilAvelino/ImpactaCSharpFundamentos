using System;

namespace PlantaoDeDuvidas.WebApplication
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            //Gravar
        }

        protected  void OcultarModal()
        {
            userControlPanel.Visible = false;
        }
    }
}
