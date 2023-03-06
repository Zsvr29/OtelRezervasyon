using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.UI.Common
{
    public class Room
    {
        public byte BedCount { get; set; }
        public int RoomNumber { get; set; }
        public double RoomPrice { get; set; }
        public RoomSituation RoomSituation { get; set; } // enumun tıpıne donusturduk.


    }
}
