using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ControledeEstoquePIM
{
    class Usuario_DAL
    {
        string conexao_SqlServer = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\ControledeEstoquePIM\ControledeEstoquePIM\ControleEstoque.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";

        SqlConnection conexao = null;

        public void CadastrarFuncionario(Usuario_MODEL obj_usuario)
        {
          
               
            conexao = new SqlConnection(conexao_SqlServer);
            SqlCommand sql = new SqlCommand("insert into LoginSenha values(@nome, @usuario, @senha,@fone, @rg, @cpf, @nasc,@endereco,@cidade,@estado)", conexao);

            sql.Parameters.AddWithValue("@usuario", obj_usuario.Usuario);
            sql.Parameters.AddWithValue("@senha", obj_usuario.Senha);
            sql.Parameters.AddWithValue("@nome", obj_usuario.Nome);
            sql.Parameters.AddWithValue("@fone", obj_usuario.Fone);
            sql.Parameters.AddWithValue("@rg", obj_usuario.RG);
            sql.Parameters.AddWithValue("@cpf", obj_usuario.CPF);
            sql.Parameters.AddWithValue("@nasc", obj_usuario.nasc);
            sql.Parameters.AddWithValue("@endereco", obj_usuario.endereco);
            sql.Parameters.AddWithValue("@cidade", obj_usuario.cidade);
            sql.Parameters.AddWithValue("@estado", obj_usuario.estado);

            conexao.Open();
            sql.ExecuteNonQuery();
            conexao.Close();
           

        }

        public Usuario_MODEL PesquisarUsuario(string pesquisa)
        {
            try
            {
                conexao = new SqlConnection(conexao_SqlServer);
                SqlCommand sql = new SqlCommand("select * from LoginSenha where nome like '" + pesquisa + "%'", conexao);

                conexao.Open();

                SqlDataReader LendoDados;
                Usuario_MODEL obj_MODEL = new Usuario_MODEL();
                LendoDados = sql.ExecuteReader();

                while (LendoDados.Read())
                {
                   
                    obj_MODEL.id_usuario = int.Parse(LendoDados["id_usuario"].ToString());
                    obj_MODEL.nome = LendoDados["nome"].ToString();
                    obj_MODEL.usuario = LendoDados["usuario"].ToString();
                    obj_MODEL.fone = LendoDados["fone"].ToString();
                    obj_MODEL.rg = LendoDados["rg"].ToString();
                    obj_MODEL.cpf = LendoDados["cpf"].ToString();
                    obj_MODEL.nasc = LendoDados["nasc"].ToString();
                    obj_MODEL.endereco = LendoDados["endereco"].ToString();
                    obj_MODEL.cidade = LendoDados["cidade"].ToString();
                    obj_MODEL.estado = LendoDados["estado"].ToString();



                }
                return obj_MODEL;

            }
            catch (SqlException erro)
            {

                throw erro;
            }



        }


    }
}
