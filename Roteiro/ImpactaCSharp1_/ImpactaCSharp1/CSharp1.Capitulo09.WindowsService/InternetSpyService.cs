using System.ServiceProcess;
using System.Timers;
using System.Diagnostics;

namespace CSharp1.Capitulo09.InternetSpy.WindowsService
{
    public partial class InternetSpyService : ServiceBase
    {
        private Timer _timer = new Timer(5000);

        public InternetSpyService()
        {
            InitializeComponent();
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var processo in Process.GetProcesses())
            {
                if (processo.ProcessName == "iexplore")
                {
                    if (processo.MainWindowTitle.ToUpper().Contains("GOOGLE"))
                    {
                        processo.Kill();
                    }
                }
            }
        }

        protected override void OnStart(string[] args)
        {
            _timer.Enabled = true;
        }

        protected override void OnStop()
        {
            _timer.Enabled = false;
        }
    }
}