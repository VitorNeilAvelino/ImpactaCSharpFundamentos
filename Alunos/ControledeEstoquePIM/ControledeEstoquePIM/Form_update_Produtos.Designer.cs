namespace ControledeEstoquePIM
{
    partial class Form_update_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_update_Produtos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_CodigoProduto = new System.Windows.Forms.TextBox();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.maskedTxt_preco = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTxt_EntradaPoduto = new System.Windows.Forms.MaskedTextBox();
            this.Txt_DescricaoProduto = new System.Windows.Forms.TextBox();
            this.txt_FornecedorProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_inserir = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Txt_Pesquisa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(108, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 100);
            this.panel1.TabIndex = 32;
            // 
            // Txt_Pesquisa
            // 
            this.Txt_Pesquisa.Location = new System.Drawing.Point(29, 53);
            this.Txt_Pesquisa.Name = "Txt_Pesquisa";
            this.Txt_Pesquisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Pesquisa.Size = new System.Drawing.Size(309, 20);
            this.Txt_Pesquisa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite nome do Produto";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = global::ControledeEstoquePIM.Properties.Resources._11292_64x64;
            this.button2.Location = new System.Drawing.Point(555, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 76);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._1408_64x64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(413, 10);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(101, 76);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Image = global::ControledeEstoquePIM.Properties.Resources.delete64;
            this.button7.Location = new System.Drawing.Point(581, 458);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 76);
            this.button7.TabIndex = 50;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources.add2_64;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(400, 458);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 76);
            this.button5.TabIndex = 47;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.txt_inserir);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Txt_QuantidadeProduto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_test);
            this.panel3.Controls.Add(this.maskedTxt_preco);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.maskedTxt_EntradaPoduto);
            this.panel3.Controls.Add(this.Txt_DescricaoProduto);
            this.panel3.Controls.Add(this.txt_FornecedorProduto);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(108, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 299);
            this.panel3.TabIndex = 48;
            // 
            // Txt_QuantidadeProduto
            // 
            this.Txt_QuantidadeProduto.Enabled = false;
            this.Txt_QuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_QuantidadeProduto.Location = new System.Drawing.Point(90, 169);
            this.Txt_QuantidadeProduto.Name = "Txt_QuantidadeProduto";
            this.Txt_QuantidadeProduto.Size = new System.Drawing.Size(130, 26);
            this.Txt_QuantidadeProduto.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Quantidade de Retirada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Código do Produto";
            this.label4.Visible = false;
            // 
            // Txt_CodigoProduto
            // 
            this.Txt_CodigoProduto.Enabled = false;
            this.Txt_CodigoProduto.Location = new System.Drawing.Point(761, 485);
            this.Txt_CodigoProduto.Name = "Txt_CodigoProduto";
            this.Txt_CodigoProduto.Size = new System.Drawing.Size(111, 20);
            this.Txt_CodigoProduto.TabIndex = 2;
            this.Txt_CodigoProduto.Visible = false;
            // 
            // txt_test
            // 
            this.txt_test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_test.Location = new System.Drawing.Point(86, 243);
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(130, 26);
            this.txt_test.TabIndex = 42;
            // 
            // maskedTxt_preco
            // 
            this.maskedTxt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_preco.Location = new System.Drawing.Point(262, 169);
            this.maskedTxt_preco.Name = "maskedTxt_preco";
            this.maskedTxt_preco.Size = new System.Drawing.Size(130, 26);
            this.maskedTxt_preco.TabIndex = 8;
            this.maskedTxt_preco.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descrição";
            // 
            // maskedTxt_EntradaPoduto
            // 
            this.maskedTxt_EntradaPoduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_EntradaPoduto.Location = new System.Drawing.Point(443, 169);
            this.maskedTxt_EntradaPoduto.Mask = "  00/00/0000";
            this.maskedTxt_EntradaPoduto.Name = "maskedTxt_EntradaPoduto";
            this.maskedTxt_EntradaPoduto.Size = new System.Drawing.Size(130, 26);
            this.maskedTxt_EntradaPoduto.TabIndex = 7;
            this.maskedTxt_EntradaPoduto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTxt_EntradaPoduto.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_DescricaoProduto
            // 
            this.Txt_DescricaoProduto.Location = new System.Drawing.Point(93, 45);
            this.Txt_DescricaoProduto.Name = "Txt_DescricaoProduto";
            this.Txt_DescricaoProduto.Size = new System.Drawing.Size(480, 22);
            this.Txt_DescricaoProduto.TabIndex = 3;
            // 
            // txt_FornecedorProduto
            // 
            this.txt_FornecedorProduto.Location = new System.Drawing.Point(93, 106);
            this.txt_FornecedorProduto.Name = "txt_FornecedorProduto";
            this.txt_FornecedorProduto.Size = new System.Drawing.Size(480, 22);
            this.txt_FornecedorProduto.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fornecedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Entrada do Produto";
            // 
            // button8
            // 
            this.button8.Image = global::ControledeEstoquePIM.Properties.Resources._1353597898_Refresh;
            this.button8.Location = new System.Drawing.Point(218, 458);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 76);
            this.button8.TabIndex = 49;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Quantidade a ser Inserida";
            // 
            // txt_inserir
            // 
            this.txt_inserir.Location = new System.Drawing.Point(425, 243);
            this.txt_inserir.Name = "txt_inserir";
            this.txt_inserir.Size = new System.Drawing.Size(157, 22);
            this.txt_inserir.TabIndex = 47;
            // 
            // Form_update_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Txt_CodigoProduto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_update_Produtos";
            this.Text = "Atualizar Produtos";
            this.Load += new System.EventHandler(this.Form_update_Produtos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_Pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox Txt_QuantidadeProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CodigoProduto;
        private System.Windows.Forms.TextBox txt_test;
        private System.Windows.Forms.MaskedTextBox maskedTxt_preco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTxt_EntradaPoduto;
        private System.Windows.Forms.TextBox Txt_DescricaoProduto;
        private System.Windows.Forms.TextBox txt_FornecedorProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt_inserir;
        private System.Windows.Forms.Label label2;

    }
}