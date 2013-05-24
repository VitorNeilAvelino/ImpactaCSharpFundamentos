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
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == 13)
            {
                if (e.KeyChar == 13 && tabuadaTextBox.Text.Trim() != string.Empty)
                {
                    tabuadaListBox.Items.Clear();

                    int tabuada;
                    
                    try
                    {
                        tabuada = Convert.ToByte(tabuadaTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show(String.Format("Digite um número entre {0} e {1}.", byte.MinValue, byte.MaxValue));
                        FocarESelecionarTextBox();
                        return;
                    }

                    for (int i = 0; i <= 10; i++)
                    {
                        tabuadaListBox.Items.Add(string.Format(
                            "{0} x {1} = {2}",
                            tabuada,
                            i,
                            tabuada * i
                            ));
                    }
                    FocarESelecionarTextBox();
                }
            }
            else
            {
                // Caractere nulo, ou seja, não retorna nada para o teclado.
                e.KeyChar = '\0';
            }
        }

        private void FocarESelecionarTextBox()
        {
            tabuadaTextBox.Focus();
            tabuadaTextBox.SelectAll();
        }
    }
}