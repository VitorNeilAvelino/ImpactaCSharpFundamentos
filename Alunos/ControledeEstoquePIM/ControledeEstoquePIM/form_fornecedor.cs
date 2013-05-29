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
    public partial class form_fornecedor : Form
    {
        public form_fornecedor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_fornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Fornecedor Obrigatorio");
                txt_fornecedor.Focus();
                return;
            }
            else if (txt_endereco.Text.Trim() == "")
            {
                MessageBox.Show("Campo Endereço Obrigatorio");
                txt_endereco.Focus();
                return;
            }
            else if (txt_cep.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cep Obrigatorio");
                txt_cep.Focus();
                return;
            }
            else if (txt_cnpj.Text.Trim() == "")
            {
                MessageBox.Show("Campo CNPJ Obrigatorio");
                txt_cnpj.Focus();
                return;
            }
            else if (txt_cidade.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cidade Obrigatorio");
                txt_cidade.Focus();
                return;
            }
            else if (txt_estado.Text.Trim() == "")
            {
                MessageBox.Show("Campo Estado Obrigatorio");
                txt_estado.Focus();
                return;
            }
            else if (txt_telefone.Text.Trim() == "")
            {
                MessageBox.Show("Campo Telefone Obrigatorio");
                txt_telefone.Focus();
                return;
            } 
            else
            {
            Atualizar();
            limpa_tela();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_fornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Fornecedor Obrigatorio");
                txt_fornecedor.Focus();
                return;
            }
            else if (txt_endereco.Text.Trim() == "")
            {
                MessageBox.Show("Campo Endereço Obrigatorio");
                txt_endereco.Focus();
                return;
            }
            else if (txt_cep.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cep Obrigatorio");
                txt_cep.Focus();
                return;
            }
            else if (txt_cnpj.Text.Trim() == "")
            {
                MessageBox.Show("Campo CNPJ Obrigatorio");
                txt_cnpj.Focus();
                return;
            }
            else if (txt_cidade.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cidade Obrigatorio");
                txt_cidade.Focus();
                return;
            }
            else if (txt_estado.Text.Trim() == "")
            {
                MessageBox.Show("Campo Estado Obrigatorio");
                txt_estado.Focus();
                return;
            }
            else if (txt_telefone.Text.Trim() == "")
            {
                MessageBox.Show("Campo Telefone Obrigatorio");
                txt_telefone.Focus();
                return;
            } 
            else
            {

                Cadastrar();
                limpa_tela();
           }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_pesquisa.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo de Pesquisa");
                txt_pesquisa.Focus();
                return;
            }

            else
            {
                pesquisar();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_fornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Fornecedor Obrigatorio");
                txt_fornecedor.Focus();
                return;
            }
            else if (txt_endereco.Text.Trim() == "")
            {
                MessageBox.Show("Campo Endereço Obrigatorio");
                txt_endereco.Focus();
                return;
            }
            else if (txt_cep.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cep Obrigatorio");
                txt_cep.Focus();
                return;
            }
            else if (txt_cnpj.Text.Trim() == "")
            {
                MessageBox.Show("Campo CNPJ Obrigatorio");
                txt_cnpj.Focus();
                return;
            }
            else if (txt_cidade.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cidade Obrigatorio");
                txt_cidade.Focus();
                return;
            }
            else if (txt_estado.Text.Trim() == "")
            {
                MessageBox.Show("Campo Estado Obrigatorio");
                txt_estado.Focus();
                return;
            }
            else if (txt_telefone.Text.Trim() == "")
            {
                MessageBox.Show("Campo Telefone Obrigatorio");
                txt_telefone.Focus();
                return;
            }
            else
            {

                delete();
                limpa_tela();
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpa_tela();
        }

        private void pesquisar()
        { 
         string pesquisa = txt_pesquisa.Text;
            Fornecedor_RetornarDados obj_fornecedor = new Fornecedor_RetornarDados();


            Fornecedor_BD obj_BD = new Fornecedor_BD();

            obj_fornecedor = obj_BD.PesquisarFornecedor(pesquisa);

            txt_codigo.Text = ( obj_fornecedor.codigo).ToString();
            txt_fornecedor.Text = obj_fornecedor.Nome;
            txt_endereco.Text = obj_fornecedor.Endereco;
            txt_cep.Text = obj_fornecedor.CEP;
            txt_cnpj.Text = obj_fornecedor.CNPJ;
            txt_cidade.Text = obj_fornecedor.Cidade;
            txt_estado.Text = obj_fornecedor.Estado;
            txt_telefone.Text = obj_fornecedor.Telefone;
        }

        private void Cadastrar()
        {

            Fornecedor_RetornarDados obj_fornecedor = new Fornecedor_RetornarDados();
            obj_fornecedor.Nome = txt_fornecedor.Text;
            obj_fornecedor.Endereco = txt_endereco.Text;
            obj_fornecedor.CEP = txt_cep.Text;
            obj_fornecedor.CNPJ = txt_cnpj.Text;
            obj_fornecedor.Cidade = txt_cidade.Text;
            obj_fornecedor.Estado = txt_estado.Text;
            obj_fornecedor.Telefone = txt_telefone.Text;

            Fornecedor_BD obj_BD = new Fornecedor_BD();
            obj_BD.CadastrarFornecedor(obj_fornecedor);
            MessageBox.Show("Fornecedor Cadastrado com sucesso!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpa_tela()
        {
            txt_codigo.Text = "";
            txt_cep.Text = "";
            txt_cidade.Text = "";
            txt_cnpj.Text = "";
            txt_endereco.Text = "";
            txt_estado.Text = "";
            txt_fornecedor.Text = "";
            txt_pesquisa.Text = "";
            txt_telefone.Text = "";
                 
        }

        private void Atualizar()
        { 
        
            if (MessageBox.Show("Deseja Atualizar registro ?", "Cancelamento de Resgistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string conexao_SQlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    SqlConnection conexao = new SqlConnection(conexao_SQlServer);
                    string cmd = string.Format("Update Fornecedor set nome = '{0}', endereco = '{1}', cep = '{2}', cnpj = '{3}', cidade = '{4}' ,estado = '{5}' ,telefone = '{6}' where codigo = {7}",txt_fornecedor.Text,txt_endereco.Text,txt_cep.Text,txt_cnpj.Text,txt_cidade.Text,txt_estado.Text,txt_telefone.Text,txt_codigo.Text);
                    SqlCommand sql = new SqlCommand(cmd, conexao);
                    limpa_tela();
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
                limpa_tela();
            }
      
        }

        private void delete()
        {
            if (MessageBox.Show("Deseja deletar registro ?", "Cancelamento de Resgistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string conexao_SQlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    SqlConnection conexao = new SqlConnection(conexao_SQlServer);
                    string cmd = string.Format("delete from Fornecedor where codigo = '{0}'", txt_codigo.Text);
                    SqlCommand sql = new SqlCommand(cmd, conexao);
                    limpa_tela();
                    MessageBox.Show("Registro deletado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
                limpa_tela();
            }
        
        }

        public bool txt { get; set; }
    }
}
