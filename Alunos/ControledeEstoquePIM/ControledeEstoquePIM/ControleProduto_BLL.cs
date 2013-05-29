using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ControledeEstoquePIM
{
    class ControleProduto_BLL
    {
        ControleProduto_DAL controleproduto_dal = null;

        public DataTable listarproduto_dal()
        {
            controleproduto_dal = new ControleProduto_DAL();
            DataTable dt_produto = new DataTable();
            dt_produto = controleproduto_dal.listar_produto();
            return dt_produto;
        }
        

        public void CadastrarProduto_DAL(ControleProduto_MODEL ControleProduto)
        {
            try
            {
                controleproduto_dal = new ControleProduto_DAL();
                controleproduto_dal.CadastrarProduto(ControleProduto);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
            
        }


        public ControleProduto_MODEL PesquisarProduto_DAl(string pesquisa)
        {
            try
            {
                controleproduto_dal = new ControleProduto_DAL();
                return controleproduto_dal.PesquisarProduto(pesquisa);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }

           
        }


        public void ExcluirProduto_DAl(ControleProduto_MODEL ControleProduto)
        {
            try
            {
                controleproduto_dal = new ControleProduto_DAL();
                controleproduto_dal.ExcluirProduto(ControleProduto);
            }
            catch (Exception erro)
            {
                
                throw erro;
            }
            
        }


        public void AtualizarProduto_DAl(ControleProduto_MODEL ControleProduto)
        {
            try
            {
                controleproduto_dal = new ControleProduto_DAL();
                controleproduto_dal.AtualizarProduto(ControleProduto);
            }
            catch (Exception erro)
            {

                throw erro;
            }

        }





    }
}
