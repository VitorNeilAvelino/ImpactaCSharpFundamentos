using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Pizzaria.Infra.Repositorios.Excel
{
    public class BaseRepositorio
    {
        public OleDbConnection OleCon;
        public OleDbCommand OleCmd;
        public static String Arquivo = ConfigurationManager.AppSettings["ConexaoPlanilha"];
        private readonly String StringConexao = string.Format(ConfigurationManager.AppSettings["Conexao"], Arquivo);
        public String Consulta;

        public void FinishConnection()
        {
            if (OleCmd != null)
            {
                OleCmd.Parameters.Clear();
                OleCmd.Dispose();
            }

            OleCmd = null;

            if (OleCon != null)
            {
                if (OleCon.State == ConnectionState.Open)
                    OleCon.Close();

                OleCon.Dispose();
            }

            OleCon = null;
        }
        public void Conexão()
        {
            OleCon = new OleDbConnection(StringConexao);
            OleCon.Open();

            OleCmd = new OleDbCommand();
            OleCmd.Connection = OleCon;
            OleCmd.CommandType = CommandType.Text;
        }
    }
}