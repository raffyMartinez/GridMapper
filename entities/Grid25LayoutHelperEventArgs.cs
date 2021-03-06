using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapWinGIS;

namespace GridMapper.entities
{
    public class Grid25LayoutHelperEventArgs : EventArgs
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Overlap { get; set; }
        public Extents LayoutExtent { get; set; }
        public bool NullLayout { get; internal set; }
        public bool LayoutCleared { get; set; }

        public void LayoutSpecs(int rows, int columns, int overlap)
        {
            Rows = rows;
            Columns = columns;
            Overlap = overlap;
        }

        public Grid25LayoutHelperEventArgs(Extents layoutExtent)
        {
            LayoutExtent = layoutExtent;
        }

        public Grid25LayoutHelperEventArgs(bool nullLayout)
        {
            NullLayout = nullLayout;
        }

        public Grid25LayoutHelperEventArgs()
        {
            LayoutCleared = false;
        }
    }
}