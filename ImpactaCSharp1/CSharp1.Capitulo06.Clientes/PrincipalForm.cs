using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharp1.Capitulo06.Clientes
{
    public partial class PrincipalForm : Form
    {
        private ListagemClientesForm _listagemClientes;// = new ListagemClientesForm();
        private ClientesForm _cadastroClientes;// = new ClientesForm();

        public PrincipalForm()
        {
            InitializeComponent();
            //3. Inscrição no evento
            //_listagemClientes.SelecionarCliente += _listagemClientes_SelecionarCliente;
        }

        //4. Execução de método
        void _listagemClientes_SelecionarCliente(Impacta.Dominio.Cliente cliente)
        {
            AbrirCadastroClientes();
            _cadastroClientes.PreencherControles(cliente);
            _cadastroClientes.BringToFront();
        }

        private void clientesToolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            if (this.MdiChildren.Contains(_listagemClientes))
            {
                return;
            }

            _listagemClientes = new ListagemClientesForm();
            //3. Inscrição no evento
            _listagemClientes.SelecionarCliente += _listagemClientes_SelecionarCliente;

            AbrirFormularioFilho(_listagemClientes);
        }

        private void AbrirFormularioFilho(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCadastroClientes();
        }

        private void AbrirCadastroClientes()
        {
            if (this.MdiChildren.Contains(_cadastroClientes))
            {
                return;
            }

            _cadastroClientes = new ClientesForm();

            AbrirFormularioFilho(_cadastroClientes);
        }
    }
}
