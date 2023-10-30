using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelify {
    public class GuestHouse : Accommodation {
		private string _hostName;

        public GuestHouse(int refNumber, string name, string description, int price, string location, string hostName) : base(refNumber, name, description, price, location) {
            HostName = hostName;
        }

        public string HostName {
			get { return _hostName; }
			set { _hostName = value; }
		}

	}
}
