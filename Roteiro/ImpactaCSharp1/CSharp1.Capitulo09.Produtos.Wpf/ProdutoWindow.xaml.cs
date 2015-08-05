using System;
using System.Windows;
using System.Windows.Input;
using Impacta.Dominio;
using System.IO;
using Impacta.Apoio;

namespace CSharp1.Capitulo09.Produtos.Wpf
{
    public partial class ProdutoWindow : Window
    {
        public ProdutoWindow()
        {
            InitializeComponent();
        }

        private void codigoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                || e.Key == Key.Back || e.Key == Key.Enter || e.Key == Key.Tab)
            {
                if (e.Key == Key.Enter && codigoTextBox.Text.Trim() != string.Empty)
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
                        JanelaWpf.Limpar(controlesGrid);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops! Algo não deu certo. Um email acaba de ser enviado para a equipe de suporte!");
                        Logar.PorEmail(ex);
                        JanelaWpf.Limpar(controlesGrid);
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            codigoTextBox.Focus();
        }
    }
}