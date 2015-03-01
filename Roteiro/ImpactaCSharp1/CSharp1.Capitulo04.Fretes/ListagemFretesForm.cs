using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace CSharp1.Capitulo04.Fretes
{
    public partial class ListagemFretesForm : Form
    {
        public ListagemFretesForm()
        {
            InitializeComponent();

            MontarListBoxFretes();
            this.ActiveControl = nomeClienteToolStripTextBox.Control;
        }

        private void MontarListBoxFretes(string nomeCliente = null)
        {
            var fretes = Selecionar(nomeCliente);

            var cabecalho = string.Concat("Cliente".PadRight(50),
                "Estado".PadRight(10),
                "Valor".PadLeft(20),
                "Percentual".PadLeft(20),
                "Total".PadLeft(20));

            fretes.Insert(0, cabecalho);

            fretesListBox.DataSource = fretes;
        }

        private List<string> Selecionar(string nomeCliente = null){
            var fretes = new List<string>();
            var caminhoArquivoFretes = ConfigurationManager.AppSettings["caminhoArquivoFretes"];
            
            using (var arquivoFretes = new StreamReader(caminhoArquivoFretes))
            {
                while(!arquivoFretes.EndOfStream)
                {
                    var vetorFrete = arquivoFretes.ReadLine().Split(';');

                    if (!string.IsNullOrEmpty(nomeCliente))
                    {
                        if (!vetorFrete[0].ToUpper().Contains(nomeCliente.ToUpper()))
                        {
                            continue;
                        }
                    }

                    var registro = string.Concat(
                        vetorFrete[0].PadRight(50),/*Nome*/
                        vetorFrete[1].PadRight(10),
                        vetorFrete[2].PadLeft(20),
                        vetorFrete[3].PadLeft(20),
                        vetorFrete[4].PadLeft(20));

                    fretes.Add(registro);
                }
            }

            return fretes;
        }

        private void pesquisarToolStripButton_Click(object sender, System.EventArgs e)
        {
            MontarListBoxFretes(nomeClienteToolStripTextBox.Text);
        }

        private void nomeClienteToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MontarListBoxFretes(nomeClienteToolStripTextBox.Text);
            }
        } 
    }
}