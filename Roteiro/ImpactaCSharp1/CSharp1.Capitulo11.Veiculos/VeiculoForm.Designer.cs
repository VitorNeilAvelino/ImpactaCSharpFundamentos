namespace CSharp1.Capitulo11.Veiculos
{
    partial class VeiculoForm
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
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.corComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.combustivelComboBox = new System.Windows.Forms.ComboBox();
            this.cambioComboBox = new System.Windows.Forms.ComboBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.observacaoGroupBox = new System.Windows.Forms.GroupBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.anoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.veiculosErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.limparButton = new System.Windows.Forms.Button();
            this.observacaoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano";
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(56, 124);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(121, 21);
            this.modeloComboBox.TabIndex = 5;
            this.modeloComboBox.Tag = "*";
            // 
            // corComboBox
            // 
            this.corComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.corComboBox.FormattingEnabled = true;
            this.corComboBox.Location = new System.Drawing.Point(281, 30);
            this.corComboBox.Name = "corComboBox";
            this.corComboBox.Size = new System.Drawing.Size(121, 21);
            this.corComboBox.Sorted = true;
            this.corComboBox.TabIndex = 9;
            this.corComboBox.Tag = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 80);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Combustível";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 127);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Câmbio";
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(56, 77);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(121, 21);
            this.marcaComboBox.Sorted = true;
            this.marcaComboBox.TabIndex = 3;
            this.marcaComboBox.Tag = "*";
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // combustivelComboBox
            // 
            this.combustivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combustivelComboBox.FormattingEnabled = true;
            this.combustivelComboBox.Location = new System.Drawing.Point(281, 77);
            this.combustivelComboBox.Name = "combustivelComboBox";
            this.combustivelComboBox.Size = new System.Drawing.Size(121, 21);
            this.combustivelComboBox.Sorted = true;
            this.combustivelComboBox.TabIndex = 11;
            this.combustivelComboBox.Tag = "*";
            // 
            // cambioComboBox
            // 
            this.cambioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cambioComboBox.FormattingEnabled = true;
            this.cambioComboBox.Location = new System.Drawing.Point(281, 124);
            this.cambioComboBox.Name = "cambioComboBox";
            this.cambioComboBox.Size = new System.Drawing.Size(121, 21);
            this.cambioComboBox.Sorted = true;
            this.cambioComboBox.TabIndex = 13;
            this.cambioComboBox.Tag = "*";
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(445, 28);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(121, 23);
            this.gravarButton.TabIndex = 15;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // observacaoGroupBox
            // 
            this.observacaoGroupBox.Controls.Add(this.observacaoTextBox);
            this.observacaoGroupBox.Location = new System.Drawing.Point(8, 221);
            this.observacaoGroupBox.Name = "observacaoGroupBox";
            this.observacaoGroupBox.Size = new System.Drawing.Size(558, 112);
            this.observacaoGroupBox.TabIndex = 14;
            this.observacaoGroupBox.TabStop = false;
            this.observacaoGroupBox.Text = "Observação (300)";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.Location = new System.Drawing.Point(6, 19);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.observacaoTextBox.Size = new System.Drawing.Size(545, 87);
            this.observacaoTextBox.TabIndex = 0;
            this.observacaoTextBox.TextChanged += new System.EventHandler(this.observacaoTextBox_TextChanged);
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Location = new System.Drawing.Point(56, 30);
            this.placaMaskedTextBox.Mask = ">LLL<-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.placaMaskedTextBox.TabIndex = 1;
            this.placaMaskedTextBox.Tag = "*PLACA";
            this.placaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // anoMaskedTextBox
            // 
            this.anoMaskedTextBox.Location = new System.Drawing.Point(56, 171);
            this.anoMaskedTextBox.Mask = "0000";
            this.anoMaskedTextBox.Name = "anoMaskedTextBox";
            this.anoMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.anoMaskedTextBox.TabIndex = 7;
            this.anoMaskedTextBox.Tag = "*ANO";
            // 
            // veiculosErrorProvider
            // 
            this.veiculosErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.veiculosErrorProvider.ContainerControl = this;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(445, 57);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(121, 23);
            this.limparButton.TabIndex = 16;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 441);
            this.Controls.Add(this.anoMaskedTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.observacaoGroupBox);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.corComboBox);
            this.Controls.Add(this.cambioComboBox);
            this.Controls.Add(this.combustivelComboBox);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.modeloComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VeiculoForm";
            this.Tag = "*";
            this.Text = "Veículos";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.modeloComboBox, 0);
            this.Controls.SetChildIndex(this.marcaComboBox, 0);
            this.Controls.SetChildIndex(this.combustivelComboBox, 0);
            this.Controls.SetChildIndex(this.cambioComboBox, 0);
            this.Controls.SetChildIndex(this.corComboBox, 0);
            this.Controls.SetChildIndex(this.gravarButton, 0);
            this.Controls.SetChildIndex(this.limparButton, 0);
            this.Controls.SetChildIndex(this.observacaoGroupBox, 0);
            this.Controls.SetChildIndex(this.placaMaskedTextBox, 0);
            this.Controls.SetChildIndex(this.anoMaskedTextBox, 0);
            this.observacaoGroupBox.ResumeLayout(false);
            this.observacaoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private System.Windows.Forms.ComboBox corComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.ComboBox combustivelComboBox;
        private System.Windows.Forms.ComboBox cambioComboBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.GroupBox observacaoGroupBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox anoMaskedTextBox;
        private System.Windows.Forms.ErrorProvider veiculosErrorProvider;
        private System.Windows.Forms.Button limparButton;
    }
}

