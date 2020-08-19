using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleMouseClick
{
    class Program
    {
        private IKeyboardMouseEvents m_GlobalHook;

        [MTAThread]
        static void Main(string[] args)
        {
            //    var p = new Program();
            //    p.Subscribe();

            DetectMouseClick.ListenForMouseEvents();

            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            //Run the app as a windows form application
            Application.Run(new ApplicationContext());
        }

    }
}
