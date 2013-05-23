using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Impacta.Capitulo03.Medias
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        // Não usar, o evento de validação não funciona
        private bool validacaoFormulario = true;

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios()) return;
            if (!ValidarNotas())
            {
                return;
            }

            // Declaração de variáveis
            string aluno, materia, situacaoAluno;
            decimal nota1, nota2, nota3, nota4, media;

            // Atribuição dos valores
            aluno = alunoTextBox.Text;
            materia = materiaComboBox.Text;
            nota1 = Convert.ToDecimal(nota1TextBox.Text);
            nota2 = Convert.ToDecimal(nota2TextBox.Text);
            nota3 = Convert.ToDecimal(nota3TextBox.Text);
            nota4 = Convert.ToDecimal(nota4TextBox.Text);

            // Cálculo da média
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            // Atribuição do resultado da média
            // N1 abaixo transformará a média em um valor decimal formatado,
            // com uma casa decimal. Exemplo: 4,5
            // Exemplo: 1.234,4
            medialLabel.Text = media.ToString("N1");

            // Cálculo da situação do aluno
            situacaoAluno = media < 5 ? "Reprovado" : media < 7 ? "Recuperação" : "Aprovado";

            // Geração do registro
            // out - permite que um parâmetro de um método seja retornado para o 
            // método chamador
            Gravar(aluno, materia, nota1, nota2, nota3, nota4, media, situacaoAluno);

            situacaoAlunoLabel.Text = situacaoAluno;

            MessageBox.Show(
                "Operação concluída com sucesso.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

            // Redefinição dos dados
            Limpar();
            medialLabel.Text = "00,0";
            situacaoAlunoLabel.Text = string.Empty;
            alunoTextBox.Focus();
        }

        // O método abaixo retorna um booleano. Ou seja, em algum ponto dentro do 
        // método a palavra-chave return deverá ser usada, retornando algum valor
        // booleano.
        private bool ValidarNotas()
        {
            bool validacao = true;

            foreach (Control controle in this.Controls)
            {
                if (controle.Tag != null && controle.Tag.ToString().ToUpper().Contains("NOTA"))
                {
                    // Tentar
                    try
                    {
                        decimal nota = Convert.ToDecimal(controle.Text);
                        principalErrorProvider.SetError(controle, "");
                        if (nota < 0 || nota > 10)
                        {
                            validacao = false;
                            principalErrorProvider.SetError(controle, "Digite um valor entre 0 e 10.");
                        }
                        else
                            principalErrorProvider.SetError(controle, "");
                    }
                    // Capturar o erro da tentativa, se houver
                    catch
                    {
                        validacao = false;
                        principalErrorProvider.SetError(controle, "Digite um valor válido.");
                    }
                }
            }

            return validacao;
        }

        private bool ValidarCamposObrigatorios()
        {
            bool validacao = true;

            foreach (Control controle in this.Controls)
            {
                if (controle.Tag != null && controle.Tag.ToString().Contains("*"))
                {
                    //principalErrorProvider.SetError(controle, "");

                    if (controle.Text.Trim() == string.Empty)
                    {
                        validacao = false;
                        principalErrorProvider.SetError(controle, "Campo obrigatório.");
                    }
                    else
                    {
                        principalErrorProvider.SetError(controle, "");
                    }
                }
            }

            return validacao;
        }

        private void Limpar()
        {
            // Para cada controle do formulário
            // A palavra-chave this representa a classe atual, ou seja, o próprio formulário.
            // this.Controls é a coleção de todos os controles que coloquei no formulário.
            foreach (Control controle in this.Controls)
            {
                // Verificar se o controle é do tipo caixa de texto ou combobox
                // is verifica se um objeto é de um determinado tipo
                if (controle is TextBox || controle is MaskedTextBox)
                {
                    // Limpar o conteúdo do controle
                    controle.Text = string.Empty; // ""
                }
                else if (controle is ComboBox)
                {
                    // controle.SelectedIndex não está disponível, pois é uma propriedade
                    // específica do ComboBox
                    // Abaixo estou convertendo o objeto controle no tipo ComboBox (cast)
                    // SelectedIndex = -1 - nenhum item selecionado
                    ((ComboBox)controle).SelectedIndex = -1;
                }
            }
        }

        private void Gravar(string aluno, string materia, decimal nota1, decimal nota2, decimal nota3, decimal nota4, decimal media, string situacaoAluno)
        {
            string registro = string.Format("{0};{1};{2};{3};{4};{5};{6};{7}",
                aluno,
                materia,
                nota1,
                nota2,
                nota3,
                nota4,
                media,
                situacaoAluno
                );

            // Criação do objeto sw
            StreamWriter sw = new StreamWriter(@"C:\Escola.txt", true);
            // Gravação do registro
            sw.WriteLine(registro);
            sw.Close();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void principalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void nota1TextBox_Validating(object sender, CancelEventArgs e)
        {
            //ValidarNota(nota1TextBox);
        }

        private void ValidarNota(TextBox notaTextBox)
        {
            try
            {
                decimal nota = Convert.ToDecimal(notaTextBox.Text);
                principalErrorProvider.SetError(notaTextBox, "");
                if (nota < 0 || nota > 10)
                {
                    validacaoFormulario = false;
                    principalErrorProvider.SetError(notaTextBox, "Digite um valor entre 0 e 10.");
                }
                else
                    principalErrorProvider.SetError(notaTextBox, "");
            }
            // Capturar o erro da tentativa, se houver
            catch
            {
                validacaoFormulario = false;
                principalErrorProvider.SetError(notaTextBox, "Digite um valor válido.");
            }
        }
    }
}