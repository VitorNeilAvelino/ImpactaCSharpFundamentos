namespace CSharp1.Capitulo03.Cliente
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.sexoGroupBox = new System.Windows.Forms.GroupBox();
            this.femininoRadioButton = new System.Windows.Forms.RadioButton();
            this.masculinoRadioButton = new System.Windows.Forms.RadioButton();
            this.paisListBox = new System.Windows.Forms.ListBox();
            this.estadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.preferencialCheckBox = new System.Windows.Forms.CheckBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.ajudaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inglesRadioButton = new System.Windows.Forms.RadioButton();
            this.portuguesRadioButton = new System.Windows.Forms.RadioButton();
            this.sexoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(38, 9);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(82, 6);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(215, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(82, 32);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(215, 20);
            this.enderecoTextBox.TabIndex = 3;
            // 
            // sexoGroupBox
            // 
            this.sexoGroupBox.Controls.Add(this.femininoRadioButton);
            this.sexoGroupBox.Controls.Add(this.masculinoRadioButton);
            this.sexoGroupBox.Location = new System.Drawing.Point(15, 58);
            this.sexoGroupBox.Name = "sexoGroupBox";
            this.sexoGroupBox.Size = new System.Drawing.Size(282, 50);
            this.sexoGroupBox.TabIndex = 4;
            this.sexoGroupBox.TabStop = false;
            this.sexoGroupBox.Text = "Sexo";
            // 
            // femininoRadioButton
            // 
            this.femininoRadioButton.AutoSize = true;
            this.femininoRadioButton.Location = new System.Drawing.Point(85, 19);
            this.femininoRadioButton.Name = "femininoRadioButton";
            this.femininoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.femininoRadioButton.TabIndex = 1;
            this.femininoRadioButton.TabStop = true;
            this.femininoRadioButton.Text = "Feminino";
            this.femininoRadioButton.UseVisualStyleBackColor = true;
            // 
            // masculinoRadioButton
            // 
            this.masculinoRadioButton.AutoSize = true;
            this.masculinoRadioButton.Location = new System.Drawing.Point(6, 19);
            this.masculinoRadioButton.Name = "masculinoRadioButton";
            this.masculinoRadioButton.Size = new System.Drawing.Size(73, 17);
            this.masculinoRadioButton.TabIndex = 0;
            this.masculinoRadioButton.TabStop = true;
            this.masculinoRadioButton.Text = "&Masculino";
            this.masculinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // paisListBox
            // 
            this.paisListBox.FormattingEnabled = true;
            this.paisListBox.Items.AddRange(new object[] {
            "Brasil",
            "Argentina",
            "Chile",
            "México",
            "EUA",
            "Canadá",
            "Venezuela",
            "Bolívia",
            "Uruguai",
            "Paraguai",
            "Colômbia",
            "Peru"});
            this.paisListBox.Location = new System.Drawing.Point(303, 6);
            this.paisListBox.Name = "paisListBox";
            this.paisListBox.Size = new System.Drawing.Size(120, 134);
            this.paisListBox.TabIndex = 7;
            // 
            // estadoCivilComboBox
            // 
            this.estadoCivilComboBox.FormattingEnabled = true;
            this.estadoCivilComboBox.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viúvo"});
            this.estadoCivilComboBox.Location = new System.Drawing.Point(82, 114);
            this.estadoCivilComboBox.Name = "estadoCivilComboBox";
            this.estadoCivilComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoCivilComboBox.TabIndex = 5;
            // 
            // preferencialCheckBox
            // 
            this.preferencialCheckBox.AutoSize = true;
            this.preferencialCheckBox.Location = new System.Drawing.Point(215, 114);
            this.preferencialCheckBox.Name = "preferencialCheckBox";
            this.preferencialCheckBox.Size = new System.Drawing.Size(82, 17);
            this.preferencialCheckBox.TabIndex = 6;
            this.preferencialCheckBox.Text = "Preferencial";
            this.preferencialCheckBox.UseVisualStyleBackColor = true;
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(303, 146);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(120, 23);
            this.gravarButton.TabIndex = 8;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(303, 175);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(120, 23);
            this.limparButton.TabIndex = 9;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // ajudaLinkLabel
            // 
            this.ajudaLinkLabel.AutoSize = true;
            this.ajudaLinkLabel.Location = new System.Drawing.Point(12, 190);
            this.ajudaLinkLabel.Name = "ajudaLinkLabel";
            this.ajudaLinkLabel.Size = new System.Drawing.Size(34, 13);
            this.ajudaLinkLabel.TabIndex = 10;
            this.ajudaLinkLabel.TabStop = true;
            this.ajudaLinkLabel.Text = "Ajuda";
            this.ajudaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ajudaLinkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado civil:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inglesRadioButton);
            this.groupBox1.Controls.Add(this.portuguesRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idioma";
            // 
            // inglesRadioButton
            // 
            this.inglesRadioButton.AutoSize = true;
            this.inglesRadioButton.Location = new System.Drawing.Point(85, 19);
            this.inglesRadioButton.Name = "inglesRadioButton";
            this.inglesRadioButton.Size = new System.Drawing.Size(53, 17);
            this.inglesRadioButton.TabIndex = 1;
            this.inglesRadioButton.Tag = "";
            this.inglesRadioButton.Text = "Inglês";
            this.inglesRadioButton.UseVisualStyleBackColor = true;
            this.inglesRadioButton.CheckedChanged += new System.EventHandler(this.inglesRadioButton_CheckedChanged);
            // 
            // portuguesRadioButton
            // 
            this.portuguesRadioButton.AutoSize = true;
            this.portuguesRadioButton.Checked = true;
            this.portuguesRadioButton.Location = new System.Drawing.Point(6, 19);
            this.portuguesRadioButton.Name = "portuguesRadioButton";
            this.portuguesRadioButton.Size = new System.Drawing.Size(73, 17);
            this.portuguesRadioButton.TabIndex = 0;
            this.portuguesRadioButton.TabStop = true;
            this.portuguesRadioButton.Text = "Português";
            this.portuguesRadioButton.UseVisualStyleBackColor = true;
            this.portuguesRadioButton.CheckedChanged += new System.EventHandler(this.portuguesRadioButton_CheckedChanged);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 206);
            this.Controls.Add(this.ajudaLinkLabel);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.preferencialCheckBox);
            this.Controls.Add(this.estadoCivilComboBox);
            this.Controls.Add(this.paisListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sexoGroupBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.sexoGroupBox.ResumeLayout(false);
            this.sexoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.GroupBox sexoGroupBox;
        private System.Windows.Forms.ListBox paisListBox;
        private System.Windows.Forms.RadioButton femininoRadioButton;
        private System.Windows.Forms.RadioButton masculinoRadioButton;
        private System.Windows.Forms.ComboBox estadoCivilComboBox;
        private System.Windows.Forms.CheckBox preferencialCheckBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.LinkLabel ajudaLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton inglesRadioButton;
        private System.Windows.Forms.RadioButton portuguesRadioButton;
    }
}

