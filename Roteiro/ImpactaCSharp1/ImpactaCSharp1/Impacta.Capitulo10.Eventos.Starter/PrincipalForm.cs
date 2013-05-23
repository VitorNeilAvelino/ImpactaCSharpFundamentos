using System;
using System.Windows.Forms;
using Impacta.Infra.Repositorios.SistemaDeArquivos;
using System.IO;

namespace Impacta.Capitulo10.Eventos
{
    public partial class PrincipalForm : Form
    {
        private NovoForm _novoForm = new NovoForm();

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void pesquisaToolStripTextBox_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
        }
    }
}