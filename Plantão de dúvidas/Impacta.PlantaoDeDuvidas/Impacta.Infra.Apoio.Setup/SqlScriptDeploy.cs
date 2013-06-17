using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;
using Impacta.Infra.Apoio.Setup.Properties;

namespace Impacta.Infra.Apoio.Setup
{
    [RunInstaller(true)]
    public partial class SqlScriptDeploy : System.Configuration.Install.Installer
    {
        readonly SqlConnection _sqlConnection = new SqlConnection();

        public SqlScriptDeploy()
        {
            InitializeComponent();
        }

        private static string GetSql()
        {
            var asm = Assembly.GetExecutingAssembly();
            var stm = asm.GetManifestResourceStream(asm.GetName().Name + "." + "ScriptCriacaoBanco.sql");
            var reader = new StreamReader(stm);
            return reader.ReadToEnd();
        }

        private void DeployDatabase()
        {
            var sql = GetSql();
            var command = new SqlCommand(sql, _sqlConnection);
            //_sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["masterConnectionString"].ConnectionString;
            _sqlConnection.ConnectionString = Settings.Default.masterConnectionString;
            command.Connection.Open();
            //command.Connection.ChangeDatabase(dbName);

            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                command.Connection.Close();
            }
        }

        //protected void DeployDatabase(string dbName)
        //{
        //    ExecuteSql(GetSql("sql.txt"));
        //}

        public override void Install(System.Collections.IDictionary statesaver)
        {
            base.Install(statesaver);
            DeployDatabase();
        }
    }
}