namespace Impacta.Capitulo09.GC
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
            this.destrutorButton = new System.Windows.Forms.Button();
            this.disposeButton = new System.Windows.Forms.Button();
            this.usingButton = new System.Windows.Forms.Button();
            this.gcButton = new System.Windows.Forms.Button();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // destrutorButton
            // 
            this.destrutorButton.Location = new System.Drawing.Point(12, 12);
            this.destrutorButton.Name = "destrutorButton";
            this.destrutorButton.Size = new System.Drawing.Size(75, 23);
            this.destrutorButton.TabIndex = 0;
            this.destrutorButton.Text = "Destrutor";
            this.destrutorButton.UseVisualStyleBackColor = true;
            this.destrutorButton.Click += new System.EventHandler(this.destrutorButton_Click);
            // 
            // disposeButton
            // 
            this.disposeButton.Location = new System.Drawing.Point(12, 41);
            this.disposeButton.Name = "disposeButton";
            this.disposeButton.Size = new System.Drawing.Size(75, 23);
            this.disposeButton.TabIndex = 0;
            this.disposeButton.Text = "Dispose";
            this.disposeButton.UseVisualStyleBackColor = true;
            this.disposeButton.Click += new System.EventHandler(this.disposeButton_Click);
            // 
            // usingButton
            // 
            this.usingButton.Location = new System.Drawing.Point(12, 70);
            this.usingButton.Name = "usingButton";
            this.usingButton.Size = new System.Drawing.Size(75, 23);
            this.usingButton.TabIndex = 0;
            this.usingButton.Text = "Using";
            this.usingButton.UseVisualStyleBackColor = true;
            this.usingButton.Click += new System.EventHandler(this.usingButton_Click);
            // 
            // gcButton
            // 
            this.gcButton.Location = new System.Drawing.Point(12, 99);
            this.gcButton.Name = "gcButton";
            this.gcButton.Size = new System.Drawing.Size(75, 23);
            this.gcButton.TabIndex = 0;
            this.gcButton.Text = "GC";
            this.gcButton.UseVisualStyleBackColor = true;
            this.gcButton.Click += new System.EventHandler(this.gcButton_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(93, 12);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(198, 251);
            this.resultadoListBox.TabIndex = 1;
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.gcButton);
            this.Controls.Add(this.usingButton);
            this.Controls.Add(this.disposeButton);
            this.Controls.Add(this.destrutorButton);
            this.Name = "principalForm";
            this.Text = "Capítulo 09 - Garbage Collector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button destrutorButton;
        private System.Windows.Forms.Button disposeButton;
        private System.Windows.Forms.Button usingButton;
        private System.Windows.Forms.Button gcButton;
        private System.Windows.Forms.ListBox resultadoListBox;
    }
}

