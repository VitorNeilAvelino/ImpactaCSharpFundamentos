namespace Impacta.Capitulo07.Consumo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.litrosTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.consumoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Litros";
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(50, 6);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmTextBox.TabIndex = 1;
            // 
            // litrosTextBox
            // 
            this.litrosTextBox.Location = new System.Drawing.Point(50, 37);
            this.litrosTextBox.Name = "litrosTextBox";
            this.litrosTextBox.Size = new System.Drawing.Size(100, 20);
            this.litrosTextBox.TabIndex = 3;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(15, 63);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(325, 23);
            this.calcularButton.TabIndex = 4;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // consumoLabel
            // 
            this.consumoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumoLabel.Location = new System.Drawing.Point(156, 9);
            this.consumoLabel.Name = "consumoLabel";
            this.consumoLabel.Size = new System.Drawing.Size(184, 48);
            this.consumoLabel.TabIndex = 5;
            this.consumoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 92);
            this.Controls.Add(this.consumoLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.litrosTextBox);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "principalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo do consumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox litrosTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label consumoLabel;
    }
}

