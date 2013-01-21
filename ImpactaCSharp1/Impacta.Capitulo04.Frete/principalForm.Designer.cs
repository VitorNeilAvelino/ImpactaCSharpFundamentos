namespace Impacta.Capitulo04.Frete
{
    partial class principalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.freteLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.gravarButton = new System.Windows.Forms.Button();
            this.principalErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impactaCSharp1DataSet = new Impacta.Capitulo04.Frete.ImpactaCSharp1DataSet();
            this.cidadeTableAdapter = new Impacta.Capitulo04.Frete.ImpactaCSharp1DataSetTableAdapters.CidadeTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cidadeComboBoxEf = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteRepositorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.principalErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impactaCSharp1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteRepositorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Frete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.clienteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clienteTextBox.Location = new System.Drawing.Point(57, 6);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(237, 20);
            this.clienteTextBox.TabIndex = 1;
            this.clienteTextBox.Tag = "*";
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.Location = new System.Drawing.Point(57, 36);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorCompraTextBox.TabIndex = 3;
            this.valorCompraTextBox.Tag = ",*";
            // 
            // ufComboBox
            // 
            this.ufComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "AM",
            "Outros"});
            this.ufComboBox.Location = new System.Drawing.Point(57, 66);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 5;
            this.ufComboBox.Tag = "*";
            this.ufComboBox.SelectedIndexChanged += new System.EventHandler(this.ufComboBox_SelectedIndexChanged);
            // 
            // freteLabel
            // 
            this.freteLabel.AutoSize = true;
            this.freteLabel.Location = new System.Drawing.Point(57, 99);
            this.freteLabel.Name = "freteLabel";
            this.freteLabel.Size = new System.Drawing.Size(21, 13);
            this.freteLabel.TabIndex = 11;
            this.freteLabel.Text = "0%";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(57, 129);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(32, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "0,00";
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(513, 129);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 14;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // principalErrorProvider
            // 
            this.principalErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.principalErrorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cidade";
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DataSource = this.cidadeBindingSource;
            this.cidadeComboBox.DisplayMember = "Nome";
            this.cidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Location = new System.Drawing.Point(230, 66);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cidadeComboBox.TabIndex = 7;
            this.cidadeComboBox.Tag = "*";
            this.cidadeComboBox.ValueMember = "Id";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.impactaCSharp1DataSet;
            // 
            // impactaCSharp1DataSet
            // 
            this.impactaCSharp1DataSet.DataSetName = "ImpactaCSharp1DataSet";
            this.impactaCSharp1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cidade";
            // 
            // cidadeComboBoxEf
            // 
            this.cidadeComboBoxEf.DisplayMember = "Nome";
            this.cidadeComboBoxEf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBoxEf.FormattingEnabled = true;
            this.cidadeComboBoxEf.Location = new System.Drawing.Point(407, 66);
            this.cidadeComboBoxEf.Name = "cidadeComboBoxEf";
            this.cidadeComboBoxEf.Size = new System.Drawing.Size(121, 21);
            this.cidadeComboBoxEf.TabIndex = 9;
            this.cidadeComboBoxEf.Tag = "*";
            this.cidadeComboBoxEf.ValueMember = "Id";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clienteRepositorioBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "Id";
            // 
            // clienteRepositorioBindingSource
            // 
            this.clienteRepositorioBindingSource.DataSource = typeof(Impacta.Dominio.Cliente);
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(600, 162);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.freteLabel);
            this.Controls.Add(this.cidadeComboBoxEf);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.valorCompraTextBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "principalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capítulo 04 - Frete";
            this.Load += new System.EventHandler(this.principalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.principalErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impactaCSharp1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteRepositorioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.Label freteLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.ErrorProvider principalErrorProvider;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.Label label6;
        private ImpactaCSharp1DataSet impactaCSharp1DataSet;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private ImpactaCSharp1DataSetTableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.ComboBox cidadeComboBoxEf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clienteRepositorioBindingSource;
    }
}

