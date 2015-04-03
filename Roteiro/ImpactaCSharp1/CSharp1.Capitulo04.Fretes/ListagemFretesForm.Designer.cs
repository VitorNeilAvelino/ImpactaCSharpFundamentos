namespace CSharp1.Capitulo04.Fretes
{
    partial class ListagemFretesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemFretesForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nomeClienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pesquisarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fretesListBox = new System.Windows.Forms.ListBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeClienteToolStripTextBox,
            this.toolStripSeparator1,
            this.pesquisarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // nomeClienteToolStripTextBox
            // 
            this.nomeClienteToolStripTextBox.Name = "nomeClienteToolStripTextBox";
            this.nomeClienteToolStripTextBox.Size = new System.Drawing.Size(300, 25);
            this.nomeClienteToolStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nomeClienteToolStripTextBox_KeyUp);
            // 
            // pesquisarToolStripButton
            // 
            this.pesquisarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pesquisarToolStripButton.Image")));
            this.pesquisarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pesquisarToolStripButton.Name = "pesquisarToolStripButton";
            this.pesquisarToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.pesquisarToolStripButton.Text = "Pesquisar";
            this.pesquisarToolStripButton.Click += new System.EventHandler(this.pesquisarToolStripButton_Click);
            // 
            // fretesListBox
            // 
            this.fretesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fretesListBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fretesListBox.FormattingEnabled = true;
            this.fretesListBox.HorizontalScrollbar = true;
            this.fretesListBox.ItemHeight = 15;
            this.fretesListBox.Location = new System.Drawing.Point(0, 25);
            this.fretesListBox.Name = "fretesListBox";
            this.fretesListBox.Size = new System.Drawing.Size(782, 368);
            this.fretesListBox.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ListagemFretesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 393);
            this.Controls.Add(this.fretesListBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListagemFretesForm";
            this.Text = "Fretes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox nomeClienteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pesquisarToolStripButton;
        private System.Windows.Forms.ListBox fretesListBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}