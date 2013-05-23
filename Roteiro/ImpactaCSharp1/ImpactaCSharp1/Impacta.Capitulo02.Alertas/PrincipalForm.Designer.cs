namespace Impacta.Capitulo02.Lembretes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.lembrete1TextBox = new System.Windows.Forms.TextBox();
            this.lembrete1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lembrete2TextBox = new System.Windows.Forms.TextBox();
            this.lembrete2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lembrete3TextBox = new System.Windows.Forms.TextBox();
            this.lembrete3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.principalTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lembrete1TextBox
            // 
            this.lembrete1TextBox.Location = new System.Drawing.Point(95, 12);
            this.lembrete1TextBox.Name = "lembrete1TextBox";
            this.lembrete1TextBox.Size = new System.Drawing.Size(300, 20);
            this.lembrete1TextBox.TabIndex = 1;
            // 
            // lembrete1DateTimePicker
            // 
            this.lembrete1DateTimePicker.CustomFormat = "HH:mm";
            this.lembrete1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lembrete1DateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.lembrete1DateTimePicker.Name = "lembrete1DateTimePicker";
            this.lembrete1DateTimePicker.ShowCheckBox = true;
            this.lembrete1DateTimePicker.ShowUpDown = true;
            this.lembrete1DateTimePicker.Size = new System.Drawing.Size(77, 20);
            this.lembrete1DateTimePicker.TabIndex = 0;
            this.lembrete1DateTimePicker.Value = new System.DateTime(2011, 3, 12, 0, 0, 0, 0);
            // 
            // lembrete2TextBox
            // 
            this.lembrete2TextBox.Location = new System.Drawing.Point(95, 38);
            this.lembrete2TextBox.Name = "lembrete2TextBox";
            this.lembrete2TextBox.Size = new System.Drawing.Size(300, 20);
            this.lembrete2TextBox.TabIndex = 3;
            // 
            // lembrete2DateTimePicker
            // 
            this.lembrete2DateTimePicker.CustomFormat = "HH:mm";
            this.lembrete2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lembrete2DateTimePicker.Location = new System.Drawing.Point(12, 38);
            this.lembrete2DateTimePicker.Name = "lembrete2DateTimePicker";
            this.lembrete2DateTimePicker.ShowCheckBox = true;
            this.lembrete2DateTimePicker.ShowUpDown = true;
            this.lembrete2DateTimePicker.Size = new System.Drawing.Size(77, 20);
            this.lembrete2DateTimePicker.TabIndex = 2;
            this.lembrete2DateTimePicker.Value = new System.DateTime(2011, 2, 28, 0, 0, 0, 0);
            // 
            // lembrete3TextBox
            // 
            this.lembrete3TextBox.Location = new System.Drawing.Point(95, 64);
            this.lembrete3TextBox.Name = "lembrete3TextBox";
            this.lembrete3TextBox.Size = new System.Drawing.Size(300, 20);
            this.lembrete3TextBox.TabIndex = 5;
            // 
            // lembrete3DateTimePicker
            // 
            this.lembrete3DateTimePicker.CustomFormat = "HH:mm";
            this.lembrete3DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lembrete3DateTimePicker.Location = new System.Drawing.Point(12, 64);
            this.lembrete3DateTimePicker.Name = "lembrete3DateTimePicker";
            this.lembrete3DateTimePicker.ShowCheckBox = true;
            this.lembrete3DateTimePicker.ShowUpDown = true;
            this.lembrete3DateTimePicker.Size = new System.Drawing.Size(77, 20);
            this.lembrete3DateTimePicker.TabIndex = 4;
            this.lembrete3DateTimePicker.Value = new System.DateTime(2011, 2, 28, 0, 0, 0, 0);
            // 
            // principalTimer
            // 
            this.principalTimer.Enabled = true;
            this.principalTimer.Interval = 1000;
            this.principalTimer.Tick += new System.EventHandler(this.principalTimer_Tick);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 94);
            this.Controls.Add(this.lembrete3DateTimePicker);
            this.Controls.Add(this.lembrete2DateTimePicker);
            this.Controls.Add(this.lembrete1DateTimePicker);
            this.Controls.Add(this.lembrete3TextBox);
            this.Controls.Add(this.lembrete2TextBox);
            this.Controls.Add(this.lembrete1TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lembretes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lembrete1TextBox;
        private System.Windows.Forms.DateTimePicker lembrete1DateTimePicker;
        private System.Windows.Forms.TextBox lembrete2TextBox;
        private System.Windows.Forms.DateTimePicker lembrete2DateTimePicker;
        private System.Windows.Forms.TextBox lembrete3TextBox;
        private System.Windows.Forms.DateTimePicker lembrete3DateTimePicker;
        private System.Windows.Forms.Timer principalTimer;
    }
}