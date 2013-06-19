namespace Impacta.Plantao.WindowsForms
{
    partial class DataGridViewForm
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
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.PreferencialColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NomeClienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PreferencialColumn,
            this.NomeClienteColumn});
            this.clientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(591, 410);
            this.clientesDataGridView.TabIndex = 0;
            // 
            // PreferencialColumn
            // 
            this.PreferencialColumn.DataPropertyName = "Preferencial";
            this.PreferencialColumn.HeaderText = "Preferencial";
            this.PreferencialColumn.Name = "PreferencialColumn";
            // 
            // NomeClienteColumn
            // 
            this.NomeClienteColumn.DataPropertyName = "Nome";
            this.NomeClienteColumn.HeaderText = "Nome";
            this.NomeClienteColumn.Name = "NomeClienteColumn";
            // 
            // DataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 410);
            this.Controls.Add(this.clientesDataGridView);
            this.Name = "DataGridViewForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.DataGridViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PreferencialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClienteColumn;
    }
}