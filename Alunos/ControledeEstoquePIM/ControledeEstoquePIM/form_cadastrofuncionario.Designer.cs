namespace ControledeEstoquePIM
{
    partial class form_cadastrofuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cadastrofuncionario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTxt_fone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxt_nasc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxt_rg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_confirmasenha = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_estado);
            this.panel2.Controls.Add(this.txt_cidade);
            this.panel2.Controls.Add(this.txt_endereco);
            this.panel2.Controls.Add(this.maskedTxt_fone);
            this.panel2.Controls.Add(this.maskedTxt_nasc);
            this.panel2.Controls.Add(this.maskedTxt_cpf);
            this.panel2.Controls.Add(this.maskedTxt_rg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_nome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(48, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 215);
            this.panel2.TabIndex = 26;
            // 
            // maskedTxt_fone
            // 
            this.maskedTxt_fone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_fone.Location = new System.Drawing.Point(520, 42);
            this.maskedTxt_fone.Mask = "(99)9999-9999";
            this.maskedTxt_fone.Name = "maskedTxt_fone";
            this.maskedTxt_fone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTxt_fone.Size = new System.Drawing.Size(121, 22);
            this.maskedTxt_fone.TabIndex = 39;
            this.maskedTxt_fone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTxt_nasc
            // 
            this.maskedTxt_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_nasc.Location = new System.Drawing.Point(528, 102);
            this.maskedTxt_nasc.Mask = "99/99/9999";
            this.maskedTxt_nasc.Name = "maskedTxt_nasc";
            this.maskedTxt_nasc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTxt_nasc.Size = new System.Drawing.Size(113, 22);
            this.maskedTxt_nasc.TabIndex = 38;
            this.maskedTxt_nasc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTxt_nasc.ValidatingType = typeof(System.DateTime);
            this.maskedTxt_nasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxt_nasc_MaskInputRejected);
            // 
            // maskedTxt_cpf
            // 
            this.maskedTxt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_cpf.Location = new System.Drawing.Point(286, 102);
            this.maskedTxt_cpf.Mask = "000.000.000 - 00";
            this.maskedTxt_cpf.Name = "maskedTxt_cpf";
            this.maskedTxt_cpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTxt_cpf.Size = new System.Drawing.Size(164, 22);
            this.maskedTxt_cpf.TabIndex = 37;
            this.maskedTxt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTxt_rg
            // 
            this.maskedTxt_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxt_rg.Location = new System.Drawing.Point(45, 102);
            this.maskedTxt_rg.Mask = "00.000.000 - 00";
            this.maskedTxt_rg.Name = "maskedTxt_rg";
            this.maskedTxt_rg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTxt_rg.Size = new System.Drawing.Size(166, 22);
            this.maskedTxt_rg.TabIndex = 36;
            this.maskedTxt_rg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(45, 42);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(403, 22);
            this.txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nasc";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(406, 66);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(287, 22);
            this.txt_codigo.TabIndex = 41;
            this.txt_codigo.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Id_Usuário";
            this.label11.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.txt_confirmasenha);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(48, 345);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 176);
            this.panel1.TabIndex = 19;
            // 
            // txt_confirmasenha
            // 
            this.txt_confirmasenha.Location = new System.Drawing.Point(410, 129);
            this.txt_confirmasenha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confirmasenha.Name = "txt_confirmasenha";
            this.txt_confirmasenha.PasswordChar = '*';
            this.txt_confirmasenha.Size = new System.Drawing.Size(283, 22);
            this.txt_confirmasenha.TabIndex = 8;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(67, 129);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(281, 22);
            this.txt_senha.TabIndex = 7;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(67, 66);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(281, 22);
            this.txt_usuario.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cadastro para Acesso ao Sistema";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Confirmar senha.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Digite login.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Digite Senha.:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_pesquisa);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(48, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 93);
            this.panel3.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Image = global::ControledeEstoquePIM.Properties.Resources._11292_64x64;
            this.button6.Location = new System.Drawing.Point(630, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 72);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Pesquisar Funcionário";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(31, 37);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(417, 22);
            this.txt_pesquisa.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._1408_64x64;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(500, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 72);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(624, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 72);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources._1353597898_Refresh;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(455, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 72);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(291, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 72);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ControledeEstoquePIM.Properties.Resources.Floppy_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(112, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 72);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(45, 174);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(163, 22);
            this.txt_endereco.TabIndex = 40;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(286, 174);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(162, 22);
            this.txt_cidade.TabIndex = 41;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(528, 172);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(113, 22);
            this.txt_estado.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Endereço";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(530, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Estado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "Cidade";
            // 
            // form_cadastrofuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_cadastrofuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.form_cadastrofuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_confirmasenha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTxt_rg;
        private System.Windows.Forms.MaskedTextBox maskedTxt_fone;
        private System.Windows.Forms.MaskedTextBox maskedTxt_nasc;
        private System.Windows.Forms.MaskedTextBox maskedTxt_cpf;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_endereco;
    }
}