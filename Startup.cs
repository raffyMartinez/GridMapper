using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace GridMapper
{
    class Startup: WindowsFormsApplicationBase
    {
        protected override void OnCreateSplashScreen()
        {
            SplashScreen = new views.AboutGridMapperWindow();
            SplashScreen.Cursor = Cursors.AppStarting;
        }

        protected override void OnCreateMainForm()
        {
            MainForm = new MainForm();
        }
    }
}
