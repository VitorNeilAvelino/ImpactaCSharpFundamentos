using System;
using System.Windows.Forms;
using Impacta.Apoio;
using Impacta.Dominio;
using Impacta.Infra.Repositorios.SistemaDeArquivos;
using System.IO;
using System.Configuration;

namespace CSharp1.Capitulo06.Clientes
{
    public partial class ClientesForm : BaseForm
    {
        private string _caminho = ConfigurationManager.AppSettings["caminhoArquivoClientes"];
        
        public ClientesForm()
        {
            InitializeComponent();
        }

        public void PreencherControles(Cliente cliente)
        {
            nomeTextBox.Text = cliente.Nome;
            enderecoTextBox.Text = cliente.Endereco;
            nascimentoMaskedTextBox.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
            cpfMaskedTextBox.Text = cliente.Documentos[0].Numero;
            emailTextBox.Text = cliente.Email;
            rendaTextBox.Text = cliente.Renda.ToString();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Formulario.ValidarCamposObrigatorios(this, clientesErrorProvider) ||
                !Formulario.ValidarTipoDosDados(this, clientesErrorProvider))
            {
                return;
            }

            //wmp.URL = 

            var cliente = new Cliente();
            //var pessoa = new Pessoa();
            
            cliente.Nome = nomeTextBox.Text;
            cliente.Endereco = enderecoTextBox.Text;
            cliente.DataNascimento = Convert.ToDateTime(nascimentoMaskedTextBox.Text);

            //cliente.Documentos = cpfMaskedTextBox.Text;
            var cpf = new Documento();
            cpf.Numero = cpfMaskedTextBox.Text;
            cpf.TipoDocumento = TipoDocumento.Cpf;

            //cliente.Documentos = new List<Documento>();
            cliente.Documentos.Add(cpf);

            cliente.Email = emailTextBox.Text;
            cliente.Renda = Convert.ToDecimal(rendaTextBox.Text);

            try
            {
                cliente.Validar();
                new ClienteRepositorio().Gravar(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                Formulario.Limpar(this);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(string.Format("O caminho {0} não foi encontrado. Sua gravação não foi realizada.",
                    _caminho));
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(string.Format("Desmarque a opção de Read-Only do arquivo {0}. Sua gravação não foi realizada.",
                    _caminho));
            }
            catch (RegraNegocioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops! Houve um erro no aplicativo e a gravação não foi realizada." +
                                          "A equipe de suporte já foi comunicada e em breve teremos uma solução");
                Logar.PorEmail(ex);
            }
        }
    }
}