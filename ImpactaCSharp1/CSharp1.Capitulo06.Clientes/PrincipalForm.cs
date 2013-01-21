using System;
using System.Windows.Forms;

namespace CSharp1.Capitulo06.Clientes
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void listagemClientesToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (Form formularioFilho in this.MdiChildren)
            {
                if (formularioFilho is ClientesForm)
                {
                    return;
                }
            }

            var clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Dock = DockStyle.Fill;
            clientesForm.Show();
        }
    }
}