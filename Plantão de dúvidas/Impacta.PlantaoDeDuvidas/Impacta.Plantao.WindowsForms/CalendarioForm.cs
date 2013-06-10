using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
            calendarioTableLayoutPanel.SuspendLayout();

            calendarioTableLayoutPanel.Controls.Clear();
            PopularCabecalhoCalendario();

            var diasDoMes = new List<DateTime>();
            for (var dia = 1; dia <= DateTime.DaysInMonth(ano, numeroMes); dia++)
            {
                diasDoMes.Add(new DateTime(ano, numeroMes, dia));
            }

            var linhaDoCalendario = 1;
            foreach (var dia in diasDoMes)
            {
                var diaLabel = new Label { Text = dia.Day.ToString(), Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0) };

                calendarioTableLayoutPanel.Controls.Add(diaLabel, (int)dia.DayOfWeek, linhaDoCalendario);

                if (dia.DayOfWeek == DayOfWeek.Saturday) linhaDoCalendario++;
            }

            calendarioTableLayoutPanel.ResumeLayout();
        }

        private void PopularCabecalhoCalendario()
        {
            var lingua = new CultureInfo("pt-BR"); 
            var formatoDeData = lingua.DateTimeFormat; 

            for (var numeroDiaDaSemana = 0; numeroDiaDaSemana < 7; numeroDiaDaSemana++)
            {
                var nomeDiaDaSemana = formatoDeData.GetDayName((DayOfWeek)numeroDiaDaSemana);

                var diaDaSemanaLabel = new Label
                {
                    Text =  nomeDiaDaSemana,
                    Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0)
                };

                calendarioTableLayoutPanel.Controls.Add(diaDaSemanaLabel, numeroDiaDaSemana, 0);
            }
        }

        private void calendarioMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            PopularCalendario(e.Start.Month, e.Start.Year);
        }
    }
}