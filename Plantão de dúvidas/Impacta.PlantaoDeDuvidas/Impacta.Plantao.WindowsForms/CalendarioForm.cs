using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impacta.Plantao.WindowsForms
{
    public partial class CalendarioForm : Form
    {
        public CalendarioForm()
        {
            InitializeComponent();
        }

        private void CalendarioForm_Load(object sender, EventArgs e)
        {
            PopularCalendario(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void PopularCalendario(int numeroMes, int ano)
        {
            //var diasDoMes = DateTime.DaysInMonth(ano, numeroMes);

            var dia = new DateTime(ano, numeroMes, 1);
            var label = new Label { Text = "1", Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0) };

            calendarioTableLayoutPanel.Controls.Add(label, (int)dia.DayOfWeek, 1);

            //for (var i = 0; i <= calendarioTableLayoutPanel.RowCount - 1; i++)
            //{
            //    for (var j = 0; j <= calendarioTableLayoutPanel.ColumnCount - 1; j++)
            //    {
            //        for (var k = 0; k < DateTime.DaysInMonth(ano, numeroMes); k++)
            //        {
            //            var dia = new DateTime(ano, numeroMes, k);

            //            if (dia.DayOfWeek == calendarioTableLayoutPanel.row)
            //            {

            //            }
            //        }
            //    }
            //}
        }
    }
}
