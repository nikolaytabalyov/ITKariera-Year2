using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelify {
    public class Guest {
		private string _name;
		private int _budget;

		public int Budget {
			get { return _budget; }
			set { _budget = value; }
		}

		public string Name {
			get { return _name; }
			set { _name = value; }
		}

	}
}
