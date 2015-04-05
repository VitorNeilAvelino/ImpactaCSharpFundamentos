namespace CSharp1.Capitulo11.Veiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.veiculosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculosToolStripButton,
            this.clientesToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1107, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // veiculosToolStripButton
            // 
            this.veiculosToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("veiculosToolStripButton.Image")));
            this.veiculosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.veiculosToolStripButton.Name = "veiculosToolStripButton";
            this.veiculosToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.veiculosToolStripButton.Text = "Veículos";
            this.veiculosToolStripButton.Click += new System.EventHandler(this.veiculosToolStripButton_Click);
            // 
            // clientesToolStripButton
            // 
            this.clientesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripButton.Image")));
            this.clientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clientesToolStripButton.Name = "clientesToolStripButton";
            this.clientesToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.clientesToolStripButton.Text = "Clientes";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 581);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm";
            this.Text = "Oficina +";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton veiculosToolStripButton;
        private System.Windows.Forms.ToolStripButton clientesToolStripButton;
    }
}