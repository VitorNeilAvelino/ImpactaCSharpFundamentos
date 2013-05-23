namespace Impacta.Capitulo03.Medias
{
    partial class principalForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.materiaComboBox = new System.Windows.Forms.ComboBox();
            this.nota2TextBox = new System.Windows.Forms.TextBox();
            this.nota3TextBox = new System.Windows.Forms.TextBox();
            this.nota4TextBox = new System.Windows.Forms.TextBox();
            this.medialLabel = new System.Windows.Forms.Label();
            this.gravarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.situacaoAlunoLabel = new System.Windows.Forms.Label();
            this.principalErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nota1TextBox = new System.Windows.Forms.TextBox();
            this.alunoTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.principalErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matéria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Média:";
            // 
            // materiaComboBox
            // 
            this.materiaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materiaComboBox.FormattingEnabled = true;
            this.materiaComboBox.Items.AddRange(new object[] {
            "Física",
            "Inglês",
            "Matemática",
            "Português",
            "Química"});
            this.materiaComboBox.Location = new System.Drawing.Point(71, 42);
            this.materiaComboBox.Name = "materiaComboBox";
            this.materiaComboBox.Size = new System.Drawing.Size(121, 21);
            this.materiaComboBox.Sorted = true;
            this.materiaComboBox.TabIndex = 3;
            this.materiaComboBox.Tag = "*";
            // 
            // nota2TextBox
            // 
            this.nota2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota2TextBox.Location = new System.Drawing.Point(71, 112);
            this.nota2TextBox.Name = "nota2TextBox";
            this.nota2TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota2TextBox.TabIndex = 7;
            this.nota2TextBox.Tag = "*Nota";
            // 
            // nota3TextBox
            // 
            this.nota3TextBox.Location = new System.Drawing.Point(71, 147);
            this.nota3TextBox.Name = "nota3TextBox";
            this.nota3TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota3TextBox.TabIndex = 9;
            this.nota3TextBox.Tag = "*Nota";
            // 
            // nota4TextBox
            // 
            this.nota4TextBox.Location = new System.Drawing.Point(71, 182);
            this.nota4TextBox.Name = "nota4TextBox";
            this.nota4TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota4TextBox.TabIndex = 11;
            this.nota4TextBox.Tag = "*Nota";
            // 
            // medialLabel
            // 
            this.medialLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medialLabel.Location = new System.Drawing.Point(71, 213);
            this.medialLabel.Name = "medialLabel";
            this.medialLabel.Size = new System.Drawing.Size(121, 23);
            this.medialLabel.TabIndex = 13;
            this.medialLabel.Text = "00,0";
            this.medialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(350, 4);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 14;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.CausesValidation = false;
            this.sairButton.Location = new System.Drawing.Point(350, 33);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 15;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // situacaoAlunoLabel
            // 
            this.situacaoAlunoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.situacaoAlunoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoAlunoLabel.Location = new System.Drawing.Point(198, 213);
            this.situacaoAlunoLabel.Name = "situacaoAlunoLabel";
            this.situacaoAlunoLabel.Size = new System.Drawing.Size(121, 23);
            this.situacaoAlunoLabel.TabIndex = 13;
            this.situacaoAlunoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // principalErrorProvider
            // 
            this.principalErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.principalErrorProvider.ContainerControl = this;
            // 
            // nota1TextBox
            // 
            this.nota1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota1TextBox.Location = new System.Drawing.Point(71, 77);
            this.nota1TextBox.Name = "nota1TextBox";
            this.nota1TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota1TextBox.TabIndex = 7;
            this.nota1TextBox.Tag = "*Nota";
            this.nota1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nota1TextBox_Validating);
            // 
            // alunoTextBox
            // 
            this.alunoTextBox.Location = new System.Drawing.Point(71, 7);
            this.alunoTextBox.Mask = ">AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.alunoTextBox.Name = "alunoTextBox";
            this.alunoTextBox.Size = new System.Drawing.Size(273, 20);
            this.alunoTextBox.TabIndex = 16;
            this.alunoTextBox.Tag = "*";
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 256);
            this.Controls.Add(this.alunoTextBox);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.situacaoAlunoLabel);
            this.Controls.Add(this.medialLabel);
            this.Controls.Add(this.nota4TextBox);
            this.Controls.Add(this.nota3TextBox);
            this.Controls.Add(this.nota1TextBox);
            this.Controls.Add(this.nota2TextBox);
            this.Controls.Add(this.materiaComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "principalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capítulo 03 - Médias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.principalForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.principalErrorProvider)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox materiaComboBox;
        private System.Windows.Forms.TextBox nota2TextBox;
        private System.Windows.Forms.TextBox nota3TextBox;
        private System.Windows.Forms.TextBox nota4TextBox;
        private System.Windows.Forms.Label medialLabel;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Label situacaoAlunoLabel;
        private System.Windows.Forms.ErrorProvider principalErrorProvider;
        private System.Windows.Forms.TextBox nota1TextBox;
        private System.Windows.Forms.MaskedTextBox alunoTextBox;
    }
}

