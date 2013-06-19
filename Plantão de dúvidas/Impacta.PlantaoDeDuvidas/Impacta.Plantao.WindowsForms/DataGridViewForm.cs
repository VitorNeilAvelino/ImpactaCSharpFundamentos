using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Impacta.Dominio;

namespace Impacta.Plantao.WindowsForms
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            clientesDataGridView.AutoGenerateColumns = false;

            var fonteDeDados = new List<Cliente>();

            fonteDeDados.Add(new Cliente{Preferencial = true, Nome="Vítor"});
            fonteDeDados.Add(new Cliente{Preferencial = false, Nome="Avelino"});

            clientesDataGridView.DataSource = fonteDeDados;
        }
    }
}
