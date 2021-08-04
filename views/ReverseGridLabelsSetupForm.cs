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
    public partial class ReverseGridLabelsSetupForm : Form
    {
        public bool ShowTitleOnReverse { get; set; }
        public bool ShowZoneOnReverse { get; set; }

        public ReverseGridLabelsSetupForm()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnOk":
                    DialogResult = DialogResult.OK;
                    ShowTitleOnReverse = chkShowTitle.Checked;
                    ShowZoneOnReverse = chkShowZone.Checked;
                    break;

                case "btnCancel":
                    DialogResult = DialogResult.Cancel;
                    break;
            }
        }
    }
}