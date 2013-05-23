using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Impacta.Infra.Repositorios.MsOffice
{
    public static class ExcelRepositorio
    {
        public static void Salvar(string caminho, string registro)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook pastaDeTrabalho;
            if (File.Exists(caminho))
            {
                pastaDeTrabalho = excel.Workbooks.Open(caminho);
            }
            else
            {
                pastaDeTrabalho = excel.Workbooks.Add();
            }
            Excel.Worksheet planilha = pastaDeTrabalho.ActiveSheet;

            var proximaLinha =  planilha.Range["A1", "A1"].Value2 == null ? 1 : planilha.UsedRange.Rows.Count + 1;
            var proximaColuna = 1;

            foreach (var campo in registro.Split(';'))
            {
                planilha.Cells[proximaLinha, proximaColuna++] = campo;
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