using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ControledeEstoquePIM
{
    class ControleProduto_DAL
    {

        string conexao_SQlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
        SqlConnection conexao = null;


        public DataTable listar_produto()
        {

            conexao = new SqlConnection(conexao_SQlServer);
            SqlCommand sql = new SqlCommand("select * from Produtos", conexao);
            SqlDataAdapter da_produto = new SqlDataAdapter();
             da_produto.SelectCommand = sql;
            DataTable dt_produto = new DataTable();
            da_produto.Fill(dt_produto);
            return dt_produto;                 

        }
               

        public void CadastrarProduto(ControleProduto_MODEL ControleProduto)
        {

            try
            {
                conexao = new SqlConnection(conexao_SQlServer);

                SqlCommand sql = new SqlCommand("insert into Produtos values(@descricao, @fornecedor, @quantidade, @entrada,  @preco)", conexao);

                sql.Parameters.AddWithValue("@descricao", ControleProduto.Descricao);
                sql.Parameters.AddWithValue("@fornecedor", ControleProduto.Fornecedor);
                sql.Parameters.AddWithValue("@quantidade", ControleProduto.Quantidade);
                sql.Parameters.AddWithValue("@entrada", ControleProduto.Entrada);
                sql.Parameters.AddWithValue("@preco", ControleProduto.Preco);

                conexao.Open();
                sql.ExecuteNonQuery();
                conexao.Close();
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            
        }   




        public ControleProduto_MODEL PesquisarProduto(string pesquisa)
        {
            try
            {
                conexao = new SqlConnection(conexao_SQlServer);
                SqlCommand sql = new SqlCommand("select * from Produtos where descricao like '"+pesquisa+"%'", conexao);
                
                conexao.Open();

                SqlDataReader LendoDados;
                ControleProduto_MODEL controleproduto_model = new ControleProduto_MODEL();
                LendoDados = sql.ExecuteReader();

                while (LendoDados.Read())
                {
                    controleproduto_model.codigo = int.Parse(LendoDados["codigo"].ToString());
                    controleproduto_model.descricao = LendoDados["descricao"].ToString();
                    controleproduto_model.fornecedor = LendoDados["fornecedor"].ToString();
                    controleproduto_model.quantidade = int.Parse(LendoDados["quantidade"].ToString());
                    controleproduto_model.entrada = LendoDados["entrada"].ToString();
                    controleproduto_model.preco = decimal.Parse(LendoDados["preco"].ToString());
                    

                }
                return controleproduto_model;

            }
            catch (SqlException erro)
            {
                
                throw erro;
            }              
           
        }


        public void ExcluirProduto(ControleProduto_MODEL ControleProduto)
        {

            try
            {
                conexao = new SqlConnection(conexao_SQlServer);

                SqlCommand sql = new SqlCommand("delete from Produtos where codigo = @codigo", conexao);

                sql.Parameters.AddWithValue("@codigo", ControleProduto.Codigo);                

                conexao.Open();
                sql.ExecuteNonQuery();
                conexao.Close();
            }
            catch (SqlException erro)
            {
                throw erro;
            }

        }



        public void AtualizarProduto(ControleProduto_MODEL ControleProduto)
        {

            
        }




    

        


    }
}
