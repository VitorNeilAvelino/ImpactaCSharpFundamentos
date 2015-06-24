using Impacta.Apoio;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharp1.Capitulo11.Veiculos.Starter
{
    public partial class VeiculoForm : Form
    {
        public VeiculoForm()
        {
            InitializeComponent();
            PopularControles();
        }

        private void PopularControles()
        {

        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void observacaoTextBox_TextChanged(object sender, EventArgs e)
        {
            observacaoGroupBox.Text = string.Format("Observação ({0})", 300 - observacaoTextBox.Text.Length);
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if(ValidarFormulario())
            {
                try
                {
                    GravarVeiculo();
                    MessageBox.Show("Gravação realizada com sucesso!");
                    Formulario.Limpar(this);
                    placaMaskedTextBox.Focus();
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("O caminho do arquivo de fretes não foi encontrado. A gravação não foi realizada.");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("O arquivo Veiculos.xml não tem permissão de gravação.");
                    //File.SetAttributes("C:\\Fretes.txt", FileAttributes.Normal);
                }
                catch (Exception excecao)
                {
                    MessageBox.Show("Ooops! Houve um erro e a gravação não foi realizada. O suporte já foi comunicado.");
                    //_log.Error(excecao);
                }
                finally
                {
                    // Opcional - se presente, é executado sempre, independente de sucesso, erro ou qualquer return.
                }
            }
        }

        private void GravarVeiculo()
        {

        }

        private bool ValidarFormulario()
        {
            var validacao = true;

            if (!Formulario.ValidarCamposObrigatorios(this, veiculosErrorProvider))
            {
                validacao = false;
            }
            else
            {
                veiculosErrorProvider.SetError(placaMaskedTextBox, string.Empty);
                veiculosErrorProvider.SetError(anoMaskedTextBox, string.Empty);

                if (!Regex.IsMatch(placaMaskedTextBox.Text, @"^[A-Z]{3}[0-9]{4}$"))
                {
                    veiculosErrorProvider.SetError(placaMaskedTextBox, "Digite a placa no formato AAA-0000.");
                    validacao = false;
                }

                if (!Regex.IsMatch(anoMaskedTextBox.Text, @"^[0-9]{4}$")) // ^$ não é obrigatório.
                {
                    veiculosErrorProvider.SetError(anoMaskedTextBox, "Digite o ano com quatro dígitos.");
                    validacao = false;
                }
            }

            return validacao;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            Formulario.Limpar(this);
            //this.Limpar();
            placaMaskedTextBox.Focus();
        }        
    }
}