using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapWinGIS;

namespace GridMapper.entities
{
    public class IslandNameHelper
    {
        public static string IslandNameShapefile { get; set; }
        public static string NameField { get; set; }

        public static string ShortNameField { get; set; }
        public Dictionary<string, string> AbrreviateList { get; set; }
        public static int AbbreviateIsland()
        {
            int editedCount = 0;
            var sf = new Shapefile();
            if (sf.Open(IslandNameShapefile))
            {
                if (sf.StartEditingTable())
                {
                    for (int x = 0; x < sf.NumShapes; x++)
                    {
                        var islandName = (string)sf.CellValue[sf.FieldIndexByName["name"], x];
                        var parts = islandName.Split(' ');
                        switch (parts[parts.Length - 1])
                        {
                            case "Island":
                                var islName = string.Join(" ", parts, 0, parts.Count() - 1) + " I.";
                                if (sf.EditCellValue(sf.FieldIndexByName["short_name"], x, islName))
                                {
                                    editedCount++;
                                }
                                break;
                        }
                    }
                    sf.StopEditingShapes(true);
                }
            }

            return editedCount;
        }
    }
}
