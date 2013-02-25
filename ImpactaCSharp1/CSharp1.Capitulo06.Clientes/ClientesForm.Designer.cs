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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.rendaTextBox = new System.Windows.Forms.TextBox();
            this.nascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gravarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N&ascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "E&mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "&Renda:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.Location = new System.Drawing.Point(84, 48);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(423, 20);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.Tag = "*";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enderecoTextBox.Location = new System.Drawing.Point(84, 93);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(423, 20);
            this.enderecoTextBox.TabIndex = 3;
            this.enderecoTextBox.Tag = "*";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(84, 240);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(423, 20);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.Tag = "*EMAIL";
            // 
            // rendaTextBox
            // 
            this.rendaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rendaTextBox.Location = new System.Drawing.Point(84, 289);
            this.rendaTextBox.Name = "rendaTextBox";
            this.rendaTextBox.Size = new System.Drawing.Size(423, 20);
            this.rendaTextBox.TabIndex = 11;
            this.rendaTextBox.Tag = "*DECIMAL";
            // 
            // nascimentoMaskedTextBox
            // 
            this.nascimentoMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nascimentoMaskedTextBox.Location = new System.Drawing.Point(84, 142);
            this.nascimentoMaskedTextBox.Mask = "00/00/0000";
            this.nascimentoMaskedTextBox.Name = "nascimentoMaskedTextBox";
            this.nascimentoMaskedTextBox.Size = new System.Drawing.Size(423, 20);
            this.nascimentoMaskedTextBox.TabIndex = 5;
            this.nascimentoMaskedTextBox.Tag = "*DATETIME";
            this.nascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(84, 191);
            this.cpfMaskedTextBox.Mask = "000\\.000\\.000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(423, 20);
            this.cpfMaskedTextBox.TabIndex = 7;
            this.cpfMaskedTextBox.Tag = "*CPF";
            // 
            // clientesErrorProvider
            // 
            this.clientesErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.clientesErrorProvider.ContainerControl = this;
            // 
            // gravarButton
            // 
            this.gravarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gravarButton.Location = new System.Drawing.Point(432, 315);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 12;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limparButton.Location = new System.Drawing.Point(432, 344);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 13;
            this.limparButton.Text = "&Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 403);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.cpfMaskedTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nascimentoMaskedTextBox);
            this.Controls.Add(this.rendaTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.enderecoTextBox, 0);
            this.Controls.SetChildIndex(this.emailTextBox, 0);
            this.Controls.SetChildIndex(this.rendaTextBox, 0);
            this.Controls.SetChildIndex(this.nascimentoMaskedTextBox, 0);
            this.Controls.SetChildIndex(this.nomeTextBox, 0);
            this.Controls.SetChildIndex(this.cpfMaskedTextBox, 0);
            this.Controls.SetChildIndex(this.limparButton, 0);
            this.Controls.SetChildIndex(this.gravarButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.clientesErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox rendaTextBox;
        private System.Windows.Forms.MaskedTextBox nascimentoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.ErrorProvider clientesErrorProvider;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button gravarButton;
    }
}

