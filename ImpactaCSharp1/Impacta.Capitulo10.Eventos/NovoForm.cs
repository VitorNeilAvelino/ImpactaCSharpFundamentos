using System;
using System.IO;
using System.Windows.Forms;

namespace Impacta.Capitulo10.Eventos
{
    public partial class NovoForm : Form
    {
        public NovoForm()
        {
            InitializeComponent();
        }

        // Abaixo a sintaxe de criação do evento.
        // A classe EventHandler representa o delegate que fornecerá os parâmetros para
        // o evento.
        // Eventos de uma classe, ao serem disparados, possuem a capacidade de enviar uma 
        // mensagem para as demais classes que os estão ouvindo (inscritas).
        public event EventHandler CopiarArquivo;

        // Delegates são estruturas também usadas por eventos para prover os argumentos
        // do método que irá manipular o evento. Um delegate tem a propriedade de associar um objeto
        // com a chamada de um método.
        public delegate void AoCopiarEventHandler(string descricao);

        // 1. Declaração do evento
        public event AoCopiarEventHandler AoCopiar;

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                arquivoTextBox.Text = ofd.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            File.Copy(arquivoTextBox.Text,
                Properties.Settings.Default.caminhoArquivos + "\\" + ofd.SafeFileName,
                true);

            CopiarArquivo(sender, e);
            // 2. Disparar o evento
            AoCopiar(descricaoTextBox.Text);

            Close();
        }
    }
}