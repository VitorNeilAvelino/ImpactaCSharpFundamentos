using System;
using System.Windows.Forms;
using Impacta.Infra.Repositorios.SistemaDeArquivos;
using Impacta.Dominio;

namespace CSharp1.Capitulo06.Clientes
{
    public partial class ListagemClientesForm : Form
    {
        public delegate void SelecionarClienteEventHandler(Cliente cliente);
        public event SelecionarClienteEventHandler SelecionarCliente;

        public ListagemClientesForm()
        {
            InitializeComponent();
        }

        private void ListagemClientesForm_Load(object sender, EventArgs e)
        {
            clientesDataGridView.DataSource = new ClienteRepositorio().Selecionar();
        }

        private void clientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cliente = clientesDataGridView.Rows[e.RowIndex].DataBoundItem as Cliente;
            SelecionarCliente(cliente);
            Close();
        }
    }
}