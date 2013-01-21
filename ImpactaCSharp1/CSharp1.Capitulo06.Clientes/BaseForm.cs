using System;
using System.Windows.Forms;

namespace CSharp1.Capitulo06.Clientes
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void fecharToolStripButton_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente fechar?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resposta == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}