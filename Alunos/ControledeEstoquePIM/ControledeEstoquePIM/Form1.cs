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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txt_usuario.Text.Trim () == "")
            {
            MessageBox.Show("Favor Preencher o Campo Usuário");
            txt_usuario.Focus();
            return;
            }

            else if (txt_senha.Text.Trim() == "")
            {
                MessageBox.Show("Favor Preencher o Campo Senha");
                txt_senha.Focus();
                return;
            }

            else
            {
                logar();
               
            }
           
           

        }
        private void logar()
        {

            string conexao_SqlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
           
            SqlConnection conexao = null;
            SqlCommand sql = null;

            string user;
            string pwd;

            user = txt_usuario.Text;
            pwd = txt_senha.Text;

            try
            {
                conexao = new SqlConnection(conexao_SqlServer);
                sql = new SqlCommand("select COUNT(id_usuario) from LoginSenha where usuario =@usuario AND senha=@senha", conexao);

                sql.Parameters.Add("@usuario", SqlDbType.VarChar).Value = user;
                sql.Parameters.Add("@senha", SqlDbType.VarChar).Value = pwd;

                conexao.Open();

                int v = (int)sql.ExecuteScalar();

                if (v > 0)
                {
                    form_programa frm_program = new form_programa();
                    frm_program.ShowDialog();
                    this.Close();
                    this.Dispose();
                   
                   
                   
                    
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválido!");
                    txt_usuario.Focus();
                    txt_usuario.Text = "";
                    txt_senha.Text = "";
                    
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
            finally
            {
                conexao.Close();
            }
        }
           
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
    
}
