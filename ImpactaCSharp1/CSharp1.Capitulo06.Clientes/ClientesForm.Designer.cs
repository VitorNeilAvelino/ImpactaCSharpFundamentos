namespace CSharp1.Capitulo06.Clientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.rendaTextBox = new System.Windows.Forms.TextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.clientesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.listarClientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientesErrorProvider)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Renda:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(82, 30);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(266, 20);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.Tag = "*";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(82, 60);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(266, 20);
            this.enderecoTextBox.TabIndex = 3;
            this.enderecoTextBox.Tag = "*";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(82, 185);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(266, 20);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.Tag = "*EMAIL";
            // 
            // rendaTextBox
            // 
            this.rendaTextBox.Location = new System.Drawing.Point(82, 215);
            this.rendaTextBox.Name = "rendaTextBox";
            this.rendaTextBox.Size = new System.Drawing.Size(266, 20);
            this.rendaTextBox.TabIndex = 11;
            this.rendaTextBox.Tag = "*Decimal";
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(382, 28);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 12;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.limparButton.Location = new System.Drawing.Point(382, 54);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 13;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // clientesErrorProvider
            // 
            this.clientesErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.clientesErrorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPF:";
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(82, 155);
            this.cpfMaskedTextBox.Mask = "000\\.000\\.000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(266, 20);
            this.cpfMaskedTextBox.TabIndex = 7;
            this.cpfMaskedTextBox.Tag = "*CPF";
            this.cpfMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nascimentoDateTimePicker
            // 
            this.nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nascimentoDateTimePicker.Location = new System.Drawing.Point(84, 87);
            this.nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            this.nascimentoDateTimePicker.ShowCheckBox = true;
            this.nascimentoDateTimePicker.Size = new System.Drawing.Size(264, 20);
            this.nascimentoDateTimePicker.TabIndex = 14;
            this.nascimentoDateTimePicker.Tag = "*DateTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nascimento:";
            // 
            // nascimentoMaskedTextBox
            // 
            this.nascimentoMaskedTextBox.Location = new System.Drawing.Point(84, 118);
            this.nascimentoMaskedTextBox.Mask = "00/00/0000";
            this.nascimentoMaskedTextBox.Name = "nascimentoMaskedTextBox";
            this.nascimentoMaskedTextBox.Size = new System.Drawing.Size(266, 20);
            this.nascimentoMaskedTextBox.TabIndex = 7;
            this.nascimentoMaskedTextBox.Tag = "*DATETIME";
            this.nascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(95, 25);
            this.toolStrip2.TabIndex = 15;
            // 
            // listarClientesToolStripButton
            // 
            this.listarClientesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("listarClientesToolStripButton.Image")));
            this.listarClientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listarClientesToolStripButton.Name = "listarClientesToolStripButton";
            this.listarClientesToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.listarClientesToolStripButton.Text = "&Pesquisar";
            this.listarClientesToolStripButton.Click += new System.EventHandler(this.listarClientesToolStripButton_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.limparButton;
            this.ClientSize = new System.Drawing.Size(765, 476);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.nascimentoDateTimePicker);
            this.Controls.Add(this.nascimentoMaskedTextBox);
            this.Controls.Add(this.cpfMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rendaTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientesForm_KeyPress);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.nomeTextBox, 0);
            this.Controls.SetChildIndex(this.enderecoTextBox, 0);
            this.Controls.SetChildIndex(this.emailTextBox, 0);
            this.Controls.SetChildIndex(this.rendaTextBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cpfMaskedTextBox, 0);
            this.Controls.SetChildIndex(this.nascimentoMaskedTextBox, 0);
            this.Controls.SetChildIndex(this.nascimentoDateTimePicker, 0);
            this.Controls.SetChildIndex(this.limparButton, 0);
            this.Controls.SetChildIndex(this.gravarButton, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.toolStrip2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.clientesErrorProvider)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox rendaTextBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.ErrorProvider clientesErrorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.DateTimePicker nascimentoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox nascimentoMaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton listarClientesToolStripButton;
    }
}

