using System;
using System.Windows.Forms;
using Impacta.Infra.Repositorios.SistemaDeArquivos;
using Impacta.Dominio;

namespace CSharp1.Capitulo06.Clientes
{
    public partial class ListagemClientesForm : BaseForm
    {
        //1. Criação do evento
        public delegate void SelecionarClienteEventHandler(Cliente cliente);
        //public event EventHandler SelecionarCliente;
        public event SelecionarClienteEventHandler SelecionarCliente;

        public ListagemClientesForm()
        {
            InitializeComponent();
        }

        private void ListagemClientesForm_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new ClienteRepositorio().Selecionar();
        }

        private void clientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cliente = clientesDataGridView.Rows[e.RowIndex].DataBoundItem as Cliente;

            //2. Chamar o Evento
            SelecionarCliente(cliente);
        }
    }
}