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

namespace GridMapper.views
{
    public partial class AboutGridMapperWindow : Form
    {

        public AboutGridMapperWindow()
        {
            InitializeComponent();
            Load += AboutGridMapperWindow_Load;
        }

        private void AboutGridMapperWindow_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = new Bitmap($@"{AppDomain.CurrentDomain.BaseDirectory}/splash-01.jpg");

            labelMapNotInstalled.Visible = !global.IsMapComponentRegistered;
            buttonClose.Visible = labelMapNotInstalled.Visible;

        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
