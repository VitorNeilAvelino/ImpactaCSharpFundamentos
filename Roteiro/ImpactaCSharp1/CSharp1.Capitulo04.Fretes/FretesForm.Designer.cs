namespace CSharp1.Capitulo04.Fretes
{
    partial class FretesForm
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
            this.freteLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gravarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.fretesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fretesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% Frete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total:";
            // 
            // freteLabel
            // 
            this.freteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.freteLabel.Location = new System.Drawing.Point(63, 118);
            this.freteLabel.Name = "freteLabel";
            this.freteLabel.Size = new System.Drawing.Size(121, 23);
            this.freteLabel.TabIndex = 7;
            this.freteLabel.Text = "0%";
            this.freteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(63, 156);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(121, 23);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "0,00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ufComboBox.Location = new System.Drawing.Point(63, 82);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 5;
            this.ufComboBox.Tag = "*";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(63, 44);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 3;
            this.valorTextBox.Tag = "*DECIMAL";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Impacta.Dominio.Cliente);
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(222, 127);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(108, 23);
            this.gravarButton.TabIndex = 10;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(222, 156);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(108, 23);
            this.limparButton.TabIndex = 11;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // fretesErrorProvider
            // 
            this.fretesErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.fretesErrorProvider.ContainerControl = this;
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(63, 6);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(266, 20);
            this.nomeClienteTextBox.TabIndex = 1;
            this.nomeClienteTextBox.Tag = "*DECIMAL";
            // 
            // FretesForm
            // 
            this.AcceptButton = this.gravarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.limparButton;
            this.ClientSize = new System.Drawing.Size(341, 192);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.freteLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FretesForm";
            this.Text = "Fretes";
            this.Load += new System.EventHandler(this.FretesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fretesErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label freteLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.ErrorProvider fretesErrorProvider;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
    }
}

