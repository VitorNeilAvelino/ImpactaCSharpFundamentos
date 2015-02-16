using System;
using System.Windows.Forms;

namespace Impacta.Capitulo04.Tabuada
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void tabuadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                if (e.KeyChar == 13 && tabuadaTextBox.Text.Trim() != string.Empty)
                {
                    Calcular();
                }
            }
            else
            {
                // Caractere nulo, ou seja, não retorna nada para o teclado.
                e.KeyChar = '\0';
            }
        }

        private void Calcular()
        {
            tabuadaListBox.Items.Clear();

            int tabuada = Convert.ToInt32(tabuadaTextBox.Text);

            for (int i = 0; i <= 10; i++)
            {
                tabuadaListBox.Items.Add(string.Format(
                    "{0} x {1} = {2}",
                    tabuada,
                    i,
                    tabuada * i
                    ));
            }

            tabuadaTextBox.Focus();
            tabuadaTextBox.SelectAll();
        }
    }
}