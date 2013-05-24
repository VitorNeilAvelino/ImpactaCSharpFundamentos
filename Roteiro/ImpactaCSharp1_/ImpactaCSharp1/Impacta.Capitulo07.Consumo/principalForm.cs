using System;
using System.Drawing;
using System.Windows.Forms;
using Impacta.Infra.Apoio;

namespace Impacta.Capitulo07.Consumo
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                var consumo = new Impacta.Dominio.Consumo();
                consumo.Km = Converter.ParaDecimal(kmTextBox.Text);
                consumo.Litros = Converter.ParaDecimal(litrosTextBox.Text);

                if (consumo.Resultado < 10)
                {
                    consumoLabel.BackColor = Color.Red;
                    consumoLabel.ForeColor = Color.White;
                }
                else if (consumo.Resultado < 12)
                {
                    consumoLabel.BackColor = Color.Yellow;
                    consumoLabel.ForeColor = Color.Blue;
                }
                else
                {
                    consumoLabel.BackColor = Color.Green;
                    consumoLabel.ForeColor = Color.White;
                }
                consumoLabel.Text = consumo.Resultado.ToString("N1") + " km/l";
            }
            catch (Exception ex)
            {
                consumoLabel.BackColor = this.BackColor;
                consumoLabel.ForeColor = Color.Black;
                consumoLabel.Text = string.Empty;
                MessageBox.Show(ex.Message);
            }
        }
    }
}