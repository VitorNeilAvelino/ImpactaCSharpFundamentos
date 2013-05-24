namespace Impacta.Capitulo04.Tabuada
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
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.tabuadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(12, 12);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(268, 20);
            this.tabuadaTextBox.TabIndex = 0;
            this.tabuadaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabuadaTextBox_KeyPress);
            // 
            // tabuadaListBox
            // 
            this.tabuadaListBox.FormattingEnabled = true;
            this.tabuadaListBox.Location = new System.Drawing.Point(12, 38);
            this.tabuadaListBox.Name = "tabuadaListBox";
            this.tabuadaListBox.Size = new System.Drawing.Size(268, 329);
            this.tabuadaListBox.TabIndex = 1;
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 381);
            this.Controls.Add(this.tabuadaListBox);
            this.Controls.Add(this.tabuadaTextBox);
            this.Name = "principalForm";
            this.Text = "Capítulo 04 - Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.ListBox tabuadaListBox;
    }
}

