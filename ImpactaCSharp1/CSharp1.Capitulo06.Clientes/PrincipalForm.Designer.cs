namespace CSharp1.Capitulo06.Clientes
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
            this.listagemClientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemClientesToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // listagemClientesToolStripButton
            // 
            this.listagemClientesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("listagemClientesToolStripButton.Image")));
            this.listagemClientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listagemClientesToolStripButton.Name = "listagemClientesToolStripButton";
            this.listagemClientesToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.listagemClientesToolStripButton.Text = "&Clientes";
            this.listagemClientesToolStripButton.Click += new System.EventHandler(this.listagemClientesToolStripButton_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 500);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton listagemClientesToolStripButton;
    }
}