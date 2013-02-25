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
            this.clientesToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clientesToolStripSplitButton
            // 
            this.clientesToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem});
            this.clientesToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripSplitButton.Image")));
            this.clientesToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clientesToolStripSplitButton.Name = "clientesToolStripSplitButton";
            this.clientesToolStripSplitButton.Size = new System.Drawing.Size(81, 22);
            this.clientesToolStripSplitButton.Text = "&Clientes";
            this.clientesToolStripSplitButton.ButtonClick += new System.EventHandler(this.clientesToolStripSplitButton_ButtonClick);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoClienteToolStripMenuItem.Text = "&Novo";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 487);
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
        private System.Windows.Forms.ToolStripSplitButton clientesToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
    }
}