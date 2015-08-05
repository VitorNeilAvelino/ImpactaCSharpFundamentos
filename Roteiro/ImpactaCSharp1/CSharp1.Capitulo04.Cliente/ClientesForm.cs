using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Impacta.Apoio;
using System.Globalization;
using System.Resources;

namespace CSharp1.Capitulo03.Cliente
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            // Validar dados informados
            if (!ValidarFormulario())
            {
                return;
            }

            // Gravar dados no arquivo de texto
            GravarCliente();

            //Limpar o formulário
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            nomeTextBox.Clear();
            enderecoTextBox.Clear();
            femininoRadioButton.Checked = false;
            masculinoRadioButton.Checked = false;
            estadoCivilComboBox.SelectedIndex = -1;
            preferencialCheckBox.Checked = false;
            paisListBox.SelectedIndex = -1;
            nomeTextBox.Focus();
        }

        private void GravarCliente()
        {
            string caminho = @"C:\CadastroDeClientes.txt";
            string registro = string.Format("{0};{1};{2};{3};{4};{5};{6}",
                nomeTextBox.Text.ToUpper(),
                enderecoTextBox.Text.ToUpper(),
                femininoRadioButton.Checked ? "F" : "M",
                estadoCivilComboBox.Text.ToUpper(),
                preferencialCheckBox.Checked ? "1" : "0",
                paisListBox.Text,
                DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")); // HH - 24 h; hh - AM/PM

            StreamWriter sw = new StreamWriter(caminho, true);
            sw.WriteLine(registro);
            sw.Close();

            MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarFormulario()
        {
            if (nomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nomeTextBox.Focus();
                return false;
            }
            if (enderecoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Endereço é de preenchimento obrigatório!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enderecoTextBox.Focus();
                return false;
            }

            if (!masculinoRadioButton.Checked && !femininoRadioButton.Checked)
            {
                MessageBox.Show("Selecione o Sexo do Cliente!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (estadoCivilComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Estado civil do Cliente!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estadoCivilComboBox.Focus();
                SendKeys.Send("{F4}");
                return false;
            }
            if (paisListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o País do Cliente!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paisListBox.Focus();
                return false;
            }
            return true;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void ajudaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.google.com");
        }

        // Criar Mensagens.resx e Mensagens.en-US.resx
        private void AjustarIdioma(CultureInfo cultura)
        {
            var rm = new ResourceManager("CSharp1.Capitulo03.Cliente.Mensagens", typeof(ClientesForm).Assembly);
            nomeLabel.Text = rm.GetString("nomeLabel", cultura);
        }

        private void portuguesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AjustarIdioma(null);
        }

        private void inglesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AjustarIdioma(new CultureInfo("en-US"));
        }
    }
}