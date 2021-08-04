﻿using MapWinGIS;

namespace GridMapper.entities
{
    public static class LineWidthFix
    {
        public static void FixLineWidth(Shapefile sf)
        {
            if (sf.ShapefileType == ShpfileType.SHP_POLYGON && sf.DefaultDrawingOptions.LineWidth == 1F)
            {
                sf.DefaultDrawingOptions.LineWidth = 1.1F;
            }
        }
    }
}