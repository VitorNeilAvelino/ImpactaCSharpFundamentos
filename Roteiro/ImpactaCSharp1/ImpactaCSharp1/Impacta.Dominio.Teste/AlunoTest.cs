using Impacta.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Impacta.Dominio.Teste
{
    /// <summary>
    ///This is a test class for AlunoTest and is intended
    ///to contain all AlunoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AlunoTest
    {
        /// <summary>
        ///A test for Gravar
        ///</summary>
        [TestMethod()]
        public void GravarTest()
        {
            Aluno aluno = new Aluno();            

            string caminho = @"C:\Escola.txt";
            aluno.Nome = "Vítor";
            //aluno.Documentos.Add(new Documento {TipoDocumento = TipoDocumento.CPF, Numero = "12345678900" });
            aluno.Avaliacao.Materia = "Português";
            aluno.Avaliacao.Notas[0] = 1;
            aluno.Avaliacao.Notas[1] = 2;
            aluno.Avaliacao.Notas[2] = 3;
            aluno.Avaliacao.Notas[3] = 10;

            aluno.Gravar(caminho);
        }
    }
}