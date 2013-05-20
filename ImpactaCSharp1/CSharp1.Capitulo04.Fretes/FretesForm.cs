using System;
using System.Windows.Forms;
using Impacta.Infra.Apoio;
using Impacta.Infra.Repositorios.SistemaDeArquivos;
using Impacta.Dominio;

namespace CSharp1.Capitulo04.Fretes
{
    public partial class FretesForm : Form
    {
        public FretesForm()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Formulario.ValidarCamposObrigatorios(this, fretesErrorProvider) ||
                !Formulario.ValidarTipoDosDados(this, fretesErrorProvider))
            {
                return;
            }

            var frete = new Frete();
            frete.Cliente = clienteComboBox.SelectedItem as Cliente;
            frete.Valor = Convert.ToDecimal(valorTextBox.Text);
            frete.Uf = ufComboBox.Text;
            
            frete.Calcular(ufComboBox.Text, Convert.ToDecimal(valorTextBox.Text));
            freteLabel.Text = frete.Percentual.ToString("P2");
            totalLabel.Text = frete.Total.ToString("c");

            //var repositorio = new FreteRepositorio();
            //repositorio.Inserir(frete);
            new FreteRepositorio().Inserir(frete);
            MessageBox.Show("Frete gravado com sucesso!");

            Formulario.Limpar(this);
            freteLabel.Text = "0,0%";
            totalLabel.Text = "0,00";
            clienteComboBox.Focus();
        }

        private void FretesForm_Load(object sender, EventArgs e)
        {
            //var repositorio = new ClienteRepositorio();
            //var listaClientes = repositorio.Selecionar();
            //clienteBindingSource.DataSource = listaClientes;
            
            clienteBindingSource.DataSource = new ClienteRepositorio().Selecionar();

            clienteComboBox.SelectedIndex = -1;
        }
    }
}
