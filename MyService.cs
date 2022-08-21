using System.ServiceProcess;
using System.Threading;

namespace MyWindowsService
{
    public partial class MyService : ServiceBase
    {
        private readonly int secs = 7;

        public MyService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Thread.Sleep(1000 * secs);
        }

        protected override void OnStop()
        {
            Thread.Sleep(1000 * secs);
        }

        protected override void OnContinue()
        {
            Thread.Sleep(1000 * secs);
        }

        protected override void OnPause()
        {
            Thread.Sleep(1000 * secs);
        }
    }
}
