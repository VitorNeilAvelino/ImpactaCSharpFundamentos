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
    public partial class form_novocadastro : Form
    {
        public form_novocadastro()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txt_DescricaoProduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher descrição do produto!!!");
                Txt_DescricaoProduto.Focus();
                return;
            }
            else if (Txt_FornecedorProduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o fornecedor do produto!!!");
                Txt_FornecedorProduto.Focus();
                return;
            }

            else if (maskedTxt_QuantidadeProduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a quantidade do produto!!!");
                maskedTxt_QuantidadeProduto.Focus();
                return;
            }

            else if (maskedTxt_EntradaPoduto.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a entrada do produto");
                maskedTxt_EntradaPoduto.Focus();
                return;
            }


            else if (maskedTxt_preco.Text.Trim() == "")
            {
                MessageBox.Show("favor preencher o preço do produto!!!");
                maskedTxt_preco.Focus();
                return;
            }
            else
            {
                cadastrar();
            }
                   
               
                                               
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_entrada_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTxt_QuantidadeProduto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
            
        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void form_novocadastro_Load(object sender, EventArgs e)
        {

        }

        private void Txt_DescricaoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void cadastrar()
        {


            ControleProduto_MODEL controleproduto_model = new ControleProduto_MODEL();
            controleproduto_model.descricao = Txt_DescricaoProduto.Text.ToString();
            controleproduto_model.fornecedor = Txt_FornecedorProduto.Text.ToString();
            controleproduto_model.quantidade = int.Parse(maskedTxt_QuantidadeProduto.Text);
            controleproduto_model.entrada = maskedTxt_EntradaPoduto.Text.ToString();
            controleproduto_model.Preco = decimal.Parse(maskedTxt_preco.Text);
            if (MessageBox.Show("Deseja Cadastrar registro ?", "Cancelamento de Resgistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ControleProduto_BLL controleproduto_bll = new ControleProduto_BLL();
                    controleproduto_bll.CadastrarProduto_DAL(controleproduto_model);
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    LimparTela();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Erro" + erro);
                }
            }
            else
            {
                LimparTela();
            }

        }

        public void LimparTela()
        {
            Txt_DescricaoProduto.Text = "";
            maskedTxt_EntradaPoduto.Text = "";
            Txt_FornecedorProduto.Text = "";
            maskedTxt_QuantidadeProduto.Text = "";
            maskedTxt_preco.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LimparTela();
        }
       
    }
}
