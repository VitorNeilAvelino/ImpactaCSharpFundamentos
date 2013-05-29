using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ControledeEstoquePIM
{
    class Fornecedor_BD
    {
        string conexao_SqlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        SqlConnection conexao = null;




        public void CadastrarFornecedor(Fornecedor_RetornarDados obj_fornecedor)
        {
            conexao = new SqlConnection(conexao_SqlServer);
            SqlCommand sql = new SqlCommand("insert into Fornecedor values(@nome, @endereco, @cep, @cnpj, @cidade, @estado, @telefone)", conexao);
            
            sql.Parameters.AddWithValue("@nome", obj_fornecedor.Nome);
            sql.Parameters.AddWithValue("@endereco", obj_fornecedor.Endereco);
            sql.Parameters.AddWithValue("@cep", obj_fornecedor.CEP);
            sql.Parameters.AddWithValue("@cnpj", obj_fornecedor.CNPJ);
            sql.Parameters.AddWithValue("@cidade", obj_fornecedor.Cidade);
            sql.Parameters.AddWithValue("@estado", obj_fornecedor.Estado);
            sql.Parameters.AddWithValue("@Telefone", obj_fornecedor.Telefone);

            conexao.Open();
            sql.ExecuteNonQuery();
            conexao.Close();
        }


        public Fornecedor_RetornarDados PesquisarFornecedor(string pesquisa)
        {
            try
            {
                conexao = new SqlConnection(conexao_SqlServer);
                SqlCommand sql = new SqlCommand("select * from Fornecedor where nome like '" + pesquisa + "%'", conexao);

                conexao.Open();

                SqlDataReader LendoDados;
                Fornecedor_RetornarDados obj_retornardados = new Fornecedor_RetornarDados();
                LendoDados = sql.ExecuteReader();

                while (LendoDados.Read())
                {
                    obj_retornardados.codigo = int.Parse(LendoDados["codigo"].ToString());
                    obj_retornardados.Nome = LendoDados["nome"].ToString();
                    obj_retornardados.Endereco = LendoDados["endereco"].ToString();
                    obj_retornardados.CEP = LendoDados["cep"].ToString();
                    obj_retornardados.CNPJ = LendoDados["cnpj"].ToString();
                    obj_retornardados.Cidade = LendoDados["cidade"].ToString();
                    obj_retornardados.Estado = LendoDados["estado"].ToString();
                    obj_retornardados.Telefone = LendoDados["telefone"].ToString();


                }
                return obj_retornardados;

            }
            catch (SqlException erro)
            {

                throw erro;
            }



        }


    }
}
