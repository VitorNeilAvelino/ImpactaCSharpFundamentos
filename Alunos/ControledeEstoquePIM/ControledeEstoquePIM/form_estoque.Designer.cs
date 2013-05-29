namespace ControledeEstoquePIM
{
    partial class form_atualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_atualizar));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTxt_preco = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxt_EntradaPoduto = new System.Windows.Forms.MaskedTextBox();
            this.txt_FornecedorProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_DescricaoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_CodigoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // Txt_Pesquisa
            // 
            this.Txt_Pesquisa.Location = new System.Drawing.Point(29, 53);
            this.Txt_Pesquisa.Name = "Txt_Pesquisa";
            this.Txt_Pesquisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Pesquisa.Size = new System.Drawing.Size(309, 20);
            this.Txt_Pesquisa.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Txt_Pesquisa);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(95, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 100);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = global::ControledeEstoquePIM.Properties.Resources._11292_64x64;
            this.button2.Location = new System.Drawing.Point(577, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 76);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources.add2_64;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(479, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 76);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._1408_64x64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(379, 10);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(76, 76);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Preço";
            // 
            // maskedTxt_preco
            // 
            this.maskedTxt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_preco.Location = new System.Drawing.Point(248, 239);
            this.maskedTxt_preco.Name = "maskedTxt_preco";
            this.maskedTxt_preco.Size = new System.Drawing.Size(130, 26);
            this.maskedTxt_preco.TabIndex = 8;
            this.maskedTxt_preco.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTxt_EntradaPoduto
            // 
            this.maskedTxt_EntradaPoduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_EntradaPoduto.Location = new System.Drawing.Point(429, 239);
            this.maskedTxt_EntradaPoduto.Mask = "  00/00/0000";
            this.maskedTxt_EntradaPoduto.Name = "maskedTxt_EntradaPoduto";
            this.maskedTxt_EntradaPoduto.Size = new System.Drawing.Size(130, 26);
            this.maskedTxt_EntradaPoduto.TabIndex = 7;
            this.maskedTxt_EntradaPoduto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_FornecedorProduto
            // 
            this.txt_FornecedorProduto.Location = new System.Drawing.Point(79, 176);
            this.txt_FornecedorProduto.Name = "txt_FornecedorProduto";
            this.txt_FornecedorProduto.Size = new System.Drawing.Size(480, 22);
            this.txt_FornecedorProduto.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Entrada do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantidade";
            // 
            // Txt_DescricaoProduto
            // 
            this.Txt_DescricaoProduto.Location = new System.Drawing.Point(79, 115);
            this.Txt_DescricaoProduto.Name = "Txt_DescricaoProduto";
            this.Txt_DescricaoProduto.Size = new System.Drawing.Size(480, 22);
            this.Txt_DescricaoProduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descrição";
            // 
            // Txt_CodigoProduto
            // 
            this.Txt_CodigoProduto.Enabled = false;
            this.Txt_CodigoProduto.Location = new System.Drawing.Point(79, 53);
            this.Txt_CodigoProduto.Name = "Txt_CodigoProduto";
            this.Txt_CodigoProduto.Size = new System.Drawing.Size(480, 22);
            this.Txt_CodigoProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Código do Produto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.Txt_QuantidadeProduto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Txt_CodigoProduto);
            this.panel2.Controls.Add(this.maskedTxt_preco);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.maskedTxt_EntradaPoduto);
            this.panel2.Controls.Add(this.Txt_DescricaoProduto);
            this.panel2.Controls.Add(this.txt_FornecedorProduto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(124, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 342);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Txt_QuantidadeProduto
            // 
            this.Txt_QuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_QuantidadeProduto.Location = new System.Drawing.Point(76, 239);
            this.Txt_QuantidadeProduto.Name = "Txt_QuantidadeProduto";
            this.Txt_QuantidadeProduto.Size = new System.Drawing.Size(135, 26);
            this.Txt_QuantidadeProduto.TabIndex = 45;
            // 
            // form_atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_atualizar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.form_estoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Pesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_DescricaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_CodigoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FornecedorProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox maskedTxt_preco;
        private System.Windows.Forms.MaskedTextBox maskedTxt_EntradaPoduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox Txt_QuantidadeProduto;

    }
}