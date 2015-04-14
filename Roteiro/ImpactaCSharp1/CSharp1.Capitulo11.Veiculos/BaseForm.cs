using System;
using System.Windows.Forms;

namespace CSharp1.Capitulo11.Veiculos
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void fecharToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void salvarToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}