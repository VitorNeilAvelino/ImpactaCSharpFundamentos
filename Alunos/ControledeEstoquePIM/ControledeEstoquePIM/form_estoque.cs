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
    public partial class form_atualizar : Form
    {
        public form_atualizar()
        {
            InitializeComponent();
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
       
        private void button2_Click(object sender, EventArgs e)
        {
            form_novocadastro frm_novocadastro = new form_novocadastro();
            frm_novocadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Pesquisa.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo de Pesquisa");
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
            Txt_Pesquisa.Focus();
            LimparTela();

        }

        private void form_estoque_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       





    }
}
