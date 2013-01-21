using System;
using System.Windows.Forms;
using Impacta.Infra.Apoio;
using Impacta.Dominio;
using Impacta.Infra.Repositorios.SistemaDeArquivos;
using System.IO;
using System.Configuration;

namespace CSharp1.Capitulo06.Clientes
{
    public partial class ClientesForm : BaseForm, IFormularioComErrorProvider
    {
        private ListagemClientesForm _listagemClientesForm = new ListagemClientesForm();

        public ClientesForm()
        {
            InitializeComponent();
            _listagemClientesForm.SelecionarCliente += new ListagemClientesForm.SelecionarClienteEventHandler(_listagemClientesForm_SelecionarCliente);
        }

        void _listagemClientesForm_SelecionarCliente(Cliente cliente)
        {
            nomeTextBox.Text = cliente.Nome;
            enderecoTextBox.Text = cliente.Endereco;
            nascimentoMaskedTextBox.Text = cliente.DataNascimento.ToShortDateString();
            cpfMaskedTextBox.Text = cliente.Cpf;
            emailTextBox.Text = cliente.Email;
            rendaTextBox.Text = cliente.Renda.ToString();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Formulario.ValidarCamposObrigatorios(this, clientesErrorProvider) || !Formulario.ValidarTipoDosDados(this))
            {
                return;
            }

            var cliente = new Cliente();
            cliente.Nome = nomeTextBox.Text;
            cliente.Endereco = enderecoTextBox.Text;
            //cliente.DataNascimento = nascimentoDateTimePicker.Value.Date;
            cliente.DataNascimento = Convert.ToDateTime(nascimentoMaskedTextBox.Text);
            cliente.Email = emailTextBox.Text;
            cliente.Renda = Convert.ToDecimal(rendaTextBox.Text);

            var documento = new Documento();
            documento.Numero = cpfMaskedTextBox.Text;
            documento.TipoDocumento = TipoDocumento.Cpf;

            cliente.Documentos.Add(documento);

            try
            {
                cliente.Validar();
                new ClienteRepositorio().Gravar(cliente);
                //ClienteRepositorio.Teste();
                MessageBox.Show("Gravação realizada com sucesso.");
                Formulario.Limpar(this);
                nomeTextBox.Focus();
            }
            catch (RegraNegocioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(string.Format("Caminho {0} não encontrado. A gravação não foi realizada.", ConfigurationManager.AppSettings["caminhoArquivoClientes"]));
            }
            catch (Exception ex)
            {
#if !DEBUG
                MessageBox.Show(@"Houve um erro no processamento e o registro não foi gravado. 
                                    A equipe de suporte já foi avisada e em breve providenciaremos uma solução.");
                Logar.PorEmail(ex);
#else
                throw;
#endif
            }
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            Formulario.Limpar(this);
        }

        private void ClientesForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Habilitar KeyPreview
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        public ErrorProvider ProvedorDeErro
        {
            get { return clientesErrorProvider; }
        }

        private void listarClientesToolStripButton_Click(object sender, EventArgs e)
        {
            _listagemClientesForm.ShowDialog();
        }
    }
}