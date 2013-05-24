using System.Collections.Generic;
using System.IO;

namespace Impacta.Infra.Repositorios.SistemaDeArquivos
{
    public static class ArquivosRepositorio
    {
        public static FileInfo[] Selecionar(string nomeArquivo, string caminho)
        {
            return new DirectoryInfo(caminho).GetFiles(string.Format("*{0}*", nomeArquivo));
        }
    }
}