using System;
using System.Windows.Forms;
using Impacta.Infra.Apoio;

namespace CSharp1.Capitulo09.InternetSpy.WindowsForms
{
    public partial class InternetSpyForm : Form
    {
        public InternetSpyForm()
        {
            InitializeComponent();
            Imagens.CapturarTela(string.Format(@"C:\Users\Vitor\Desktop\InternetSpy_{0}.png", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")));
            Application.Exit();
        }

        private void InternetSpyForm_Load(object sender, EventArgs e)
        {
            //Imagens.CapturarTela(string.Format(@"C:\Users\Vitor\Desktop\InternetSpy_{0}.png", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")));
            //Application.Exit();
        }
    }
}