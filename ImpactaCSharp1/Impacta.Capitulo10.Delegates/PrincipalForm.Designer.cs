namespace Impacta.Capitulo10.Delegates
{
    partial class PrincipalForm
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
            this.delegateButton = new System.Windows.Forms.Button();
            this.anonimosButton = new System.Windows.Forms.Button();
            this.lambdaButton = new System.Windows.Forms.Button();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // delegateButton
            // 
            this.delegateButton.Location = new System.Drawing.Point(13, 13);
            this.delegateButton.Name = "delegateButton";
            this.delegateButton.Size = new System.Drawing.Size(75, 23);
            this.delegateButton.TabIndex = 0;
            this.delegateButton.Text = "Delegate";
            this.delegateButton.UseVisualStyleBackColor = true;
            this.delegateButton.Click += new System.EventHandler(this.delegateButton_Click);
            // 
            // anonimosButton
            // 
            this.anonimosButton.Location = new System.Drawing.Point(13, 42);
            this.anonimosButton.Name = "anonimosButton";
            this.anonimosButton.Size = new System.Drawing.Size(75, 23);
            this.anonimosButton.TabIndex = 0;
            this.anonimosButton.Text = "Anônimos";
            this.anonimosButton.UseVisualStyleBackColor = true;
            this.anonimosButton.Click += new System.EventHandler(this.anonimosButton_Click);
            // 
            // lambdaButton
            // 
            this.lambdaButton.Location = new System.Drawing.Point(13, 71);
            this.lambdaButton.Name = "lambdaButton";
            this.lambdaButton.Size = new System.Drawing.Size(75, 23);
            this.lambdaButton.TabIndex = 0;
            this.lambdaButton.Text = "Lâmbda";
            this.lambdaButton.UseVisualStyleBackColor = true;
            this.lambdaButton.Click += new System.EventHandler(this.lambdaButton_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(95, 13);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(177, 238);
            this.resultadoListBox.TabIndex = 1;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.lambdaButton);
            this.Controls.Add(this.anonimosButton);
            this.Controls.Add(this.delegateButton);
            this.Name = "PrincipalForm";
            this.Text = "Delegates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delegateButton;
        private System.Windows.Forms.Button anonimosButton;
        private System.Windows.Forms.Button lambdaButton;
        private System.Windows.Forms.ListBox resultadoListBox;
    }
}

