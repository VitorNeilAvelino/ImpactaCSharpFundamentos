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
            int a=2, b=6, c=10, d = 15;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("d / a = " + d / a);
            resultadoListBox.Items.Add("d / a = " + d / Convert.ToDecimal(a));
            resultadoListBox.Items.Add("d / a = " + Math.Round(d / Convert.ToDecimal(a)));
            resultadoListBox.Items.Add("c / b = " + c / Convert.ToDecimal(b));
            resultadoListBox.Items.Add("c / b = " + Math.Round(c / Convert.ToDecimal(b), 2));
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

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = 4;

            resultadoListBox.Items.Add(++i + ++i); // 5 + 6
            resultadoListBox.Items.Add(++i + i++); // 7 + 7
            resultadoListBox.Items.Add(i++ + i++); // 8 + 9
            resultadoListBox.Items.Add(i); // 10

            //Debug.Print("teste");
        }
    }
}