using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelify {
    public class Hotel : Accommodation {
		private int _starCount;

        public Hotel(int refNumber, string name, string description, int price, string location, int starCount) : base(refNumber, name, description, price, location) {
            StarCount = starCount;
        }

        public int StarCount {
			get { return _starCount; }
			set { _starCount = value; }
		}

	}
}
