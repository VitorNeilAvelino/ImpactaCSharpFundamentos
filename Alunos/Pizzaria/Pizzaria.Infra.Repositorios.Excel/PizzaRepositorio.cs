using System;
using System.Data.OleDb;
using Pizzaria.Dominio;

namespace Pizzaria.Infra.Repositorios.Excel
{
    public class PizzaRepositorio : BaseRepositorio
    {
        public void Insertpizza(Pizza pizza)
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
    }
}