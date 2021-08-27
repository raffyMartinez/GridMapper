using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using GridMapper.entities;

namespace GridMapper.views
{
    public partial class SaveMapForm : Form
    {
        private bool _saveAsShapefile;
        private static SaveMapForm _instance;
        private MainForm _parentForm;
        public string MapTitle { get; set; }
        private string _fileName;

        public void SaveType(bool SaveAsShapefile)
        {
            _saveAsShapefile = SaveAsShapefile;
            Text = "Save fishing grid as shapefile";
            lblSave.Text = "File name";
            if (!_saveAsShapefile)
            {
                lblSave.Text = "Resolution (DPI)";
                Text = "Save fishing grid as image";
            }
        }

        public static SaveMapForm GetInstance(MainForm Parent)
        {
            if (_instance == null) _instance = new SaveMapForm(Parent);
            return _instance;
        }

        public SaveMapForm(MainForm Parent)
        {
            InitializeComponent();
            _parentForm = Parent;
        }

        public SaveMapForm()
        {
            InitializeComponent();
        }

        private void OnGrid25SaveForm_Load(object sender, EventArgs e)
        {
            lblLayout.Enabled = !_saveAsShapefile;
            chkLayout.Enabled = !_saveAsShapefile;
            lblScaleFactor.Enabled = chkLayout.Checked;
            txtScaleFactor.Enabled = chkLayout.Checked;
            if (_saveAsShapefile)
            {
                txtSave.Text = "file name";
                if (MapTitle.Length > 0)
                {
                    txtSave.Text = MapTitle;
                }

                txtSave.SelectAll();
                txtSave.SelectionStart = 0;
            }
            else
            {
                if (global.MainForm.SuggestedDPI > 0)
                {
                    txtSave.Text = ((int)global.MainForm.SuggestedDPI).ToString();
                }
                else
                {
                    txtSave.Text = "150";
                }
                txtScaleFactor.Text = "0.5";


                if (global.MainForm.Grid25MajorGrid != null)
                {
                    if (global.MainForm.Grid25MajorGrid.SaveMapParameters?.DPI != null)
                    {
                        txtSave.Text = ((int)global.MainForm.Grid25MajorGrid.SaveMapParameters.DPI).ToString();
                        chkLayout.Checked = global.MainForm.Grid25MajorGrid.SaveMapParameters.LayoutMap;
                        txtScaleFactor.Text = ((double)global.MainForm.Grid25MajorGrid.SaveMapParameters.LogoScaleFactoer).ToString();
                        _fileName = global.MainForm.Grid25MajorGrid.SaveMapParameters.FileName;
                    }
                    else
                    {
                        global.MainForm.Grid25MajorGrid.SaveMapParameters = new SaveMapParameters();
                    }
                }
            }
            _fileName = "";
        }

        private void OnGrid25SaveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void OnTxtSave_Validating(object sender, CancelEventArgs e)
        {
            if (_saveAsShapefile)
            {
                //input must be an integer
            }
            else
            {
                //input must be a string of reasonable length
            }
        }

        public static void SetSavedMapsFolder(string folderPath)
        {
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            reg_key.SetValue("FolderSavedGrids", folderPath);
        }

        public static string GetSavedMapsFolder()
        {
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            try
            {
                return reg_key.GetValue("FolderSavedGrids").ToString();
            }
            catch
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }

        private void UpdateSaveMapParameters(int dpi, string fileName, double scaleFactor, bool layoutMap)
        {
            if (global.MainForm.Grid25MajorGrid != null)
            {
                global.MainForm.Grid25MajorGrid.SaveMapParameters.SetAllParameters(dpi, fileName, scaleFactor, layoutMap);
            }
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnOptions":
                    break;
                case "btnOK":
                    if (txtSave.Text.Length > 0)
                    {
                        if (_saveAsShapefile)
                        {
                            FolderBrowserDialog fbd = new FolderBrowserDialog();
                            fbd.Description = "Select folder to save fishing ground grid map";
                            fbd.SelectedPath = GetSavedMapsFolder();
                            DialogResult result = FolderBrowserLauncher.ShowFolderBrowser(fbd);
                            if (result == DialogResult.OK && fbd.SelectedPath.Length > 0)
                            {
                                SetSavedMapsFolder(fbd.SelectedPath);
                                if (!_parentForm.Grid25MajorGrid.Save($@"{fbd.SelectedPath}\{txtSave.Text}",true))
                                {
                                    Logger.Log("Not all grid25 shapefiles were saved.", "Grid25SaveForm", "OnButton_Click");
                                }
                                else
                                {
                                    DialogResult = DialogResult.OK;
                                }
                            }
                        }
                        else
                        {
                            if (_fileName.Length > 0
                                && txtSave.Text.Length > 0
                                && int.Parse(txtSave.Text) <= (int)global.MainForm.SuggestedDPI
                                && txtScaleFactor.Text.Length > 0)
                            {
                                if (global.MainForm.SaveMapToImage(int.Parse(txtSave.Text), _fileName, maintainOnePointLineWidth: true, saveToLayout: chkLayout.Checked, scaleFactor: double.Parse(txtScaleFactor.Text)))
                                {
                                    Close();
                                }
                            }
                            else
                            {
                                SaveFileDialog sfd = new SaveFileDialog();
                                sfd.Title = "Provide file name of image file";
                                sfd.Filter = "jpeg|*.jpg|tiff|*.tif";
                                sfd.FilterIndex = 2;
                                sfd.AddExtension = true;
                                sfd.InitialDirectory = GetSavedMapsFolder();
                                DialogResult result = sfd.ShowDialog();
                                if (result == DialogResult.OK && sfd.FileName.Length > 0)
                                {
                                    _fileName = sfd.FileName;
                                    if (global.MainForm.SaveMapToImage(int.Parse(txtSave.Text), _fileName, maintainOnePointLineWidth: true, saveToLayout: chkLayout.Checked, scaleFactor: double.Parse(txtScaleFactor.Text)))
                                    {
                                        UpdateSaveMapParameters(int.Parse(txtSave.Text), _fileName, double.Parse(txtScaleFactor.Text), chkLayout.Checked);
                                        Close();
                                    }
                                    else
                                    {
                                        if (global.MainForm.SuggestedDPI > 0)
                                        {
                                            txtSave.Text = ((int)global.MainForm.SuggestedDPI).ToString();
                                        }
                                        else

                                        {
                                            Logger.Log("Was not able to save map to image.", "Grid25SaveForm", "OnButton_Click SaveMapToImage");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;

                case "btnCancel":
                    DialogResult = DialogResult.Cancel;
                    break;
            }
        }

        private void OnCheckChanged(object sender, EventArgs e)
        {
            lblScaleFactor.Enabled = chkLayout.Checked;
            txtScaleFactor.Enabled = chkLayout.Checked;
        }
    }
}