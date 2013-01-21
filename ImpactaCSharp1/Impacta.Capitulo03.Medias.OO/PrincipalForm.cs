using System;
using System.Windows.Forms;
using Impacta.Dominio;

namespace Impacta.Capitulo03.Medias.OO
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            // Instanciação do objeto aluno
            Aluno aluno = new Aluno();
            //Pessoa aluno = new Aluno();
            // A classe pessoa, por ser abstrata, não pode ser instanciada.
            //Pessoa aluno = new Pessoa();
            
            aluno.Nome = alunoTextBox.Text;
            aluno.Avaliacao.Materia = materiaComboBox.Text;
            aluno.Avaliacao.Notas[0] = Convert.ToDecimal(nota1TextBox.Text);
            aluno.Avaliacao.Notas[1] = Convert.ToDecimal(nota2TextBox.Text);
            aluno.Avaliacao.Notas[2] = Convert.ToDecimal(nota3TextBox.Text);
            aluno.Avaliacao.Notas[3] = Convert.ToDecimal(nota4TextBox.Text);

            mediaLabel.Text = aluno.Avaliacao.Media.ToString("N1");

            situacaoLabel.Text = aluno.Avaliacao.Situacao.ToString();

            aluno.Gravar(@"C:\Escola.txt");

            MessageBox.Show("Operação concluída com sucesso!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        
            Limpar();
            mediaLabel.Text = "00,0";
            alunoTextBox.Focus(); 
        }

        private void Limpar()
        {
            alunoTextBox.Clear(); ;
            materiaComboBox.SelectedIndex = -1;
            nota1TextBox.Clear();
            nota2TextBox.Clear();
            nota3TextBox.Clear();
            nota4TextBox.Clear();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}