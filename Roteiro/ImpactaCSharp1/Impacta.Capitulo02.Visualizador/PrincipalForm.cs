using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Impacta.Capitulo02.Visualizador
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            // Filtra as extensões que serão visualizadas pela caixa de diálogo
            imagemOpenFileDialog.Filter = "Arquivos de imagens|*.jpg;*.bmp;*.png|Arquivos bmp|*.bmp|Arquivos jpg|*.jpg";

            imagemOpenFileDialog.ShowDialog();
            imagemPictureBox.ImageLocation = imagemOpenFileDialog.FileName;

            // Testa se o endereço na caixa de diálogo foi confirmado
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    // Atribui o endereço da caixa de diálogo na picturebox
            //    imagemPictureBox.ImageLocation = ofd.FileName;
            //}
        }

        private void Redimensionar()
        {
            if (imagemPictureBox.Image == null) return;

            if (imagemPictureBox.Image.Width > imagemPictureBox.Width || imagemPictureBox.Image.Height > imagemPictureBox.Height)
            {
                imagemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else 
            {
                imagemPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void imagemPictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Redimensionar();
        }

        private void imagemPictureBox_Resize(object sender, EventArgs e)
        {
            //Redimensionar();
        }
    }
}