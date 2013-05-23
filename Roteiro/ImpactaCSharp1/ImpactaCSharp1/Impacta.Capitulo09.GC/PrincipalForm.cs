using System;
using System.Windows.Forms;
using Impacta.Dominio;

namespace Impacta.Capitulo09.GC
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void destrutorButton_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno();
            aluno.Nome = "Vítor";
            resultadoListBox.Items.Add(aluno.Nome);
        }

        private void disposeButton_Click(object sender, EventArgs e)
        {
            var mercadoria = new Mercadoria();
            mercadoria.Nome = "Régua";
            resultadoListBox.Items.Add(mercadoria.Nome);

            mercadoria.Dispose();
        }

        private void usingButton_Click(object sender, EventArgs e)
        {
            using(var mercadoria = new Mercadoria())
            {
                mercadoria.Nome = "Borracha";
                resultadoListBox.Items.Add(mercadoria.Nome);
            }
        }

        private void gcButton_Click(object sender, EventArgs e)
        {
            System.GC.Collect();
        }
    }
}