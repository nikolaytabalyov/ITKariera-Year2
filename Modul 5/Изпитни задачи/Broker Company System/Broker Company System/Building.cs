using System.Text;

namespace Broker_Company_System {
    public abstract class Building {
		private string _name;
		private string _city;
		private int _stars;
		private double _rentAmount;
		private bool _isAvailable;

        protected Building(string name, string city, int stars, double rentAmount) {
            Name = name;
            City = city;
            Stars = stars;
            RentAmount = rentAmount;
            IsAvailable = true;
        }

        public string Name {
			get { return _name; }
			set {
				if (string.IsNullOrWhiteSpace(value))
					Console.WriteLine("Building name must be not null or empty!");
				else
                    _name = value; 
			}
		}

		public string City {
            get { return _city; }
            set {
				if (string.IsNullOrWhiteSpace(value))
					Console.WriteLine("City must be not null or empty!");
                else
                    _city = value;
            }
        }

		public int Stars {
            get { return _stars; }
            set {
                if (value < 0 || value > 5)
                    Console.WriteLine("Stars cannot be less than 0 or above 5!");
                else
                    _stars = value;
            }
        }

		public double RentAmount {
            get { return _rentAmount; }
            set {
                if (value <= 0)
                    Console.WriteLine("Rent amount cannot be less or equal to 0!");
				else
                    _rentAmount = value;
            }
        }
		public bool IsAvailable {
			get { return _isAvailable; }
			set { _isAvailable = value; }
		}
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Building: {Name} <{Stars}>");
            sb.AppendLine($"****Location: {City}");
            sb.AppendLine($"****RentAmount: {RentAmount}");
            sb.AppendLine($"****Is Available: {IsAvailable}");
            return sb.ToString().Trim();
        }
    }
}
