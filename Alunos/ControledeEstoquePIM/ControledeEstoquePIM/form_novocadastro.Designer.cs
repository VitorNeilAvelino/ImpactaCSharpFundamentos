namespace ControledeEstoquePIM
{
    partial class form_novocadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_novocadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTxt_QuantidadeProduto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxt_preco = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTxt_EntradaPoduto = new System.Windows.Forms.MaskedTextBox();
            this.Txt_DescricaoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_FornecedorProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.maskedTxt_QuantidadeProduto);
            this.panel1.Controls.Add(this.maskedTxt_preco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.maskedTxt_EntradaPoduto);
            this.panel1.Controls.Add(this.Txt_DescricaoProduto);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Txt_FornecedorProduto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(56, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 278);
            this.panel1.TabIndex = 37;
            // 
            // maskedTxt_QuantidadeProduto
            // 
            this.maskedTxt_QuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_QuantidadeProduto.Location = new System.Drawing.Point(37, 175);
            this.maskedTxt_QuantidadeProduto.Name = "maskedTxt_QuantidadeProduto";
            this.maskedTxt_QuantidadeProduto.Size = new System.Drawing.Size(130, 26);
            this.maskedTxt_QuantidadeProduto.TabIndex = 36;
            this.maskedTxt_QuantidadeProduto.ValidatingType = typeof(System.DateTime);
            this.maskedTxt_QuantidadeProduto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxt_QuantidadeProduto_MaskInputRejected);
            // 
            // maskedTxt_preco
            // 
            this.maskedTxt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_preco.Location = new System.Drawing.Point(208, 175);
            this.maskedTxt_preco.Name = "maskedTxt_preco";
            this.maskedTxt_preco.Size = new System.Drawing.Size(130, 26);
            this.maskedTxt_preco.TabIndex = 35;
            this.maskedTxt_preco.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantidade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskedTxt_EntradaPoduto
            // 
            this.maskedTxt_EntradaPoduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_EntradaPoduto.Location = new System.Drawing.Point(380, 175);
            this.maskedTxt_EntradaPoduto.Mask = "99/99/9999";
            this.maskedTxt_EntradaPoduto.Name = "maskedTxt_EntradaPoduto";
            this.maskedTxt_EntradaPoduto.Size = new System.Drawing.Size(130, 26);
            this.maskedTxt_EntradaPoduto.TabIndex = 34;
            this.maskedTxt_EntradaPoduto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTxt_EntradaPoduto.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_DescricaoProduto
            // 
            this.Txt_DescricaoProduto.Location = new System.Drawing.Point(37, 57);
            this.Txt_DescricaoProduto.Name = "Txt_DescricaoProduto";
            this.Txt_DescricaoProduto.Size = new System.Drawing.Size(473, 20);
            this.Txt_DescricaoProduto.TabIndex = 1;
            this.Txt_DescricaoProduto.TextChanged += new System.EventHandler(this.Txt_DescricaoProduto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Preço";
            // 
            // Txt_FornecedorProduto
            // 
            this.Txt_FornecedorProduto.Location = new System.Drawing.Point(37, 119);
            this.Txt_FornecedorProduto.Name = "Txt_FornecedorProduto";
            this.Txt_FornecedorProduto.Size = new System.Drawing.Size(473, 20);
            this.Txt_FornecedorProduto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Entrada do Produto";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._11292_64x64;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(436, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources.Floppy_64;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(123, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources.add2_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(280, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // form_novocadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_novocadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cadastro";
            this.Load += new System.EventHandler(this.form_novocadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_DescricaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_FornecedorProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTxt_QuantidadeProduto;
        private System.Windows.Forms.MaskedTextBox maskedTxt_preco;
        private System.Windows.Forms.MaskedTextBox maskedTxt_EntradaPoduto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}