using System.IO;
using System;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public class TextoPuroRepositorio : IDisposable
    {
        StreamWriter _sw = null;
        
        public void Gravar(string caminho, string registro)
        {
            _sw = new StreamWriter(caminho, true);
            _sw.WriteLine(registro);
            _sw.Close();
        }

        public void Dispose()
        {
            if (_sw != null)
            {
                _sw.Dispose();
            }
        }
    }
}