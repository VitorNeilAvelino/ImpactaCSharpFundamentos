using System;
using System.Data.OleDb;
using System.IO;
using Pizzaria.Dominio;
// Referência adicionada para Microsoft.Office.Interop.Excel, selecione sua versão predileta, abaixo fiz testes com a versão 14.
using ExcelApp = Microsoft.Office.Interop.Excel;


namespace Pizzaria.Infra.Repositorios.Excel
{
    public class PizzaRepositorio : BaseRepositorio
    {
        public void Insert(Pizza pizza)
        {
            OleCmd.CommandText = "SELECT CodigoPizza FROM [pizza$]";
            var leitor = OleCmd.ExecuteReader();
            
            while (leitor.Read())
            {
                pizza.Codigoo = leitor.GetValue(0).ToString();
            }
            leitor.Close();
            
            var codigo = Convert.ToInt32(pizza.Codigoo);
            codigo = codigo + 1;
            pizza.Codigoo = codigo.ToString();
            
            Consulta = "INSERT INTO [pizza$] ";
            Consulta += "([CodigoPizza],[TipoPizza],[PrecoPizza],[CustoPizza]) ";
            Consulta += "VALUES ";
            Consulta += "(@Codigopizza,@tipopizza,@precopizza,@custopizza)";
            OleCmd.CommandText = Consulta;
            OleCmd.Parameters.Add("@Codigopizza", OleDbType.Integer).Value = Convert.ToInt32(pizza.Codigoo);
            OleCmd.Parameters.Add("@tipopizza", OleDbType.VarChar, 255).Value = pizza.Tipo;
            OleCmd.Parameters.Add("@precopizza", OleDbType.VarChar, 255).Value = pizza.Preco;
            OleCmd.Parameters.Add("@custopizza", OleDbType.VarChar, 255).Value = pizza.Custo;

            OleCmd.ExecuteNonQuery();

            OleCmd.Parameters.Clear();
        }

        public void Salvar(string caminho, string registro)
        {
            var excel = new ExcelApp.Application();
            var pastaDeTrabalho = File.Exists(caminho) ? excel.Workbooks.Open(caminho) : excel.Workbooks.Add();
            ExcelApp.Worksheet planilha = pastaDeTrabalho.ActiveSheet;

            var proximaLinha = planilha.Range["A1", "A1"].Value2 == null ? 1 : planilha.UsedRange.Rows.Count + 1;
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