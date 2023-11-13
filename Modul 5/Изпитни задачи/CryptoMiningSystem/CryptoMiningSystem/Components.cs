using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem {
    public class Components {
		private string _model;
		private double _price;
		private int _generation;
		private int _liveWorkingHours;

		public string Model {
			get { return _model; }
			set {
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Model cannot be null or empty!");
				_model = value; 
			}
		}
		public double Price {
			get { return _price; }
			set {
				if (value <= 0 || value > 10000)
					throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
				_price = value;
			}
		}
		public int Generation {
			get { return _generation; }
			set {
				if (value <= 0)
					throw new ArgumentException("Generation cannot be 0 or negative!");
				_generation = value; 
			}
		}
		public int LiveWorkingHours {
			get { return _liveWorkingHours; }
			set { _liveWorkingHours = value; }
		}
	}
}
