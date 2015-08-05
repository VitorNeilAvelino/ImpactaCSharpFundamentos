using System;
using System.IO;
using System.Windows.Forms;
using Impacta.Dominio;
using Impacta.Apoio;

namespace Impacta.Capitulo09.Produtos
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void codigoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
            {
                if (e.KeyChar == 13 && codigoTextBox.Text.Trim() != string.Empty)
                {
                    try
                    {
                        Mercadoria mercadoria = new Mercadoria();

                        mercadoria.Pesquisar(Convert.ToInt32(codigoTextBox.Text));

                        produtoTextBox.Text = mercadoria.Nome;
                        precoTextBox.Text = mercadoria.Preco.ToString("C2");
                        estoqueTextBox.Text = mercadoria.QtdEstoque.ToString();
                        familiaTextBox.Text = mercadoria.Familia.Nome;

                        codigoTextBox.SelectAll();
                    }
                    // É possível capturar (catch) múltiplas exceções, sempre da mais específica para a mais genérica
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("O arquivo Produtos.txt não foi localizado.");
                        Close();
                    }
                    catch (RegistroNaoEncontradoException ex)
                    {
                        MessageBox.Show(ex.Message);
                        Formulario.Limpar(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops! Algo não deu certo. Um email acaba de ser enviado para a equipe de suporte!");
                        Logar.PorEmail(ex);
                        Formulario.Limpar(this);
                    }
                }
            }
            else
            {
                e.KeyChar = '\0';
            }
        }
    }
}