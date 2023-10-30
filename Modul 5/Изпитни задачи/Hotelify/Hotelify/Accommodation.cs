using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hotelify {
	public abstract class Accommodation {
		private int _refNumber;
		private string _name;
		private string _desciption;
		private int _price;
		private string _location;

        protected Accommodation(int refNumber, string name, string description, int price, string location) {
            RefNumber = refNumber;
            Name = name;
            Description = description;
            Price = price;
            Location = location;
        }

        public int RefNumber {
			get { return _refNumber; }
			set { _refNumber = value; }
		}

		public string Name {
			get { return _name; }
			set {
				if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
					_name = value;
				else
					throw new ArgumentException("Accommodation name cannot be null, empty or whitespace.");
			}
		}

		public string Description {
			get { return _desciption; }
			set { _desciption = value; }
		}

		public int Price {
            get { return _price; }
            set {
                if (value > 0)
                    _price = value;
                else
                    throw new ArgumentException("Accommodation price cannot be zero or negative.");
            }
        }

		public string Location {
			get { return _location; }
			set {
				if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
					_location = value;
				else
					throw new ArgumentException("Accommodation location cannot be null, empty or whitespace.");
			}
		}
        public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Accommodation {RefNumber}: {Name}");
			sb.AppendLine($"Description: {Description}");
			sb.AppendLine($"Price: {Price}");
			sb.AppendLine($"Location: {Location}");
			return sb.ToString().Trim();
        }
    }
}
