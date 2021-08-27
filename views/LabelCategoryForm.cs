using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapWinGIS;
using GridMapper.entities;

namespace GridMapper.views
{
    public partial class LabelCategoryForm : Form
    {

        public LabelCategoryForm()
        {
            InitializeComponent();
            Load += LabelCategoryForm_Load;
        }

        private void LabelCategoryForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Layer: {MapLayer.Name}";
            listViewCategories.View = View.Details;
            listViewCategories.Columns.Add("Expression");
            listViewCategories.Columns.Add("Format defined");
            SizeColumns(true);
            Text = "Labels category";

            var sf = MapLayer.LayerObject as Shapefile;
            if (sf.Labels.NumCategories > 0)
            {
                for (int x = 0; x < sf.Labels.NumCategories; x++)
                {
                    ListViewItem lvi = listViewCategories.Items.Add(sf.Labels.Category[x].Expression);
                    lvi.SubItems.Add("Yes");
                    lvi.Tag = sf.Labels.Category[x];
                }
            }
            SizeColumns(false);
        }

        public MapLayer MapLayer { get; set; }
        private void ApplyCategory()
        {
            var sf = MapLayer.LayerObject as Shapefile;
            sf?.Labels.ClearCategories();
            if (sf != null)
            {
                if (sf.Labels.Count == 0)
                {
                    sf.Labels.Generate(sf.Labels.Expression, tkLabelPositioning.lpCentroid, true);
                }
                //sf.Labels.ClearCategories();
                foreach (ListViewItem item in listViewCategories.Items)
                {
                    var cat = (LabelCategory)item.Tag;
                    cat.Expression = item.Text;
                    var ser = cat.Serialize();
                    var ct = sf.Labels.AddCategory(item.Index.ToString());
                    ct.Deserialize(ser);

                    object result = null;
                    string error = "";
                    if (sf.Table.Query(ct.Expression, ref result, ref error))
                    {

                        int[] shapes = result as int[];
                        if (shapes != null)
                        {
                            for (int i = 0; i < shapes.Length; i++)
                            {
                                //MapWinGIS.Label label = sf.Labels.Label[i, 0];
                                MapWinGIS.Label label = sf.Labels.Label[shapes[i], 0];
                                if (label != null)
                                {
                                    label.Category = item.Index;
                                }
                            }
                        }
                    }

                }
                global.MainForm.MapControl.Redraw();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "buttonOk":

                    ApplyCategory();
                    DialogResult = DialogResult.OK;
                    break;
                case "buttonCancel":
                    DialogResult = DialogResult.Cancel;
                    break;
                case "buttonApply":
                    ApplyCategory();
                    break;
                case "buttonQuery":
                    VisibilityQueryForm vqf = new VisibilityQueryForm(global.MainForm.MapLayersHandler);
                    vqf.Owner = this;
                    vqf.ExpressionTarget = VisibilityExpressionTarget.ExpressionTargetLabel;
                    if (  listViewCategories.SelectedItems.Count>0 && listViewCategories.SelectedItems[0]?.Text?.Length >0)
                    {
                        vqf.VisibilityExpression = listViewCategories.SelectedItems[0].Text;
                    }
                    var r = vqf.ShowDialog(this);
                    if (r == DialogResult.OK)
                    {
                        var s = vqf.VisibilityExpression;
                        if (s?.Length > 0)
                        {
                            ListViewItem lvi;
                            if (listViewCategories.SelectedItems.Count == 0)
                            {
                                lvi = listViewCategories.Items.Add(new ListViewItem());
                                listViewCategories.Items[listViewCategories.Items.Count - 1].Selected = true;
                                lvi.SubItems.Add("No");
                            }
                            else
                            {
                                lvi = listViewCategories.SelectedItems[0];
                            }
                            lvi.Text = s;
                            buttonFormat.Enabled = lvi.Text.Length > 0;
                            SizeColumns();
                        }
                    }
                    break;
                case "buttonFormat":
                    if (listViewCategories.SelectedItems.Count == 1)
                    {
                        LabelsForm lf = new LabelsForm(global.MainForm.MapLayersHandler, inCategorizingLabel: true);
                        lf.Owner = this;
                        if(listViewCategories.SelectedItems[0].Tag!=null)
                        {
                            lf.LabelCategory = (LabelCategory)listViewCategories.SelectedItems[0].Tag;
                        }
                            
                        var dr = lf.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            listViewCategories.SelectedItems[0].SubItems[1].Text = "Yes";
                            listViewCategories.SelectedItems[0].Tag = lf.LabelCategory;
                        }
                    }
                    break;

                case "buttonDelete":
                    break;

            }
        }
        private void SizeColumns(bool init = true)
        {
            foreach (ColumnHeader c in listViewCategories.Columns)
            {
                if (init)
                {
                    c.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                    c.Tag = c.Width;
                }
                else
                {
                    c.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    c.Width = c.Width > (int)c.Tag ? c.Width : (int)c.Tag;
                }
            }
        }
        private void OnLVMouseDown(object sender, MouseEventArgs e)
        {
            var hitInfo = listViewCategories.HitTest(e.X, e.Y);
            if (hitInfo.Item != null)
            {
                buttonFormat.Enabled = true; ;
            }
            else
            {
                buttonFormat.Enabled = false;
            }
        }
    }
}
