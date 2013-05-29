using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControledeEstoquePIM
{
    public partial class Form_update_Produtos : Form
    {
        public Form_update_Produtos()
        {
            InitializeComponent();
        }

        private void Form_update_Produtos_Load(object sender, EventArgs e)
        {

        }

        public void LimparTela()
        {
            Txt_CodigoProduto.Text = "";
            Txt_DescricaoProduto.Text = "";
            maskedTxt_EntradaPoduto.Text = "";
            txt_FornecedorProduto.Text = "";
            Txt_QuantidadeProduto.Text = "";
            maskedTxt_preco.Text = "";
            Txt_Pesquisa.Text = "";
            maskedTxt_preco.Text = "";
            txt_test.Text = "";
            txt_inserir.Text = "";
        }

        private void pesquisar()
        {
            string pesquisa = Txt_Pesquisa.Text;
            ControleProduto_MODEL obj_produto = new ControleProduto_MODEL();


            try
            {
                ControleProduto_BLL controleprodutobll = new ControleProduto_BLL();
                obj_produto = controleprodutobll.PesquisarProduto_DAl(pesquisa);

                Txt_CodigoProduto.Text = (obj_produto.codigo).ToString();
                Txt_DescricaoProduto.Text = obj_produto.descricao;
                txt_FornecedorProduto.Text = obj_produto.fornecedor;
                Txt_QuantidadeProduto.Text = (obj_produto.quantidade).ToString();
                maskedTxt_EntradaPoduto.Text = obj_produto.entrada;
                maskedTxt_preco.Text = (obj_produto.preco).ToString();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Pesquisa.Text.Trim() == "")
            {
                MessageBox.Show("Favor Preencher o Campo Pesquisar");
                Txt_Pesquisa.Focus();
                return;
            }

            else
            {
            pesquisar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atualizar()
        {
            if (MessageBox.Show("Deseja Atualizar registro ?", "Cancelamento de Resgistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string conexao_SQlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    SqlConnection conexao = new SqlConnection(conexao_SQlServer);
                    string cmd = string.Format("Update Produtos set quantidade =  {0} - {1} + {2} where codigo = {3}", Txt_QuantidadeProduto.Text, txt_test.Text, txt_inserir.Text, Txt_CodigoProduto.Text);
                 
                    SqlCommand sql = new SqlCommand(cmd, conexao);
                    LimparTela();
                    MessageBox.Show("Atualização efetuada com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    conexao.Open();
                    sql.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro atualizacao" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
            }
            else
            {
                LimparTela();
            }
        }

        private void excluir()
        {
            if (MessageBox.Show("Deseja excluir registro ?", "Cancelamento de Resgistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                ControleProduto_MODEL controleproduto_model = new ControleProduto_MODEL();
                controleproduto_model.codigo = int.Parse(Txt_CodigoProduto.Text.ToString());

                try
                {
                    ControleProduto_BLL controleproduto_bll = new ControleProduto_BLL();
                    controleproduto_bll.ExcluirProduto_DAl(controleproduto_model);
                    LimparTela();
                    MessageBox.Show("Produto Excluido com sucesso!!!");

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro = " + erro);
                }
            }
            else
            {
                Txt_CodigoProduto.Text = "";
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoProduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o codigo do produto!!!");
                Txt_CodigoProduto.Focus();
                return;
            }
            if (Txt_DescricaoProduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher Descrição do produto!!!");
                Txt_DescricaoProduto.Focus();
                return;
            }
            else if (txt_FornecedorProduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o Fornecedor do produto!!!");
                txt_FornecedorProduto.Focus();
                return;
            }

            else if (Txt_QuantidadeProduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a Quantidade do produto!!!");
                Txt_QuantidadeProduto.Focus();
                return;
            }

            else if (maskedTxt_EntradaPoduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a data de Entrada ");
                maskedTxt_EntradaPoduto.Focus();
                return;
            }


            else if (maskedTxt_preco.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o Preço do produto!!!");
                maskedTxt_preco.Focus();
                return;
            }
            else if (txt_test.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a Quantidade retidada");
                txt_test.Focus();
                return;
            }
            else if (txt_inserir.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a Quantidade Inserida");
                txt_inserir.Focus();
                return;
            }
            else
            {
                atualizar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Txt_Pesquisa.Text.Trim () == "")
            {
                MessageBox.Show("Digite o produto no Campo de Pesquisa!!!");
                Txt_Pesquisa.Focus();
                return;
            }


            else
            {
                excluir();
            }
        }
    }
}
