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
using MapWinGIS;
using GridMapper.views;
using AxMapWinGIS;
using System.IO;
using Microsoft.VisualBasic.PowerPacks;

namespace GridMapper
{
    public partial class MainForm : Form
    {
        private Graticule _graticule;
        private bool _hasSubGrid;
        private int _subGridCount;
        private Grid25LayoutHelperForm _g25lhf;
        private SaveMapImage _saveMapImage;
        private MapWinGIS.Image _savedMapImage;
        private MapLayer _currentMapLayer;
        private Dictionary<string, uint> _labelAndGridProperties = new Dictionary<string, uint>();
        private bool _hasUnsavedMap;
        private double _dragWidth;
        private double _dragHeight;
        private bool _gridFromFileLoaded;
        private fad3MappingMode _mappingMode;
        public MainForm()
        {
            InitializeComponent();
            global.MainForm = this;
            Grid25MajorGrid = new Grid25MajorGrid(this.mapControl);
            MapLayersHandler = new MapLayersHandler(mapControl);
            MapInterActionHandler = new MapInterActionHandler(mapControl, MapLayersHandler);
            SetPanel1Visibility(false);

        }
        public float SuggestedDPI { get; set; }

        private void SetupGridElementUI()
        {
            txtMinorGridLabelDistance.Text = "1000";
            txtMinorGridLabelSize.Text = "8";
            txtMajorGridLabelSize.Text = "12";
            txtBorderThickness.Text = "2";
            txtMajorGridThickness.Text = "2";
            txtMinorGridThickness.Text = "1";
            txtSubGridThickness.Text = "1";
            txtTitleDistance.Text = "1";
            txtFootnoteSize.Text = "8";
            chkLeft.Checked = true;
            chkTop.Checked = true;
            chkRight.Checked = true;
            chkBottom.Checked = true;
            //chkIncludeCredits.Checked = true;

            Grid25MajorGrid.TitleDistanceFactor = double.Parse(txtTitleDistance.Text);
        }
        private void OnFormLoad(object sender, EventArgs e)
        {
            SetPanel1Visibility(false);
            splitter.Visible = false;
            if (global.IsMapComponentRegistered)
            {
                splitter.Visible = true;
                buttonSubGrid.Enabled = false;
                Text = "FAD Grid Mapper v1";
                SetCursor(tkCursorMode.cmSelection);
                mapControl.Visible = false;
                GlobalSettings gs = new GlobalSettings();
                gs.LocalizedString[tkLocalizedStrings.lsMeters] = "m";
                //gs.set_LocalizedString(tkLocalizedStrings.lsKilometers) = "км";
                splitter.SplitterDistance = 300;
                MapControl = mapControl;
                MappingMode = fad3MappingMode.grid25Mode;
                global.MainForm = this;
                tsCBO.SelectedIndex = 0;
                mapControl.TileProvider = tkTileProvider.ProviderNone;
                //SetupGridElementUI();
                mapControl.Visible = true;
                mapControl.Dock = DockStyle.Fill;


                chkIncludeCredits.Checked = true;
            }


        }
        private void SetPanel1Visibility(bool visible = true)
        {
            //txtMapTitle.Visible = visible;
            //groupLabels.Visible = visible;
            foreach (Control c in splitter.Panel1.Controls)
            {
                c.Visible = visible;
            }

        }

        public fad3MappingMode MappingMode
        {
            get { return _mappingMode; }
            set
            {
                _mappingMode = value;
                global.MappingMode = _mappingMode;
                //MapLayersHandler.layers
            }
        }
        public void GridMapStatusUpdate(double top, double left, double right, double bottom,
             bool inDrag, bool fromFile = false)
        {
            _dragWidth = Math.Abs(left - right);
            _dragHeight = Math.Abs(top - bottom);
            if (inDrag)
            {
                lblGridStatus.Text = "Defining map dimensions:\r\n" +
                 "Height: " + (_dragHeight / 1000).ToString("N1") + " km\r\n" +
                 "Width:" + (_dragWidth / 1000).ToString("N1") + " km";
            }
            else
            {
                if (fromFile)
                {
                    _gridFromFileLoaded = true;
                    lblGridStatus.Text = "Grid map dimension:";
                }
                else
                {
                    _gridFromFileLoaded = false;
                    lblGridStatus.Text = "Final map dimension:";
                }
                lblGridStatus.Text += "\r\nHeight: " + (_dragHeight / 1000).ToString("N1") + " km" +
                     "\r\nWidth: " + (_dragWidth / 1000).ToString("N1") + " km";
            }
            lblGridStatus.Text += "\r\nRows x Columns : " + ((int)((_dragHeight / 1000) / 2)).ToString("") + " x " + ((int)((_dragWidth / 1000) / 2)).ToString();

            if (_gridFromFileLoaded)
            {
                chkWrapLabels.Enabled = false;
                chkWrapLabels.Checked = false;
            }
        }

