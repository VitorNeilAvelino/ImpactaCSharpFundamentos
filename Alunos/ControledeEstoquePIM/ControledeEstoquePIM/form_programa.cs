using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControledeEstoquePIM
{
    public partial class form_programa : Form
    {
        public form_programa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_atualizar frm_estoque = new form_atualizar();
            frm_estoque.ShowDialog();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_cadastrofuncionario frm_cadastrofuncionario = new form_cadastrofuncionario();
            frm_cadastrofuncionario.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_novocadastro frm_novocadastro = new form_novocadastro();
            frm_novocadastro.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_update_Produtos form_update = new Form_update_Produtos();
            form_update.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_relatorio frm_relatorio = new form_relatorio();
            frm_relatorio.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_atualizar frm_estoque = new form_atualizar();
            frm_estoque.ShowDialog();

           
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_programa_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_novocadastro frm_novocadastro = new form_novocadastro();
            frm_novocadastro.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_update_Produtos form_update = new Form_update_Produtos();
            form_update.ShowDialog();
            
            
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_relatorio frm_relatorio = new form_relatorio();
            frm_relatorio.ShowDialog();
        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            form_cadastrofuncionario frm_cadastrofuncionario = new form_cadastrofuncionario();
            frm_cadastrofuncionario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            form_fornecedor frm_fornecedor = new form_fornecedor();
            frm_fornecedor.ShowDialog();
        }

       

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form_fornecedor frm_fornecedor = new form_fornecedor();
            frm_fornecedor.ShowDialog();
        }

        

       
    }
}
