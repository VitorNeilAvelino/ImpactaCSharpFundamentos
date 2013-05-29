namespace ControledeEstoquePIM
{
    partial class form_fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_fornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor.:";
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Location = new System.Drawing.Point(41, 41);
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.Size = new System.Drawing.Size(278, 20);
            this.txt_fornecedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ.:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(41, 89);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(278, 20);
            this.txt_endereco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço.:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(41, 142);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(278, 20);
            this.txt_cidade.TabIndex = 7;
            this.txt_cidade.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(399, 103);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(278, 20);
            this.txt_estado.TabIndex = 9;
            this.txt_estado.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado.:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.txt_pesquisa);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(63, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 100);
            this.panel1.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._1408_64x64;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Location = new System.Drawing.Point(444, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 72);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(95, 42);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(289, 20);
            this.txt_pesquisa.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._11292_64x64;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(601, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 72);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Digite Fornecedor.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "CEP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.txt_cep);
            this.panel2.Controls.Add(this.txt_telefone);
            this.panel2.Controls.Add(this.txt_cnpj);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_fornecedor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_endereco);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_cidade);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_estado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(63, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 257);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(399, 168);
            this.txt_cep.Mask = "00000 - 000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(277, 20);
            this.txt_cep.TabIndex = 24;
            this.txt_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(41, 205);
            this.txt_telefone.Mask = "(00) 0000 - 0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(278, 20);
            this.txt_telefone.TabIndex = 23;
            this.txt_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(398, 52);
            this.txt_cnpj.Mask = "00.000.000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(278, 20);
            this.txt_cnpj.TabIndex = 22;
            this.txt_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(792, 468);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(39, 13);
            this.codigo.TabIndex = 21;
            this.codigo.Text = "codigo";
            this.codigo.Visible = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(791, 487);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(44, 20);
            this.txt_codigo.TabIndex = 20;
            this.txt_codigo.Visible = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(624, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 72);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._1353597898_Refresh;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(461, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 72);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(296, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 72);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(136, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 72);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.form_fornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
    }
}