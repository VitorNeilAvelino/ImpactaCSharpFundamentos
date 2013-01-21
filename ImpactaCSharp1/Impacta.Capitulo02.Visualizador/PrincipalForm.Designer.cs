namespace Impacta.Capitulo02.Visualizador
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
            this.principalToolStrip = new System.Windows.Forms.ToolStrip();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imagemPictureBox = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.principalToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // principalToolStrip
            // 
            this.principalToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.principalToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripButton});
            this.principalToolStrip.Location = new System.Drawing.Point(0, 0);
            this.principalToolStrip.Name = "principalToolStrip";
            this.principalToolStrip.Size = new System.Drawing.Size(769, 25);
            this.principalToolStrip.TabIndex = 0;
            this.principalToolStrip.Text = "toolStrip1";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.Image = global::Impacta.Capitulo02.Visualizador.Properties.Resources.abrirIcone;
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.abrirToolStripButton.Text = "Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // imagemPictureBox
            // 
            this.imagemPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagemPictureBox.Location = new System.Drawing.Point(0, 25);
            this.imagemPictureBox.Name = "imagemPictureBox";
            this.imagemPictureBox.Size = new System.Drawing.Size(769, 443);
            this.imagemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemPictureBox.TabIndex = 1;
            this.imagemPictureBox.TabStop = false;
            this.imagemPictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imagemPictureBox_LoadCompleted);
            this.imagemPictureBox.Resize += new System.EventHandler(this.imagemPictureBox_Resize);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 468);
            this.Controls.Add(this.imagemPictureBox);
            this.Controls.Add(this.principalToolStrip);
            this.Name = "PrincipalForm";
            this.Text = "Visualizador de imagens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.principalToolStrip.ResumeLayout(false);
            this.principalToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip principalToolStrip;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.PictureBox imagemPictureBox;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

