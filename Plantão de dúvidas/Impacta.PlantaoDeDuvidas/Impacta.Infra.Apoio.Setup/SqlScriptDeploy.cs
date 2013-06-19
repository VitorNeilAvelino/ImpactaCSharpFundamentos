using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Impacta.Infra.Apoio.Setup
{
    [RunInstaller(true)]
    public partial class SqlScriptDeploy : System.Configuration.Install.Installer
    {
        public SqlScriptDeploy()
        {
            InitializeComponent();
        }

        private IEnumerable<FileInfo> ObterScriptsSql()
        {
            return new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).GetFiles("*.sql").ToList();
        }

        private void ExecutarScriptsSql()
        {
            foreach (var script in ObterScriptsSql())
            {
                IniciarProcessoSqlCmd(script);
            }
        }

        private static void IniciarProcessoSqlCmd(FileInfo script)
        {
            using (var sqlCmd = new Process())
            {
                //sqlCmd.StartInfo.FileName = @"C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SqlCmd.exe";
                sqlCmd.StartInfo.FileName = @"SqlCmd.exe";
                sqlCmd.StartInfo.Arguments = String.Format(@"-S localhost\sqlexpress -i ""{0}""", script.FullName);
                sqlCmd.StartInfo.UseShellExecute = false;
                sqlCmd.StartInfo.CreateNoWindow = true;

                sqlCmd.Start();

                sqlCmd.WaitForExit();

                sqlCmd.Close();
            }
        }

        public override void Install(System.Collections.IDictionary statesaver)
        {
            base.Install(statesaver);
            ExecutarScriptsSql();
        }
    }
}