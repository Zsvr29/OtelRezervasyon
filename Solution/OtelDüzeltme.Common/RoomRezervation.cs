using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.UI.Common
{
    public class RoomRezervation
    {
        public Room Room { get; set; }
        public Customer Customer { get; set; }= new Customer();
    }
}
