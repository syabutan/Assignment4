using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class TempStorage
    {
        private static List<SuggestInfo> infos = new List<SuggestInfo>();
        public static IEnumerable<SuggestInfo> Infos => infos;
        public static void AddRestaurantInfo(SuggestInfo info)
        {
            infos.Add(info);
        }
    }
}
