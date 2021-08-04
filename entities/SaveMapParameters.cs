using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMapper.entities
{
    public class SaveMapParameters
    {
        public int? DPI { get; set; }
        public string FileName { get; set; }

        public double? LogoScaleFactoer { get; set; }

        public bool LayoutMap { get; set; }

        public void SetAllParameters(int dpi, string filename, double scaleFactor, bool layoutMap)
        {
            DPI = dpi;
            FileName = filename;
            LogoScaleFactoer = scaleFactor;
            LayoutMap = layoutMap;
        }
    }
}
