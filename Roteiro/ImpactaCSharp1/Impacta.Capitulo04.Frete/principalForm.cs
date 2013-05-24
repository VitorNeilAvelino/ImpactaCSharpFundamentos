using System;
using System.Windows.Forms;
using Impacta.Infra.Apoio;
using System.IO;
using Impacta.Infra.Repositorios.SqlServer;
using System.Linq;

namespace Impacta.Capitulo04.Frete
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
            clienteTextBox.LostFocus += new EventHandler(clienteTextBox_LostFocus);
        }

        void clienteTextBox_LostFocus(object sender, EventArgs e)
        {
            clienteTextBox.AutoCompleteCustomSource.Add(clienteTextBox.Text);
        }

        private void Calcular()
        {
            decimal valor, perc = 0;
            valor = Convert.ToDecimal(valorCompraTextBox.Text);

            // Define o percentual de acordo com o Estado
            switch(ufComboBox.Text.ToUpper())
            {
                case "SP":
                    perc = 0.2M;
                    // break - interrompe a execução do bloco switch
                    break;
                case "RJ": perc = 0.3M; break;
                case "MG":
                    perc = 0.35M;
                    break;
                case "AM":
                    perc = 0.6M;
                    break;
                // default - não é obrigatório, mas se declarado é executado se nenhuma
                // outra opção for executada.
                default:
                    perc = 0.75M;
                    break;
            }

            // O switch acima pode ser substituído pelo bloco de if's abaixo
            /*if (ufComboBox.Text.ToUpper() == "SP")
            {
                perc = 0.2M;
            }
            else if (ufComboBox.Text.ToUpper() == "RJ")
            {
                perc = 0.3M;
            }
            else if (ufComboBox.Text.ToUpper() == "MG")
            {
                perc = 0.35M;
            }
            else
            {
                perc = 0.75M;
            }*/

            freteLabel.Text = perc.ToString("P1");
            totalLabel.Text = (valor * (1 + perc)).ToString("c2");
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Formulario.ValidarCamposObrigatorios(this, principalErrorProvider)) return;
            if (!Formulario.ValidarTipoDosDados(this, principalErrorProvider)) return;

            Calcular();

            string registro = string.Format("{0};{1};{2};{3};{4}",
                clienteTextBox.Text,
                valorCompraTextBox.Text,
                ufComboBox.Text,
                freteLabel.Text,
                totalLabel.Text
                );

            Gravar(registro, @"C:\Loja.txt");

            MessageBox.Show("Gravação efetuada com sucesso.");

            //Formularios.Limpar(this);
            this.Limpar();
            
            freteLabel.Text = "0%";
            totalLabel.Text = "0,00";

            clienteTextBox.Focus();
        }

        private void Gravar(string registro, string caminho)
        {
            // Criação do objeto sw
            StreamWriter sw = new StreamWriter(caminho, true);
            // Gravação do registro
            sw.WriteLine(registro);
            sw.Close();
        }

        private void ufComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cidadeTableAdapter.SelecionarPorEstado(impactaCSharp1DataSet.Cidade, ufComboBox.Text);
            cidadeComboBox.DataSource = cidadeBindingSource;

            cidadeComboBoxEf.DataSource = new CidadeRepositorio().SelecionarPorEstado(ufComboBox.Text);
        }

        private void principalForm_Load(object sender, EventArgs e)
        {
            var fretes = File.ReadAllLines("C:\\Fretes.txt");
            clienteTextBox.AutoCompleteCustomSource.AddRange(fretes.Select(x => x.Split(';')[0]).ToArray());
            clienteRepositorioBindingSource.DataSource = new Infra.Repositorios.SistemaDeArquivos.ClienteRepositorio().Selecionar();
        }

        private void valorCompraTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Decimal)
            {
                e.Handled = true;
            }
        }

        private void valorCompraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            avisoErrorProvider.SetError(valorCompraTextBox, string.Empty);

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                //fretesToolTip.SetToolTip(valorCompraTextBox, "Use vírgula para separar os decimais.");
                avisoErrorProvider.SetError(valorCompraTextBox, "Use vírgula para separar os decimais.");
            }
        }
    }
}