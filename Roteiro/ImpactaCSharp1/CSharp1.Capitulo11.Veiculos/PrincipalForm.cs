using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharp1.Capitulo11.Veiculos
{
    public partial class PrincipalForm : Form
    {
        #region Formulários filhos
        VeiculoForm _veiculoForm;
        ClienteForm _clienteForm;
        #endregion

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void veiculosToolStripButton_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Contains(_veiculoForm))
            {
                return;
            }

            _veiculoForm = new VeiculoForm(); 
            //_veiculoForm.Show();
            //_veiculoForm.ShowDialog();
            _veiculoForm.MdiParent = this;
            _veiculoForm.Dock = DockStyle.Fill;
            _veiculoForm.Show();
        }
    }
}