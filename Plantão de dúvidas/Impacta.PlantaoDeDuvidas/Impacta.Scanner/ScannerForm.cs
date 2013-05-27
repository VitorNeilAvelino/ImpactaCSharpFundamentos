using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIA;  // Botão direito em References, Add Reference, aba COM, Microsoft Windows Image Acquisition

namespace Impacta.Scanner
{
    public partial class ScannerForm : Form
    {
        public ScannerForm()
        {
            InitializeComponent();
        }

        private void digitalizarToolStripButton_Click(object sender, EventArgs e)
        {
            const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
            var wiaDiag = new WIA.CommonDialog();
            // instanciando a WiaImagem    
            WIA.ImageFile wiaImage = null;
            //objeto criado para fins de fazer scanear varios documentos de uma vez
            int i = 1;
            //objeto criado para fins de fazer scanear varios documentos de uma vez
            object index = 1;
            // capturando a imgaem scaneada e abrindo o pop-up do scanner
            wiaImage = wiaDiag.ShowAcquireImage(
              WiaDeviceType.UnspecifiedDeviceType,
              WiaImageIntent.GrayscaleIntent,
              WiaImageBias.MaximizeQuality,
              wiaFormatJPEG, true, true, false);
            //pegando o WiaImage e vetorizando
            WIA.Vector vector = wiaImage.FileData;
            // carregando a imagem em memoria
            Image img = Image.FromStream(new MemoryStream((byte[])vector.get_BinaryData()));
            img.Save("C:/imagem" + i + ".jpg");
        }
    }
}