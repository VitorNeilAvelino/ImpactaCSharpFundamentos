namespace Impacta.Capitulo03.Operadores
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ternariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.precedenciaAssociatividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operadoresToolStripMenuItem
            // 
            this.operadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmeticosToolStripMenuItem,
            this.ternariosToolStripMenuItem,
            this.precedenciaAssociatividadeToolStripMenuItem});
            this.operadoresToolStripMenuItem.Name = "operadoresToolStripMenuItem";
            this.operadoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.operadoresToolStripMenuItem.Text = "Operadores";
            // 
            // aritmeticosToolStripMenuItem
            // 
            this.aritmeticosToolStripMenuItem.Name = "aritmeticosToolStripMenuItem";
            this.aritmeticosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.aritmeticosToolStripMenuItem.Text = "Aritméticos";
            this.aritmeticosToolStripMenuItem.Click += new System.EventHandler(this.aritmeticosToolStripMenuItem_Click);
            // 
            // ternariosToolStripMenuItem
            // 
            this.ternariosToolStripMenuItem.Name = "ternariosToolStripMenuItem";
            this.ternariosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ternariosToolStripMenuItem.Text = "Ternários";
            this.ternariosToolStripMenuItem.Click += new System.EventHandler(this.ternariosToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(0, 24);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(366, 293);
            this.resultadoListBox.TabIndex = 1;
            // 
            // precedenciaAssociatividadeToolStripMenuItem
            // 
            this.precedenciaAssociatividadeToolStripMenuItem.Name = "precedenciaAssociatividadeToolStripMenuItem";
            this.precedenciaAssociatividadeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.precedenciaAssociatividadeToolStripMenuItem.Text = "&Precedência/Associatividade";
            this.precedenciaAssociatividadeToolStripMenuItem.Click += new System.EventHandler(this.precedenciaAssociatividadeToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 317);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Variáveis e operadores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticosToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.ToolStripMenuItem ternariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precedenciaAssociatividadeToolStripMenuItem;
    }
}

