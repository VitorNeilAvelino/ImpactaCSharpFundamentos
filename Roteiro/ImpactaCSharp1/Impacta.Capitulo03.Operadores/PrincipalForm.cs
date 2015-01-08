using System;
using System.Windows.Forms;

namespace Impacta.Capitulo03.Operadores
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void aritmeticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a=2, b=6, c=10, d = 13;

            resultadoListBox.Items.Add("a = " + a);
        }

        private void ternariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano = 2014;
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}", ano, (ano% 4 == 0 ? "Sim!" : "Não!")));
            ano = 2016;
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}", ano, (DateTime.IsLeapYear(ano) ? "Sim!" : "Não!")));
        }

        private void precedenciaAssociatividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 10, b = 15, c = 10;

            resultadoListBox.Items.Add("a == c || b != a && a == b = " + (a == c || b != a && a == b));
        }
    }
}
