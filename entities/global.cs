/*
 * Created by SharpDevelop.
 * User: Raffy
 * Date: 8/8/2016
 * Time: 11:01 AM
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Net;
using System.Linq;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

using System.Xml;
namespace GridMapper.entities
{
    /// <summary>
    /// Description of global.
    /// </summary>
    ///
    public static class global
    {
        private static List<string> _listBarangays = new List<string>();
        private static Dictionary<string, string> _vesselTypeDict = new Dictionary<string, string>();
        private static Dictionary<long, string> _provinceDict = new Dictionary<long, string>();
        private static Dictionary<long, string> _munDict = new Dictionary<long, string>();
        private static string _mdbPath = "";
        private static string _connectionString = "";
        private static string _appPath = "";
        private static bool _showErrorMessage = false;
        private static bool _hasMPH = false;
        private static bool _mapIsOpen;
        private static string _templateMDBFile = "";
        private static readonly string _connectionStringTemplate = "";
        private static bool _templateFileExists = true;
        private static bool _uiTemplateFileExists = true;
        private static bool _inlandGridDBFileExists = true;
        private static bool _allRequiredFilesExists = true;
        private static CoordinateDisplayFormat _coordDisplayFormat = CoordinateDisplayFormat.DegreeDecimal;
        private static Color _missingFieldBackColor = global.MissingFieldBackColor;
        private static List<string> _tempFiles = new List<string>();
        private static bool _isMapComponentRegistered;
        public static event EventHandler MapperOpen;
        public static event EventHandler MapperClosed;

        public static bool IsMapComponentRegistered
        {
            get { return _isMapComponentRegistered; }
        }

        public static string FrameWorkDescription()
        {
            return RuntimeInformation.FrameworkDescription;
        }
        public static MainForm MainForm { get; set; }
        public static bool HasInternet { get; private set; }
        public static bool HasInternetConnection()
        {
            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    using (var client = new WebClient())
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        HasInternet = true;
                        return true;
                    }
                }
                else
                {
                    HasInternet = false;
                    return false;
                }
            }
            catch
            {
                HasInternet = false;
                return false;
            }
        }
        public static string IsValidXMLFile(string xmlFile)
        {
            string xml = File.OpenText(xmlFile).ReadToEnd();
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                try
                {
                    var result = reader.Read();
                }
                catch (XmlException)
                {
                    return "Invalid XML";
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    return ex.Message;
                }
                return "Valid XML";
            }
        }
        //public static Grid25GenerateForm Grid25GenerateForm { get; set; }

        public static string checkMD5(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return System.Text.Encoding.Default.GetString(md5.ComputeHash(stream));
                }
            }
        }

        public static string CleanString(string inString)
        {
            var s = "";
            for(int x=0;x<inString.Length;x++)
            {
                var c = inString[x];
                if(c != '\'' || c != '"' || c != '\\')
                {
                    s += c;
                }
            }
            return s;
        }


        public static string EllipsisString(this string rawString, int maxLength = 30, char delimiter = '\\')
        {
            maxLength -= 3; //account for delimiter spacing

            if (rawString.Length <= maxLength || !rawString.Contains(delimiter))
            {
                return rawString;
            }

            string final = rawString;
            List<string> parts;

            int loops = 0;
            while (loops++ < 100)
            {
                parts = rawString.Split(delimiter).ToList();
                parts.RemoveRange(parts.Count - 1 - loops, loops);
                if (parts.Count == 1)
                {
                    return parts.Last();
                }

                parts.Insert(parts.Count - 1, "...");
                final = string.Join(delimiter.ToString(), parts);
                if (final.Length < maxLength)
                {
                    return final;
                }
            }

            return rawString.Split(delimiter).ToList().Last();
        }

        //public static bool HasInternetConnection()
        //{
        //    try
        //    {
        //        if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
        //        {
        //            using (var client = new WebClient())
        //            using (client.OpenRead("http://clients3.google.com/generate_204"))
        //            {
        //                return true;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public static fad3MappingMode MappingMode { get; set; }

        /// <summary>
        /// String. Returns the files required by the application that are missing
        /// </summary>

        private static void IsMapWinGISRegistered()
        {
            try
            {
                var key = Registry.ClassesRoot.OpenSubKey("MapWinGIS.Shapefile");
                if (key == null)
                {
                    _isMapComponentRegistered = false;
                }
                else
                {
                    _isMapComponentRegistered = key.Name.Length > 0;
                }
            }
            catch
            {
                _isMapComponentRegistered = false;
            }
        }

        public static void Cleanup()
        {

        }



        public static bool MapIsOpen
        {
            get { return _mapIsOpen; }
        }

        public static string TemplateMDBFile
        {
            get { return _templateMDBFile; }
        }


        public static Color ConflictColor1
        {
            get { return Color.Yellow; }
        }

        public static Color ConflictColor2
        {
            get { return Color.Gold; }
        }

        public static Color MissingFieldBackColor
        {
            get { return _missingFieldBackColor; }
        }

        private static void GetAppPreferences()
        {
            //the values here should be from an external source to prevent hardcoding
            _missingFieldBackColor = Color.Orange;
        }


        /// <summary>
        /// returns a list that will fill a tree containing target areas and landing sites
        /// </summary>
        /// <returns></returns>

        public static string CoordinateFormatCode
        {
            get
            {
                var coordinateformat = "D";
                switch (CoordinateDisplay)
                {
                    case CoordinateDisplayFormat.DegreeDecimal:
                        break;

                    case CoordinateDisplayFormat.DegreeMinute:
                        coordinateformat = "DM";
                        break;

                    case CoordinateDisplayFormat.DegreeMinuteSecond:
                        coordinateformat = "DMS";
                        break;

                    case CoordinateDisplayFormat.UTM:
                        break;
                }

                return coordinateformat;
            }
        }

        public static CoordinateDisplayFormat CoordinateDisplay
        {
            get { return _coordDisplayFormat; }
            set
            {
                _coordDisplayFormat = value;
                SaveCoordinateDisplayFormat();
            }
        }



        /// <summary>
        /// Boolean. Whether or not the mdb of inland grid is present
        /// </summary>
        public static bool InlandGridDBFileExists
        {
            get { return _inlandGridDBFileExists; }
        }

        public static void ListTemporaryFile(string fileName)
        {
            if (!_tempFiles.Contains(fileName))
            {
                _tempFiles.Add(fileName);
            }
        }

        public static void ResetConnectionString()
        {
            _connectionString = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + _mdbPath;
        }
        /// <summary>
        /// Class constructor
        /// </summary>
        static global()
        {
            IsMapWinGISRegistered();
            _appPath = Application.StartupPath;
            MappingMode = fad3MappingMode.defaultMode;
            GetAppPreferences();
            GetCoordinateDisplayFormat();
        }

        /// <summary>
        /// Test if the files required by the application to run are present
        /// </summary>
        public static bool TestRequiredFilesExists()
        {
            _uiTemplateFileExists = File.Exists(ApplicationPath + "\\UITable.xml");
            _templateFileExists = File.Exists(_templateMDBFile);
            _inlandGridDBFileExists = File.Exists(ApplicationPath + "\\grid25inland.mdb");
            _allRequiredFilesExists = _uiTemplateFileExists && _templateFileExists && _inlandGridDBFileExists;
            if (_allRequiredFilesExists)
            {
                RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
                if(reg_key!=null)
                {
                    reg_key.SetValue("ApplicationPath", ApplicationPath);
                }
                
            }
            else
            {
                RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
                reg_key.SetValue("ApplicationPath", "");
            }
            return _allRequiredFilesExists;
        }

        /// <summary>
        /// String. Returns the application path
        /// </summary>
        public static string ApplicationPath
        {
            get { return _appPath; }
        }

        /// <summary>
        /// Dictionary. Returns vessel types
        /// </summary>
        public static Dictionary<string, string> VesselTypeDict
        {
            get { return _vesselTypeDict; }
        }

        /// <summary>
        /// set window position from registry
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="GetPosition"></param>
        public static void LoadFormSettings(Form frm, bool GetPosition = false)
        {
            // Load form settings.
            if (GetPosition)
            {
                frm.Location = new System.Drawing.Point(
                    (int)GetSetting(frm.Name, "FormLeft", frm.Left),
                    (int)GetSetting(frm.Name, "FormTop", frm.Top)
                    );
            }
            else
            {
                frm.SetBounds(
                    (int)GetSetting(frm.Name, "FormLeft", frm.Left),
                    (int)GetSetting(frm.Name, "FormTop", frm.Top),
                    (int)GetSetting(frm.Name, "FormWidth", frm.Width),
                    (int)GetSetting(frm.Name, "FormHeight", frm.Height));
            }
            frm.WindowState = (FormWindowState)GetSetting(frm.Name, "FormWindowState", frm.WindowState);
        }

        /// <summary>
        /// Get one of a form's position value
        /// </summary>
        /// <param name="formName"></param>
        /// <param name="name"></param>
        /// <param name="default_value"></param>
        /// <returns></returns>
        private static object GetSetting(string formName, string name, object default_value)
        {
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            RegistryKey sub_key = reg_key.CreateSubKey("FORMSTATE");
            RegistryKey sub_key1 = sub_key.CreateSubKey(formName);
            return sub_key1.GetValue(name, default_value);
        }

        /// <summary>
        /// save window position to registry
        /// </summary>
        /// <param name="frm"></param>
        public static void SaveFormSettings(Form frm)
        {
            // Save form settings.
            SaveSetting(frm.Name, "FormWindowState", (int)frm.WindowState);
            if (frm.WindowState == FormWindowState.Normal)
            {
                // Save current bounds.
                SaveSetting(frm.Name, "FormLeft", frm.Left);
                SaveSetting(frm.Name, "FormTop", frm.Top);
                SaveSetting(frm.Name, "FormWidth", frm.Width);
                SaveSetting(frm.Name, "FormHeight", frm.Height);
            }
            else
            {
                // Save bounds when we're restored.
                SaveSetting(frm.Name, "FormLeft", frm.RestoreBounds.Left);
                SaveSetting(frm.Name, "FormTop", frm.RestoreBounds.Top);
                SaveSetting(frm.Name, "FormWidth", frm.RestoreBounds.Width);
                SaveSetting(frm.Name, "FormHeight", frm.RestoreBounds.Height);
            }
        }

        public static bool TextIsAlphaNumeric(string text)
        {
            var arr = text.ToLower().ToCharArray();
            var IsAlphaNumeric = true;
            for (int n = 0; n < arr.Length; n++)
            {
                if ((arr[n] < '0' || arr[n] > '9') && (arr[n] < 'a' || arr[n] > 'z'))
                {
                    IsAlphaNumeric = false;
                    break;
                }
            }
            return IsAlphaNumeric;
        }

        public static void SaveMD5(string fileName, string md5)
        {
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            RegistryKey sub_key = reg_key.CreateSubKey("MD5");
            sub_key.SetValue(fileName, md5);
        }

        public static string GetMD5(string fileName)
        {
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            RegistryKey sub_key = reg_key.CreateSubKey("MD5");
            try
            {
                return sub_key.GetValue(fileName).ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// save window position to registry
        /// </summary>
        /// <param name="formName"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private static void SaveSetting(string formName, string name, object value)
        {
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            RegistryKey sub_key = reg_key.CreateSubKey("FORMSTATE");
            RegistryKey sub_key1 = sub_key.CreateSubKey(formName);
            sub_key1.SetValue(name, value);
        }

        private static void GetCoordinateDisplayFormat()
        {
            var rv = "";
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            try
            {
                rv = reg_key.GetValue("CoordinateFormat").ToString();
            }
            catch
            {
                rv = CoordinateDisplayFormat.DegreeDecimal.ToString();
            }
            _coordDisplayFormat = (CoordinateDisplayFormat)Enum.Parse(typeof(CoordinateDisplayFormat), rv);
        }

        private static void SaveCoordinateDisplayFormat()
        {
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\FAD3", true);
            reg_key.SetValue("CoordinateFormat", _coordDisplayFormat.ToString());
        }

        public static bool HasMPH
        {
            get { return _hasMPH; }
        }


        public static bool ShowErrorMessage
        {
            get { return _showErrorMessage; }
            set { _showErrorMessage = value; }
        }

        public static string AppPath
        {
            get { return _appPath; }
        }

        public static void BarangaysFromMunicipalityNo(long MunicipalityNumber)
        {
            var myDT = new DataTable();
            using (var conection = new OleDbConnection(_connectionString))
            {
                try
                {
                    conection.Open();
                    string query = $"Select Distinct Barangay from tblGearInventoryBarangay where Municipality= {MunicipalityNumber} Order By Barangay";
                    var adapter = new OleDbDataAdapter(query, conection);
                    adapter.Fill(myDT);
                    _listBarangays.Clear();
                    for (int i = 0; i < myDT.Rows.Count; i++)
                    {
                        DataRow dr = myDT.Rows[i];
                        _listBarangays.Add(dr["Barangay"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                }
            }
        }

        /// <summary>
        /// fills a dictionary variable with municipalities given ProvinceNo
        /// </summary>
        /// <param name="ProvinceNo"></param>
		public static void MunicipalitiesFromProvinceNo(long ProvinceNo)
        {
            var myDT = new DataTable();
            using (var conection = new OleDbConnection(_connectionString))
            {
                try
                {
                    conection.Open();
                    string query = $"Select MunNo, Municipality from Municipalities where ProvNo=  {ProvinceNo} Order By Municipality";
                    var adapter = new OleDbDataAdapter(query, conection);
                    adapter.Fill(myDT);
                    _munDict.Clear();
                    for (int i = 0; i < myDT.Rows.Count; i++)
                    {
                        DataRow dr = myDT.Rows[i];
                        _munDict.Add(Convert.ToInt32(dr["MunNo"]), dr["Municipality"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
                }
            }
        }

        public static List<string> BarangaysList
        {
            get { return _listBarangays; }
        }

        public static Dictionary<long, string> MunicipalitiesDictionary
        {
            get { return _munDict; }
        }

        public static Dictionary<long, string> ProvincesDictionary
        {
            get { return _provinceDict; }
        }

        //public static string MDBPath
        //{
        //    get { return _mdbPath; }
        //}

        /// <summary>
        /// getter and setter for the path to the mdb. After setting, some variables are filled up
        /// </summary>






        /// <summary>
        /// fills a local dictionary variable with provinces
        /// </summary>

    }
}