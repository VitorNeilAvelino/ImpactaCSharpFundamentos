using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impacta.Capitulo02.Lembretes
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void principalTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Second == 0)
                principalTimer.Interval = 60000;

            if (lembrete1DateTimePicker.Checked && DateTime.Now.ToString("HH:mm") == lembrete1DateTimePicker.Value.ToString("HH:mm"))
            {
                MessageBox.Show(lembrete1TextBox.Text, "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (lembrete2DateTimePicker.Checked && DateTime.Now.ToString("HH:mm") == lembrete2DateTimePicker.Value.ToString("HH:mm"))
            {
                MessageBox.Show(lembrete2TextBox.Text, "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (lembrete3DateTimePicker.Checked && DateTime.Now.ToString("HH:mm") == lembrete3DateTimePicker.Value.ToString("HH:mm"))
            {
                MessageBox.Show(lembrete3TextBox.Text, "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}