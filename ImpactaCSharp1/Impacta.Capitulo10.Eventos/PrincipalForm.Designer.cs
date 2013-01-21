namespace Impacta.Capitulo10.Eventos
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
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pesquisaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.arquivosListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.descricaoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.pesquisaToolStripTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.novoToolStripButton.Text = "Novo";
            this.novoToolStripButton.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // pesquisaToolStripTextBox
            // 
            this.pesquisaToolStripTextBox.Name = "pesquisaToolStripTextBox";
            this.pesquisaToolStripTextBox.Size = new System.Drawing.Size(300, 25);
            this.pesquisaToolStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisaToolStripTextBox_KeyUp);
            // 
            // arquivosListBox
            // 
            this.arquivosListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arquivosListBox.FormattingEnabled = true;
            this.arquivosListBox.Location = new System.Drawing.Point(0, 25);
            this.arquivosListBox.Name = "arquivosListBox";
            this.arquivosListBox.Size = new System.Drawing.Size(616, 248);
            this.arquivosListBox.TabIndex = 1;
            this.arquivosListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.arquivosListBox_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descricaoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // descricaoToolStripStatusLabel
            // 
            this.descricaoToolStripStatusLabel.Name = "descricaoToolStripStatusLabel";
            this.descricaoToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 273);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.arquivosListBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coleção de arquivos";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripTextBox pesquisaToolStripTextBox;
        private System.Windows.Forms.ListBox arquivosListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel descricaoToolStripStatusLabel;
    }
}

