using System;
using System.Windows.Forms;

namespace CSharp1.Capitulo03.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();

            /*            
            this.moedasListView.LargeImageList = this.modedasImageList;            
            */
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            DefinirMoedasListView();

            var valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            var valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            var troco = valorPago - valorCompra;
            var resto = troco;

            // Arredonda:
            //var moedas1 = Convert.ToInt32(resto / 1);

            var moedas1 = (int)(resto / 1m);
            resto %= 1;
            var moedas050 = (int)(resto / 0.5m);
            resto %= 0.5m;
            var moedas025 = (int)(resto / 0.25m);
            resto %= 0.25m;
            var moedas010 = (int)(resto / 0.1m);
            resto %= 0.1m;
            var moedas005 = (int)(resto / 0.05m);
            resto %= 0.05m;
            var moedas001 = (int)(resto / 0.01m);
            resto %= 0.01m;

            valorTrocoTextBox.Text = troco.ToString();
            //valorTrocoTextBox.Text = Convert.ToString(troco)

            moedasListView.Items[0].Text = moedas1.ToString();
            moedasListView.Items[1].Text = moedas050.ToString();
            moedasListView.Items[2].Text = moedas025.ToString();
            moedasListView.Items[3].Text = moedas010.ToString();
            moedasListView.Items[4].Text = moedas005.ToString();
            moedasListView.Items[5].Text = moedas001.ToString();

            foreach (ListViewItem moeda in moedasListView.Items)
            {
                if (moeda.Text == "0")
                {
                    moeda.Remove();
                }
            }
        }

        private void DefinirMoedasListView()
        {
            moedasListView.Items.Clear();

            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 0);

            this.moedasListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
        }
    }
}