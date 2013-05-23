using System.IO;
using System.Windows.Forms;

namespace Impacta.Dominio
{
    // public - modificador de acessibilidade que libera o acesso à classe
    // internal - ou sem modificador, permite acesso apenas para outras classes do mesmo assembly (DLL).
    public class Aluno : Pessoa
    {
        // Construtor - método que é chamado toda vez que a classe é instanciada (new).
        // O método construtor tem o mesmo nome da classe.
        public Aluno()
        {
            Avaliacao = new Avaliacao();
        }

        ~Aluno()
        {
            // Apenas para fins didáticos!
            //MessageBox.Show("Destrutor chamado");
        }

        private Avaliacao _avaliacao;
        public Avaliacao Avaliacao
        {
            get { return _avaliacao; }
            set { _avaliacao = value; }
        }

        // override - polimorfismo por sobrescrita: o método Gravar foi declarado na classe base Pessoa, mas pode ter formas diferentes em cada
        // uma das classes derivadas que herdarem de Pessoa
        public void Gravar(string caminho)
        {
            string registro = string.Format("{0};{1};{2};{3};{4};{5};{6};{7}",
                                                Nome,
                                                Avaliacao.Materia,
                                                Avaliacao.Notas[0],
                                                Avaliacao.Notas[1],
                                                Avaliacao.Notas[2],
                                                Avaliacao.Notas[3],
                                                Avaliacao.Media,
                                                Avaliacao.Situacao);

            // Criação do objeto sw
            StreamWriter sw = new StreamWriter(caminho, true);

            // Gravação do registro
            sw.WriteLine(registro);
            sw.Close();
        }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
