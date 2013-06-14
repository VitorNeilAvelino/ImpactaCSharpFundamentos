using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;

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

        //private static string GetSql(string name)
        //{
        //    var asm = Assembly.GetExecutingAssembly();
        //    var stm = asm.GetManifestResourceStream(asm.GetName().Name + "." + name);
        //    var reader = new StreamReader(stm);
        //    return reader.ReadToEnd();
        //}

        private void DeployDatabase()
        {
            string sql = string.Empty;
            var command = new SqlCommand(sql, _sqlConnection);
            _sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["masterConnectionString"].ConnectionString;
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