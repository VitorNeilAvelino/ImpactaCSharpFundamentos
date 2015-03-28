using System;
using System.Windows.Forms;

namespace CSharp1.Capitulo03.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            //DefinirMoedasListView();

            var valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            var valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            var troco = valorPago - valorCompra;

            valorTrocoTextBox.Text = troco.ToString("c");
            //valorTrocoTextBox.Text = Convert.ToString(troco)

            // Arredonda:
            //var moedas1 = Convert.ToInt32(troco / 1);

            // Cast - moldar, ajustar.
            //var moedas1 = (int)(troco / 1m);
            //var moedas1  = Math.Truncate(troco);
            var moedas1 = (int)(troco);
            //troco %= 1m;
            troco = troco % 1;
            
            var moedas050 = (int)(troco / 0.5m);
            troco %= 0.5m;
            
            var moedas025 = (int)(troco / 0.25m);
            troco %= 0.25m;
            
            var moedas010 = (int)(troco / 0.1m);
            troco %= 0.1m;
            
            var moedas005 = (int)(troco / 0.05m);
            troco %= 0.05m;
            
            var moedas001 = (int)(troco / 0.01m);
            troco %= 0.01m;

            moedasListView.Items[0].Text = moedas1.ToString();
            moedasListView.Items[1].Text = moedas050.ToString();
            moedasListView.Items[2].Text = moedas025.ToString();
            moedasListView.Items[3].Text = moedas010.ToString();
            moedasListView.Items[4].Text = moedas005.ToString();
            moedasListView.Items[5].Text = moedas001.ToString();

            //foreach (ListViewItem moeda in moedasListView.Items)
            //{
            //    if (moeda.Text == "0")
            //    {
            //        moeda.Remove();
            //    }
            //}
        }

        // Só usar se for omitir os zeros.
        private void DefinirMoedasListView()
        {
            moedasListView.Items.Clear();

            var listViewItem1 = new ListViewItem("", 5);
            var listViewItem2 = new ListViewItem("", 4);
            var listViewItem3 = new ListViewItem("", 3);
            var listViewItem4 = new ListViewItem("", 2);
            var listViewItem5 = new ListViewItem("", 1);
            var listViewItem6 = new ListViewItem("", 0);

            this.moedasListView.Items.AddRange(new ListViewItem[] {
                listViewItem1,
                listViewItem2,
                listViewItem3,
                listViewItem4,
                listViewItem5,
                listViewItem6});
        }
    }
}