        public bool SaveMapToImage(double dpi, string fileName, bool preview = true, bool maintainOnePointLineWidth = false, bool saveToLayout = false, double? scaleFactor = null)
        {
            var success = false;
            _saveMapImage = new SaveMapImage(fileName, dpi, mapControl);
            _saveMapImage.DPI = dpi;
            _saveMapImage.MinorGridLineWidth = Grid25MajorGrid.MinorGrids.MinorGridLineWidth;
            if (scaleFactor != null)
            {
                _saveMapImage.LogoScaleFactor = (double)scaleFactor;
            }

            if (global.MappingMode == fad3MappingMode.defaultMode)
            {
                _saveMapImage.TitleDistanceFactor = 1;
            }
            else if (Grid25MajorGrid != null)
            {
                _saveMapImage.TitleDistanceFactor = Grid25MajorGrid.TitleDistanceFactor;
            }
            else
            {
                _saveMapImage.TitleDistanceFactor = 1;
            }


            //_saveMapImage = SaveMapImage.GetInstance(axMap, dpi);
            //_saveMapImage = SaveMapImage.GetInstance();
            //_saveMapImage.MapControl = axMap;
            //_saveMapImage.FileName = fileName;
            _saveMapImage.SaveToLayout = saveToLayout;
            _saveMapImage.PreviewImage = preview;
            _saveMapImage.MapLayersHandler = MapLayersHandler;
            _saveMapImage.MaintainOnePointLineWidth = maintainOnePointLineWidth;
            _saveMapImage.PointSizeExceed100Error += OnPointSizeRenderError;
            success = _saveMapImage.Save(Grid25MajorGrid != null);

            _savedMapImage = null;
            if (success)
            {
                _savedMapImage = _saveMapImage.SavedMapImage;
                //if (_saveMapImage.MapToPreview.Length > 0 && File.Exists(_saveMapImage.MapToPreview))
                //{
                //    PreViewMapImageForm pvm = PreViewMapImageForm.GetInstance();
                //    if (pvm.Visible)
                //    {
                //        pvm.BringToFront();
                //    }
                //    else
                //    {
                //        pvm.Show(this);
                //    }
                //    pvm.MapFileName = _saveMapImage.MapToPreview;
                //}

            }

            try
            {
                _saveMapImage.Dispose();
            }
            catch
            {
                //ignore
            }


            return success;
        }
        public void SetCursor(tkCursorMode cursorMode)
        {
            Bitmap b = new Bitmap(Properties.Resources.pan);
            switch (cursorMode)
            {
                case tkCursorMode.cmNone:
                    mapControl.MapCursor = tkCursor.crsrCross;
                    return;
                case tkCursorMode.cmPan:
                    mapControl.CursorMode = tkCursorMode.cmPan;
                    break;

                case tkCursorMode.cmSelection:
                    b = new Bitmap(Properties.Resources.arrow32);
                    mapControl.CursorMode = tkCursorMode.cmSelection;
                    break;
            }

            b.MakeTransparent(b.GetPixel(0, 0));
            Graphics g = Graphics.FromImage(b);
            IntPtr ptr = b.GetHicon();
            mapControl.MapCursor = tkCursor.crsrUserDefined;
            mapControl.UDCursorHandle = (int)ptr;
        }
        private void OnPointSizeRenderError(object sender, EventArgs e)
        {
            MessageBox.Show("Error in rendering map being saved. A point size exceeded 100\r\n"
                + "Use lower resolution when saving map",
                "Map rendering error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SuggestedDPI = _saveMapImage.SuggestedDPI;
        }

        public AxMap MapControl { get; internal set; }
        public fadUTMZone UTMZone { get; private set; }
        public void CreateGrid25MajorGrid(fadUTMZone utmZone)
        {
            UTMZone = utmZone;
            Grid25MajorGrid = new Grid25MajorGrid(mapControl);
            Grid25MajorGrid.UTMZone = utmZone;
            Grid25MajorGrid.GenerateMajorGrids();
            Grid25MajorGrid.MaplayersHandler = MapLayersHandler;
            Grid25MajorGrid.MapInterActionHandler = MapInterActionHandler;
            mapControl.GeoProjection.SetWgs84Projection(Grid25MajorGrid.Grid25Geoprojection);
            mapControl.MapUnits = tkUnitsOfMeasure.umMeters;
            //mapControl.Redraw();

            var h = MapLayersHandler.AddLayer(Grid25MajorGrid.Grid25Grid, "Grid25", true, true);
            MapLayersHandler.LoadMapState(false);
            Grid25MajorGrid.MoveToTop();
            MapLayersHandler.set_MapLayer(h);
            Grid25MajorGrid.ExtentCreatedInLayer += Grid25MajorGrid_ExtentCreatedInLayer;
        }

        private void Grid25MajorGrid_ExtentCreatedInLayer(Grid25MajorGrid s, ExtentDraggedBoxEventArgs e)
        {
            buttonSubGrid.Enabled = Grid25MajorGrid.MinorGrids.MinorGridLinesShapeFile?.NumShapes > 0;
        }

        public Grid25MajorGrid Grid25MajorGrid { get; private set; }

        public MapLayersHandler MapLayersHandler { get; private set; }

        public MapInterActionHandler MapInterActionHandler { get; private set; }

        public string FishingGround { get; internal set; }
        public string LayoutGridSaveFolder { get; internal set; }
        public bool HasSubGrid { get { return _hasSubGrid; } }
        public int SubGridCount { get { return _subGridCount; } }

        public void MapTitle(string mapTitle)
        {
            txtMapTitle.Text = mapTitle;
        }

        public Grid25LayoutHelperForm LayoutHelperForm
        {
            get { return _g25lhf; }
        }

        private void CleanUp()
        {
            if (Grid25MajorGrid != null)
            {
                Grid25MajorGrid.Dispose();
                Grid25MajorGrid = null;

                MapLayersHandler.Dispose();
                MapInterActionHandler.Dispose();
                GC.Collect();
            }
            MapControl.Dispose();
            Dispose();
        }

        private void OnTSButtonClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsButtonFitMap":
                    Grid25MajorGrid.FitGridToMap();
                    break;


                case "tsButtonSaveImage":
                case "tsButtonSaveShapefile":
                    if (txtMapTitle.Text.Length > 0 && Grid25MajorGrid.HasGrid)
                    {
                        RedoGridLabel();
                        using (var saveForm1 = new SaveMapForm(this))
                        {
                            saveForm1.SaveType(SaveAsShapefile: e.ClickedItem.Name == "tsButtonSaveShapefile");
                            saveForm1.MapTitle = txtMapTitle.Text;
                            saveForm1.ShowDialog(this);
                            if (saveForm1.DialogResult == DialogResult.OK)
                            {
                                _hasUnsavedMap = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide map title and fishing grid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "tsButtonMBRs":
                    break;
                case "tsButtonRetrieve":
                    break;
                case "tsButtonXY":
                    var g25MouseCoordForm = Grid25CoordinateForm.GetInstance(MapControl, Grid25MajorGrid);
                    if (g25MouseCoordForm.Visible)
                    {
                        g25MouseCoordForm.BringToFront();
                    }
                    else
                    {
                        g25MouseCoordForm.Show(this);
                    }
                    break;
                //     case "tsButtonSaveState":
                //MapLayersHandler.SaveMapState();
                //break;
                case "tsButtonLayers":
                    var mlf = MapLayersForm.GetInstance(MapLayersHandler, this);
                    if (!mlf.Visible)
                    {
                        mlf.Show(this);
                    }
                    else
                    {
                        mlf.BringToFront();
                        mlf.Focus();
                    }

                    break;
                case "tsButtonLayerAdd":
                    OpenFileDialog();
                    break;
                case "tsButtonAttributes":

                    if (MapLayersHandler.CurrentMapLayer != null)
                    {
                        EditShapeAttributeForm esaf = EditShapeAttributeForm.GetInstance(this, MapInterActionHandler);
                        if (esaf.Visible)
                        {
                            esaf.BringToFront();
                        }
                        else
                        {
                            esaf.Show(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a layer", "No selected layer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "tsButtonTileVisibility":
                    SelectTileProvider();
                    break;
                case "tsButtonPan":
                    SetCursor(tkCursorMode.cmPan);
                    break;
                case "tsButtonZoomIn":
                    MapControl.MapCursor = tkCursor.crsrUserDefined;
                    MapControl.UDCursorHandle = (int)((Bitmap)e.ClickedItem.Image).GetHicon();
                    MapControl.CursorMode = tkCursorMode.cmZoomIn;
                    break;

                case "tsButtonZoomOut":
                    MapControl.MapCursor = tkCursor.crsrUserDefined;
                    MapControl.UDCursorHandle = (int)((Bitmap)e.ClickedItem.Image).GetHicon();
                    MapControl.CursorMode = tkCursorMode.cmZoomOut;
                    break;
                case "tsButtonBlackArrow":
                    SetCursor(tkCursorMode.cmSelection);
                    //axMap.CursorMode = tkCursorMode.cmNone;
                    //SetCursor(tkCursorMode.cmNone);
                    break;
                case "tsButtonZoomAll":
                    MapControl.ZoomToMaxExtents();
                    break;
                case "tsButtonZoomPrevious":
                    MapControl.ZoomToPrev();
                    break;

                case "tsButtonMeasure":
                    MapControl.CursorMode = tkCursorMode.cmMeasure;
                    MapControl.MapCursor = tkCursor.crsrMapDefault;
                    break;
                case "tsButtonClearSelection":
                    if (_currentMapLayer != null && _currentMapLayer.LayerType == "ShapefileClass")
                    {
                        MapLayersHandler.ClearSelection(_currentMapLayer.Handle);
                    }
                    break;

                case "tsButtonClearAllSelection":
                    MapLayersHandler.ClearAllSelections();
                    break;
                case "tsButtonGraticule":
                    ShowGraticuleForm();
                    break;
                case "tsButtonSaveImage1":
                    var saveForm = new SaveMapForm();

                    saveForm.SaveType(SaveAsShapefile: false);
                    saveForm.ShowDialog(this);
                    break;
                case "tsButtonCloseMap":
                    if (_saveMapImage != null)
                    {
                        _saveMapImage.PointSizeExceed100Error -= OnPointSizeRenderError;
                    }
                    CleanUp();
                    Close();
                    break;

            }
        }

        private void SelectTileProvider()
        {
            SelectTileProviderWindow stw = new SelectTileProviderWindow();
            var dr = stw.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var providerID = stw.TileProviderID;
                MapControl.TileProvider = (tkTileProvider)Enum.Parse(typeof(tkTileProvider), providerID.ToString());
            }
        }
        public Graticule Graticule
        {
            get { return _graticule; }
        }
        public void ShowGraticuleForm()
        {
            _graticule = new Graticule(mapControl, MapLayersHandler);
            var gf = GraticuleForm.GetInstance(this);
            if (!gf.Visible)
            {
                gf.Show(this);
            }
            else
            {
                gf.BringToFront();
            }
            //if (MapLegend != null)
            //{
            //    MapLegend.Graticule = _graticule;
            //}
            gf.GraticuleRemoved += OnGraticuleRemoved;
        }

        public string SaveTempMapToImage(double dpi = 96)
        {
            string fileName = string.Empty;
            _saveMapImage = new SaveMapImage(mapControl);
            _saveMapImage.MapLayersHandler = MapLayersHandler;
            if (_saveMapImage.SaveToTempFile(dpi))
            {
                fileName = _saveMapImage.TempMapFileName;
                _saveMapImage.Dispose();
                _saveMapImage = null;
            }
            return fileName;
        }
        private void OnGraticuleRemoved(object sender, EventArgs e)
        {
            if (_graticule != null)
            {
                _graticule.Dispose();
                _graticule = null;
                //MapLegend.Graticule = null;
            }
        }

        public MapLayer CurrentMapLayer
        {
            get { return _currentMapLayer; }
        }
        public DialogResult OpenFileDialog()
        {
            string filename = "";
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Open a GIS layer",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            var initialDirectory = RegistryTools.GetSetting("FAD3", "LastOpenedLayerDirectory", "");
            if (initialDirectory.ToString().Length > 0)
            {
                ofd.InitialDirectory = initialDirectory.ToString();
            }

            ofd.Filter = "ESRI Shapefile (shp)|*.shp|" +
                           "KML files (kml)|*.kml|" +
                           "Georeferenced raster files (jpg, tiff,bmp)|*.jpg;*.tif;*.tiff;*.bmp|" +
                           "Other files |*.*)";
            ofd.FilterIndex = 1;

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK && ofd.FileName.Length > 0)
            {
                filename = ofd.FileName;

                var (success, errMsg) = MapLayersHandler.FileOpenHandler(filename);
                if (!success)
                {
                    MessageBox.Show(errMsg, "Error in opening file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.Cancel;
                }
            }
            return dr;
        }
        private uint FactorBy100(string property)
        {
            return (uint)(double.Parse(property) * 100);
        }

        private uint ColorToUInt(Color clr)
        {
            return (uint)(clr.R + (clr.G << 8) + (clr.B << 16));
        }
        public void SetupDictionary()
        {
            _labelAndGridProperties.Clear();
            _labelAndGridProperties.Add("minorGridLabelDistance", uint.Parse(txtMinorGridLabelDistance.Text));
            _labelAndGridProperties.Add("minorGridLabelSize", uint.Parse(txtMinorGridLabelSize.Text));
            _labelAndGridProperties.Add("majorGridLabelSize", uint.Parse(txtMajorGridLabelSize.Text));
            _labelAndGridProperties.Add("borderThickness", FactorBy100(txtBorderThickness.Text));
            _labelAndGridProperties.Add("majorGridThickness", FactorBy100(txtMajorGridThickness.Text));
            _labelAndGridProperties.Add("minorGridThickness", FactorBy100(txtMinorGridThickness.Text));
            _labelAndGridProperties.Add("minorGridLabelColor", ColorToUInt(shapeMinorGridLabelColor.FillColor));
            _labelAndGridProperties.Add("majorGridLabelColor", ColorToUInt(shapeMajorGridLabelColor.FillColor));
            _labelAndGridProperties.Add("borderColor", ColorToUInt(shapeBorderColor.FillColor));
            _labelAndGridProperties.Add("majorGridLineColor", ColorToUInt(shapeMajorGridLineColor.FillColor));
            _labelAndGridProperties.Add("minorGridLineColor", ColorToUInt(shapeMinorGridLineColor.FillColor));
            _labelAndGridProperties.Add("minorGridLabelFontBold", (uint)(chkBold.Checked ? 1 : 0));
            _labelAndGridProperties.Add("minorGridLabelWrapped", (uint)(chkWrapLabels.Checked ? 1 : 0));
            _labelAndGridProperties.Add("subGridLineThickness", FactorBy100(txtSubGridThickness.Text));
            _labelAndGridProperties.Add("subGridLineColor", ColorToUInt(shapeSubGridLineColor.FillColor));
            _labelAndGridProperties.Add("footnoteSize", uint.Parse(txtFootnoteSize.Text));
            _labelAndGridProperties.Add("includeCredits", (uint)(chkIncludeCredits.Checked ? 1 : 0));
            //_labelAndGridProperties.Add("titleDistanceFactor", uint.Parse(txtTitleDistance.Text));
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "buttonGrid":
                    if (txtMinorGridLabelDistance.Text.Length > 0 && txtMinorGridLabelSize.Text.Length > 0)
                    {
                        SetupDictionary();
                        if (Grid25MajorGrid.DefineMinorGrid((int)((Bitmap)imList.Images["gridCursor"]).GetHicon()))
                        {
                            Grid25MajorGrid.LabelAndGridProperties = _labelAndGridProperties;
                            Grid25MajorGrid.MapTitle = txtMapTitle.Text;
                            _hasUnsavedMap = true;
                        }
                        else
                        {
                            MessageBox.Show("No selection in major grid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Provide minor grid label distance and minor grid label size", "Validation error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "buttonClear":
                    if (Grid25MajorGrid.LayoutHelper?.LayoutShapeFile?.NumShapes > 0)
                    {
                        Grid25MajorGrid.LayoutHelper.ClearLayout();
                    }

                    Grid25MajorGrid.ClearSelectedGrids();
                    SetCursor(MapWinGIS.tkCursorMode.cmSelection);
                    Grid25MajorGrid.MaplayersHandler.set_MapLayer(Grid25MajorGrid.Grid25ShapefileHandle, refreshLayerList: true);
                    buttonSubGrid.Enabled = false;
                    _hasSubGrid = false;
                    break;
                case "buttonLocateGrid":
                    if (Grid25MajorGrid.SelectedShapeGridNumbers.Count > 0 || Grid25MajorGrid.LayoutHelper != null)
                    {
                        if (txtMinorGridLabelDistance.Text.Length > 0 && txtMinorGridLabelSize.Text.Length > 0)
                        {
                            SetupDictionary();
                            Grid25MajorGrid.LabelAndGridProperties = _labelAndGridProperties;

                            //this will create a layouthelper object for the gri25majorgrid
                            Grid25MajorGrid.DefineGridLayout((int)((Bitmap)imList.Images["gridLayout"]).GetHicon());

                            _g25lhf = Grid25LayoutHelperForm.GetInstance(Grid25MajorGrid, this);

                            if (_g25lhf.Visible)
                            {
                                _g25lhf.BringToFront();
                            }
                            else
                            {
                                _g25lhf.Show(this);
                            }

                            if (Grid25MajorGrid.LayoutHelper != null && Grid25MajorGrid.LayoutHelper.LayoutShapeFile != null)
                            {
                                _g25lhf.SetUpFields();
                            }
                            SetupGridButtons(enabled: false);
                        }
                        else
                        {
                            MessageBox.Show("Provide minor grid label distance and minor grid label size", "Validation error",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No selection in major grid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "buttonOpenLayoutGrid":
                    OpenTemplate();
                    break;
                case "buttonSubGrid":
                    using (Grid25SubGridForm sgf = new Grid25SubGridForm())
                    {
                        sgf.SubGridCount = Grid25MajorGrid.SubGridCount;
                        sgf.ShowDialog();
                        if (sgf.DialogResult == DialogResult.OK)
                        {
                            _hasSubGrid = true;
                            _subGridCount = sgf.SubGridCount;
                            Grid25MajorGrid.HasSubgrid = _hasSubGrid;
                            Grid25MajorGrid.SubGridCount = _subGridCount;

                            Grid25MajorGrid.MinorGrids.EnsureSize = true;
                            Grid25MajorGrid.GenerateMinorGridInsidePanelExtent(Grid25MajorGrid.MinorGrids.MinorGridLinesShapeFile.Extents, "");
                        }
                    }
                    break;
                case "buttonLabel":
                    if (Grid25MajorGrid.Grid25LabelManager != null && Grid25MajorGrid.Grid25LabelManager.Grid25Labels.NumShapes > 0)
                    {
                        RedoGridLabel();
                    }
                    break;
            }
        }
        private void OnShapeColor_DoubleClick(object sender, EventArgs e)
        {
            var cd = new ColorDialog
            {
                AllowFullOpen = true,
                AnyColor = true,
                FullOpen = true,
                SolidColorOnly = true,
            };
            var r = cd.ShowDialog();
            if (r == DialogResult.OK)
            {
                ((RectangleShape)sender).FillColor = cd.Color;
            }
        }
        public void OpenTemplate()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a layout grid template file";
            ofd.Filter = "Layout file|*.lay|All files|*.*";
            ofd.FilterIndex = 0;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK
                && Path.GetExtension(ofd.FileName) == ".lay")
            {
                Grid25MajorGrid.LabelAndGridProperties = _labelAndGridProperties;

                //creates a layouthelper object for grid25majorgrid
                Grid25MajorGrid.DefineGridLayout();

                if (Grid25MajorGrid.LayoutHelper.OpenLayoutFile(ofd.FileName))
                {
                    string line;
                    List<int> selectedGridHandles = new List<int>();
                    StreamReader file = new StreamReader(ofd.FileName);

                    while ((line = file.ReadLine()) != null)
                    {
                        string[] line2 = line.Split(':');
                        switch (line2[0])
                        {
                            case "SelectedMajorGrids":
                                foreach (var item in line2[1].Split(','))
                                {
                                    selectedGridHandles.Add(int.Parse(item));
                                }
                                //sends a list of major grids that will be selected
                                Grid25MajorGrid.SelectedShapeGridNumbers = selectedGridHandles;

                                //sends a list of major grids that will be used to create an extent of major grid
                                Grid25MajorGrid.LayoutHelper.SelectedMajorGridList(selectedGridHandles);
                                break;

                            case "Fishing ground":
                                Grid25MajorGrid.LayoutHelper.FishingGround = line2[1];
                                break;

                            case "Save folder":
                                string folder = $"{line2[1]}:{line2[2]}";
                                Grid25MajorGrid.LayoutHelper.GridFromLayoutSaveFolder = folder;
                                Grid25MajorGrid.FolderToSave = folder;
                                break;

                            case "Rows":
                                Grid25MajorGrid.LayoutHelper.Rows = int.Parse(line2[1]);
                                break;

                            case "Columns":
                                Grid25MajorGrid.LayoutHelper.Columns = int.Parse(line2[1]);
                                break;

                            case "Overlap":
                                Grid25MajorGrid.LayoutHelper.Overlap = int.Parse(line2[1]);
                                break;
                        }
                    }

                    Grid25MajorGrid.MaplayersHandler.RefreshLayers();
                }
            }
            else
            {
                if (ofd.FileName.Length > 0)
                {
                    MessageBox.Show("Selected file is not valid", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void SetupGridButtons(bool enabled)
        {
            buttonGrid.Enabled = enabled;
            buttonClear.Enabled = enabled;
            buttonLocateGrid.Enabled = enabled;
            buttonOpenLayoutGrid.Enabled = enabled;
            // buttonSubGrid.Enabled = enabled;
        }
        private void RedoGridLabel()
        {
            SetupDictionary();
            Grid25MajorGrid.RedoLabels(txtMapTitle.Text, _labelAndGridProperties, double.Parse(txtTitleDistance.Text));
            Grid25MajorGrid.ApplyGridSymbology(txtMapTitle.Text);
        }

        private void OnCBOChange(object sender, EventArgs e)
        {
            tsButtonSelectTile.Enabled = false;
            tsButtonSaveState.Enabled = false;
            MapLayersHandler.RemoveAllLayers();
            //Grid25MajorGrid.Dispose();
            switch (tsCBO.Text)
            {
                case "WGS84":
                    SetPanel1Visibility(false);
                    splitter.Panel1MinSize = 0;
                    splitter.SplitterDistance = 0;
                    tsButtonSaveState.Enabled = true;
                    tsButtonSelectTile.Enabled = true;
                    global.MappingMode = fad3MappingMode.defaultMode;
                    GeoProjection gp = new GeoProjection();
                    gp.SetWgs84();
                    mapControl.GeoProjection = gp;
                    MapLayersHandler.LoadMapState();
                    break;
                case "Grid UTM Zone 50":
                    global.MappingMode = fad3MappingMode.grid25Mode;
                    CreateGrid25MajorGrid(fadUTMZone.utmZone50N);
                    //mapControl.GeoProjection = Grid25MajorGrid.Grid25Geoprojection
                    break;
                case "Grid UTM Zone 51":
                    global.MappingMode = fad3MappingMode.grid25Mode;
                    CreateGrid25MajorGrid(fadUTMZone.utmZone51N);
                    break;
            }
            if (tsCBO.Text == "Grid UTM Zone 50" || tsCBO.Text == "Grid UTM Zone 51")
            {
                txtMapTitle.Text = "";
                SetupGridElementUI();
                splitter.Panel1MinSize = 300;
                splitter.SplitterDistance = 300;
                SetPanel1Visibility(true);
                SetCursor(tkCursorMode.cmSelection);
            }
        }

        private void OnMenuItemSelected(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "noTileMenuItem":
                    MapControl.TileProvider = tkTileProvider.ProviderNone;
                    break;
                case "selectTileMenuItem":
                    SelectTileProvider();
                    break;
                case "resetMapStateMenuItem":
                    var f = $@"{Application.StartupPath}\mapstate";
                    if (File.Exists(f))
                    {
                        File.Delete(f);
                    }
                    break;
                case "saveMapStateMenuItem":
                    MapLayersHandler.SaveMapState();
                    break;
            }
        }
    }
}
