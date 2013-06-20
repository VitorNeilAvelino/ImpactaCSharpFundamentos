using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Impacta.Infra.Repositorios.MsOffice
{
    public static class ExcelRepositorio
    {
        public static void Salvar(string caminho, IList<string> registros, int? quantidadeMaximaDeRegistrosPorAba = null)
        {
            var excel = new Excel.Application();
            var pastaDeTrabalho = File.Exists(caminho) ? excel.Workbooks.Open(caminho) : excel.Workbooks.Add();
            
            Excel.Worksheet planilha = pastaDeTrabalho.ActiveSheet;

            var proximaLinha = planilha.Range["A1", "A1"].Value2 == null ? 1 : planilha.UsedRange.Rows.Count + 1;
            var proximaColuna = 1;

            foreach (var registro in registros)
            {
                foreach (var campo in registro.Split(';'))
                {
                    planilha.Cells[proximaLinha, proximaColuna++] = campo;
                }
                proximaLinha++;
                proximaColuna = 1;

                if (proximaLinha > quantidadeMaximaDeRegistrosPorAba)
                {
                    planilha = (Excel.Worksheet)excel.Worksheets.Add();
                    proximaLinha = 1;
                }
            }

            excel.DisplayAlerts = false;

            pastaDeTrabalho.SaveAs(caminho);

            pastaDeTrabalho.Close();
            planilha = null;
            pastaDeTrabalho = null;
            excel.Quit();
        }
    }
}