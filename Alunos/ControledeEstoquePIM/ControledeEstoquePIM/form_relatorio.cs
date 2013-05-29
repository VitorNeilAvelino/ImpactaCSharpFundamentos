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
    public partial class form_relatorio : Form
    {
        public form_relatorio()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_relatorio_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_relatorio));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleEstoqueDataSet = new ControledeEstoquePIM.ControleEstoqueDataSet();
            this.produtosTableAdapter = new ControledeEstoquePIM.ControleEstoqueDataSetTableAdapters.ProdutosTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleEstoqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(686, 606);
            this.dataGridView1.TabIndex = 0;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.controleEstoqueDataSet;
            // 
            // controleEstoqueDataSet
            // 
            this.controleEstoqueDataSet.DataSetName = "ControleEstoqueDataSet";
            this.controleEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, -1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Data Entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // form_relatorio
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(686, 662);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_relatorio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Produtos";
            this.Load += new System.EventHandler(this.form_relatorio_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleEstoqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private void form_relatorio_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleEstoqueDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.controleEstoqueDataSet.Produtos);

        }

        private DataGridView dataGridView1;
        private ControleEstoqueDataSet controleEstoqueDataSet;
        private BindingSource produtosBindingSource;
        private IContainer components;
        private ControleEstoqueDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;

       
    }
}
