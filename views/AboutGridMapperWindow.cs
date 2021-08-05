using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridMapper.entities;
using System.Runtime.InteropServices;

namespace GridMapper.views
{
    public partial class AboutGridMapperWindow : Form
    {
        private bool _withVersion;

        public AboutGridMapperWindow(bool withVersion =false)
        {
            InitializeComponent();
            _withVersion = withVersion;
            Load += AboutGridMapperWindow_Load;

        }

        private void AboutGridMapperWindow_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = new Bitmap($@"{AppDomain.CurrentDomain.BaseDirectory}/splash-01.jpg");
            buttonClose.Visible = false;
            if (!global.IsMapComponentRegistered)
            {
                labelInfo.Text = "Map control is  not installed. Please install MapWinGIS mapping control";
                labelInfo.Visible = true;
                buttonClose.Visible = true;
            }
            else
            {
                labelInfo.Text = $"{global.FrameWorkDescription()}";                
                labelInfo.Font = new Font(labelInfo.Font.FontFamily, 8);
                labelInfo.ForeColor = Color.Black;

                if(_withVersion)
                {
                    labelInfo.Text += $"\r\n AxMap version: {global.MainForm.MapControl.VersionNumber}";
                    buttonClose.Visible = true;
                }
            }

        }
        
        private void OnButtonClick(object sender, EventArgs e)
        {
            if (_withVersion)
            {
                Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
