using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelify {
    public class Guest {
		private string _name;
		private int _budget;

        public Guest(string name, int budget) {
            Name = name;
            Budget = budget;
        }

        public string Name {
            get { return _name; }
            set {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    throw new ArgumentException("Guest name cannot be null, empty or whitespace.");
            }
        }
		public int Budget {
			get { return _budget; }
			set {
				if (value > 0)
					_budget = value;
				else
					throw new ArgumentException("Guest budget cannot be zero or negative.");
			}
		}


        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Guest {Name}");
            sb.AppendLine($"Budget: {Budget}");
            return sb.ToString().Trim();
        }
    }
}
