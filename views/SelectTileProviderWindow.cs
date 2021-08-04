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
    public partial class SelectTileProviderWindow : Form
    {
        public SelectTileProviderWindow()
        {
            InitializeComponent();
            Load += SelectTileProviderWindow_Load;
            listBoxProviders.SelectedIndexChanged += ListBoxProviders_SelectedIndexChanged;
        }

        private void ListBoxProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProviders.SelectedItem != null)
            {
                TileProviderID = ((KeyValuePair<int, string>)listBoxProviders.SelectedItem).Key;
            }
        }

        public int TileProviderID { get; set; }


        private void SelectTileProviderWindow_Load(object sender, EventArgs e)
        {
            TileProviderManager.MakeProvideList();
            foreach(var item in TileProviderManager.TileProviders)
            {
                listBoxProviders.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
            }
            listBoxProviders.ValueMember = "Key";
            listBoxProviders.DisplayMember = "Value";
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            switch(((Button)sender).Name)
            {
                case "buttonOk":
                    DialogResult = DialogResult.OK;
                    break;
                case "buttonCancel":
                    DialogResult = DialogResult.Cancel;
                    break;
            }
        }
    }
}
