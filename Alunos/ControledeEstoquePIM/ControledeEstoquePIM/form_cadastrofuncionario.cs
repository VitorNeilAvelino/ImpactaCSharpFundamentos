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
    public partial class form_cadastrofuncionario : Form
    {
        public form_cadastrofuncionario()
        {
            InitializeComponent();
        }

        private void form_cadastrofuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void masked_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o mome!!!");
                txt_nome.Focus();
                return;
            }

           else if (maskedTxt_cpf.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o CPF!!!");
                maskedTxt_cpf.Focus();
                return;
            }
                
            else if (maskedTxt_rg.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o RG!!!");
                maskedTxt_rg.Focus();
                return;
            }


            else if (maskedTxt_nasc.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a data de Nascimento!!!");
                maskedTxt_nasc.Focus();
                return;
            }
             
            else if (maskedTxt_fone.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o Telefone!!!");
                maskedTxt_fone.Focus();
                return;
            
            }

            else if (txt_usuario.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo Login!!!");
                txt_usuario.Focus();
                return;
            }

            else if (txt_senha.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo Senha!!!");
                txt_senha.Focus();
                return;
            }

            else if (txt_confirmasenha.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo Confirmar Senha!!!");
                txt_confirmasenha.Focus();
                return;
            }

            else
            {
                cadastrar();
            }

        }            

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTxt_nasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o Nome!!!");
                txt_nome.Focus();
                return;
            }

            else if (maskedTxt_cpf.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o  CPF!!!");
                maskedTxt_cpf.Focus();
                return;
            }

            else if (maskedTxt_rg.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o RG!!!");
                maskedTxt_rg.Focus();
                return;
            }


            else if (maskedTxt_nasc.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher a data de Nascimento!!!");
                maskedTxt_nasc.Focus();
                return;
            }

            else if (maskedTxt_fone.Text.Trim() == "")
            {
                MessageBox.Show("Favor informar o Telefone!!!");
                maskedTxt_fone.Focus();
                return;

            }

            else if (txt_usuario.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo Login!!!");
                txt_usuario.Focus();
                return;
            }

          

            else
            {
                atualizar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_pesquisa.Text.Trim() == "")
            {
                MessageBox.Show("Favor Preencher o Campo Pesquisa");
                txt_pesquisa.Focus();
                return;
            }
            else if (txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o  Nome!!!");
                txt_nome.Focus();
                return;
            }

            else if (maskedTxt_cpf.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo CPF!!!");
                maskedTxt_cpf.Focus();
                return;
            }

            else if (maskedTxt_rg.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo RG!!!");
                maskedTxt_rg.Focus();
                return;
            }


            else if (maskedTxt_nasc.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo Nascimento!!!");
                maskedTxt_nasc.Focus();
                return;
            }

            else if (maskedTxt_fone.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo Fone!!!");
                maskedTxt_fone.Focus();
                return;

            }

            else if (txt_usuario.Text.Trim() == "")
            {
                MessageBox.Show("Favor preencher o campo Login!!!");
                txt_usuario.Focus();
                return;
            }

            else
            {
                delete();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txt_pesquisa.Text.Trim() == "")
            {
                MessageBox.Show("Favor Preencher o Campo de Pesquisa");
                txt_pesquisa.Focus();
                return;
            }
            else
            {
                pesquisar();
              
            }
        }

        public void LimparCampos()
        {
            txt_nome.Text = "";
            txt_usuario.Text = "";
            txt_senha.Text = "";
            txt_confirmasenha.Text = "";
            maskedTxt_fone.Text = "";
            maskedTxt_cpf.Text = "";
            maskedTxt_rg.Text = "";
            maskedTxt_nasc.Text = "";
            txt_pesquisa.Text = "";
            txt_codigo.Text = "";
            txt_endereco.Text = "";
            txt_cidade.Text = "";
            txt_estado.Text = "";



        }

        public void cadastrar()
        {
            Usuario_MODEL obj_usuario = new Usuario_MODEL();
            obj_usuario.Nome = txt_nome.Text.ToString();
            obj_usuario.Usuario = txt_usuario.Text.ToString();
            obj_usuario.Senha = txt_senha.Text.ToString();
            obj_usuario.Fone = maskedTxt_fone.Text.ToString();
            obj_usuario.RG = maskedTxt_rg.Text.ToString();
            obj_usuario.CPF = maskedTxt_cpf.Text.ToString();
            obj_usuario.nasc = maskedTxt_nasc.Text.ToString();
            obj_usuario.endereco = txt_endereco.Text.ToString();
            obj_usuario.cidade = txt_cidade.Text.ToString();
            obj_usuario.estado = txt_estado.Text.ToString();




            if (txt_confirmasenha.Text == txt_senha.Text)
            {
                try
                {
                    Usuario_DAL obj_dal = new Usuario_DAL();
                    obj_dal.CadastrarFuncionario(obj_usuario);
                    MessageBox.Show("Cadastro efetuado com sucesso!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (SqlException erro)
                {
                    MessageBox.Show("Erro: " + erro);
                }

            }

            else
            {
                MessageBox.Show("Senha incorreta!!!");
                txt_senha.Text = "";
                txt_confirmasenha.Text = "";
            }


        }

        private void atualizar()
        {
            if (MessageBox.Show("Deseja Atualizar registro ?", "Cancelamento de Resgistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string conexao_SQlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                    SqlConnection conexao = new SqlConnection(conexao_SQlServer);
                    string cmd = string.Format("Update LoginSenha set nome = '{0}', usuario = '{1}', fone = '{2}', rg = '{3}',cpf = '{4}' ,nasc = '{5}',endereco = '{6}' ,cidade = '{7}', estado = '{8}' where id_usuario = '{9}'", txt_nome.Text, txt_usuario.Text ,maskedTxt_fone.Text, maskedTxt_rg.Text, maskedTxt_cpf.Text, maskedTxt_nasc.Text,txt_endereco.Text,txt_cidade.Text,txt_estado.Text, txt_codigo.Text);
                    SqlCommand sql = new SqlCommand(cmd, conexao);
                    LimparCampos();
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
                LimparCampos();
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
                    string cmd = string.Format("delete from LoginSenha where id_usuario = '{0}'", txt_codigo.Text);
                    SqlCommand sql = new SqlCommand(cmd, conexao);
                    LimparCampos();
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
                LimparCampos();
            }
        }

        private void pesquisar()
        {
            string pesquisa = txt_pesquisa.Text;
            Usuario_MODEL obj_Usuario = new Usuario_MODEL();


            Usuario_DAL obj_Dall = new Usuario_DAL();

            obj_Usuario = obj_Dall.PesquisarUsuario(pesquisa);

            txt_codigo.Text = (obj_Usuario.id_usuario).ToString();
            txt_nome.Text = obj_Usuario.nome;
            txt_usuario.Text = obj_Usuario.usuario;
            maskedTxt_fone.Text = obj_Usuario.fone;
            maskedTxt_rg.Text = obj_Usuario.rg;
            maskedTxt_cpf.Text = obj_Usuario.cpf;
            maskedTxt_nasc.Text = obj_Usuario.nasc;
            txt_endereco.Text = obj_Usuario.endereco;
            txt_cidade.Text = obj_Usuario.cidade;
            txt_estado.Text = obj_Usuario.estado;

            
            
        }

    }
}
