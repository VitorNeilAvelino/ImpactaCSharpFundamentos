using System;

namespace PlantaoDeDuvidas.WebApplication.UserControls
{
    public partial class ExemploPopup : System.Web.UI.UserControl
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToShortTimeString();
        }
    }
}