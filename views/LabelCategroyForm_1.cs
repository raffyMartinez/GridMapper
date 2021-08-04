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
using GridMapper.views.UserControls;
using MapWinGIS;

namespace GridMapper.views
{
    public partial class LabelCategroyForm_1 : Form
    {
        private FontComboBox _fontComboBox;
        private Shapefile _shapefile;
        private List<string> _uniqueValues;
        //private Dictionary<string, LabelCategoryFieldValue> _dictLabelCategories;
        public LabelCategroyForm_1()
        {
            InitializeComponent();
            Load += LabelCategroyForm_Load;
            cboFields.SelectedIndexChanged += CboFields_SelectedIndexChanged;
            listValues.ItemCheck += ListValues_ItemCheck;
        }

        private void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }
        private void ListValues_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            EnableTab(tabFont, e.NewValue == CheckState.Checked);

            if (e.NewValue == CheckState.Checked)
            {

            }
            else if (e.NewValue == CheckState.Unchecked)
            {

            }

        }

        private void CboFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            var uniqueValues = new HashSet<string>();
            int i = ((ComboBox)sender).SelectedIndex;
            for (int x = 0; x < _shapefile.NumShapes; x++)
            {
                uniqueValues.Add(_shapefile.CellValue[i, x].ToString());
            }

            _uniqueValues = uniqueValues.ToList();
            _uniqueValues.Sort();

            bool proceed = false;
            if (_uniqueValues.Count > 20)
            {
                var r = MessageBox.Show($"There are {_uniqueValues.Count} unique items in the field\r\n\r\n" +
                    "Do you want to proceed in using this field for categories", "FAD Grid Mapper",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    proceed = true;

                }
            }
            else
            {
                proceed = true;
            }

            if (proceed)
            {
                listValues.Items.Clear();
                foreach (var item in _uniqueValues)
                {
                    listValues.Items.Add(item);
                }
            }





        }

        private void LabelCategroyForm_Load(object sender, EventArgs e)
        {
            _fontComboBox = new FontComboBox();
            tabFont.Controls.Add(_fontComboBox);
            _fontComboBox.Location = new System.Drawing.Point(95, 14);
            _fontComboBox.Width = 155;

            _shapefile = Maplayer.LayerObject as Shapefile;
            cboFields.Items.Clear();
            for (int x = 0; x < _shapefile.NumFields; x++)
            {
                cboFields.Items.Add(_shapefile.Field[x].Name);
            }

            EnableTab(tabFont, false);

        }

        public MapLayer Maplayer { get; set; }
    }
}
