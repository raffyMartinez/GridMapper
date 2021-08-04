using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMapper.entities
{
    public static class TileProviderManager
    {
        public static string BingAPIKey{get;set;}

        public static void MakeProvideList()
        {
            TileProviders.Clear();
            TileProviders.Add(0, "OpenStreetMap");
            TileProviders.Add(1, "OpenCycleMap");
            TileProviders.Add(2, "OpenTransportMap");

            if (BingAPIKey?.Length > 0)
            {
                TileProviders.Add(3, "BingMaps");
                TileProviders.Add(4, "BingSatellite");
                TileProviders.Add(5, "BingHybrid");
            }
            TileProviders.Add(6, "GoogleMaps");
            //TileProviders.Add(7, "GoogleSatellite");
            //TileProviders.Add(8, "GoogleHybrid");
            TileProviders.Add(9, "GoogleTerrain");
            //TileProviders.Add(10, "HereMaps");
            //TileProviders.Add(11, "HereSatellite");
            //TileProviders.Add(12, "HereHybrid");
            //TileProviders.Add(13, "HereTerrain");
            //TileProviders.Add(21, "Rosreestr");
            TileProviders.Add(22, "OpenHumanitarianMap");
            //TileProviders.Add(23, "MapQuestAerial");
        }
        public static Dictionary<int, string> TileProviders { get; set; } = new Dictionary<int, string>();
    }
}
