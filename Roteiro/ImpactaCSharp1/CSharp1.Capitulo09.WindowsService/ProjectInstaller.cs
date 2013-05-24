using System.ComponentModel;
using System.ServiceProcess;

namespace CSharp1.Capitulo09.InternetSpy.WindowsService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        protected override void OnCommitted(System.Collections.IDictionary savedState)
        {
            ServiceController sc = new ServiceController(serviceInstaller1.ServiceName);
            sc.Start();
        }
    }
}