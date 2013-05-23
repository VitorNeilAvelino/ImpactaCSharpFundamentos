using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Impacta.Infra.Repositorios.SistemaDeArquivos;

namespace Impacta.Capitulo10.Eventos
{
    public partial class PrincipalForm : Form
    {
        private NovoForm _novoForm = new NovoForm();

        public PrincipalForm()
        {
            InitializeComponent();

            // Abaixo a sintaxe para a inscrição em um evento. Quanto o evento 
            // CopiarArquivo que está em novoForm for disparado, o método
            // novoForm_CopiarArquivo abaixo será executado.
            _novoForm.CopiarArquivo += new EventHandler(novoForm_CopiarArquivo);
            // 3. Inscrição no evento
            _novoForm.AoCopiar += new NovoForm.AoCopiarEventHandler(novoForm_AoCopiar);
        }

        // 4. Executar instruções assim que o evento for disparado.
        void novoForm_AoCopiar(string descricao)
        {
            descricaoToolStripStatusLabel.Text = "Descrição do último arquivo inserido: " + descricao;
        }

        void novoForm_CopiarArquivo(object sender, EventArgs e)
        {
            PreencherListBox(string.Empty);
        }

        private void PreencherListBox(string nomePesquisado)
        {
            try
            {
                arquivosListBox.DataSource = ArquivosRepositorio.Selecionar(nomePesquisado, Properties.Settings.Default.caminhoArquivos);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("A pasta " + Properties.Settings.Default.caminhoArquivos + " não foi encontrada.");
                Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ooops!");
                //Logar.PorEmail(ex);
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            _novoForm.ShowDialog();
        }

        private void pesquisaToolStripTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherListBox(pesquisaToolStripTextBox.Text);
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            PreencherListBox(string.Empty);
        }

        private void arquivosListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(Properties.Settings.Default.caminhoArquivos + arquivosListBox.SelectedItem);
        }
    }
}