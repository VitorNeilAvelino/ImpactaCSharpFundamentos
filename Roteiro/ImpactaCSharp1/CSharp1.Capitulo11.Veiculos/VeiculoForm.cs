using Impacta.Dominio;
using Impacta.Apoio;
using Impacta.Infra.Repositorios.SistemaDeArquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharp1.Capitulo11.Veiculos
{
    public partial class VeiculoForm : BaseForm
    {
        public VeiculoForm()
        {
            InitializeComponent();

            PopularControles();

            //Máscara >LLL<-0000
        }

        private void PopularControles()
        {
            marcaComboBox.DataSource = new MarcaRepositorio().Selecionar();
            marcaComboBox.DisplayMember = "Nome";
            marcaComboBox.ValueMember = "Id";
            marcaComboBox.SelectedIndex = -1;

            corComboBox.DataSource = new CorRepositorio().Selecionar();
            corComboBox.DisplayMember = "Nome";
            corComboBox.ValueMember = "Id";
            corComboBox.SelectedIndex = -1;

            //combustivelComboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            //combustivelComboBox.DataSource = new Combustivel().ParaListaComDescricao();
            combustivelComboBox.DataSource = new BindingSource(new Combustivel().ParaDicionarioComDescricao(), null);
            combustivelComboBox.DisplayMember = "Value";
            combustivelComboBox.ValueMember = "Key";
            combustivelComboBox.SelectedIndex = -1;

            cambioComboBox.DataSource = Enum.GetValues(typeof(Cambio));
            cambioComboBox.SelectedIndex = -1;
        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marcaComboBox.SelectedIndex == -1)
            {
                modeloComboBox.DataSource = null;
                return;
            }

            var marca = (Marca)marcaComboBox.SelectedItem;
            //var marca = (Marca)marcaComboBox.SelectedValue; // SelectedValue? Não, ainda é int.

            modeloComboBox.DataSource = new ModeloRepositorio().SelecionarPorMarca(marca.Id);
            modeloComboBox.DisplayMember = "Descricao";
            modeloComboBox.ValueMember = "Id";
            modeloComboBox.SelectedIndex = -1;
        }

        private void observacaoTextBox_TextChanged(object sender, EventArgs e)
        {
            observacaoGroupBox.Text = string.Format("Observação ({0})", observacaoTextBox.MaxLength - observacaoTextBox.Text.Length);
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (Formulario.Validar(this, veiculosErrorProvider))
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
            var veiculo = new VeiculoPasseio();
            veiculo.Ano = Convert.ToInt32(anoMaskedTextBox.Text);
            veiculo.Cambio = (Cambio)cambioComboBox.SelectedItem;
            //veiculo.Combustivel = ((Dictionary<Enum, string>)combustivelComboBox.SelectedItem).;
            veiculo.Combustivel = (Combustivel)((KeyValuePair<Enum, string>)combustivelComboBox.SelectedItem).Key;
            veiculo.Cor = (Cor)corComboBox.SelectedItem;
            veiculo.Modelo = (Modelo)modeloComboBox.SelectedItem;
            veiculo.Carroceria = Carroceria.Hatch; // Deveria ter um combo no formulário.
            veiculo.Observacao = observacaoTextBox.Text;
            veiculo.Placa = placaMaskedTextBox.Text;

            new VeiculoRepositorio().Inserir(veiculo);
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

        protected override void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            base.salvarToolStripButton_Click(sender, e);
            gravarButton.PerformClick();
        }
    }
}