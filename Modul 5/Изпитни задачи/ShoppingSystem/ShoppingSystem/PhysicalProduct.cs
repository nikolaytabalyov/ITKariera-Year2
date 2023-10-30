using System.Text;

namespace ShoppingSystem {
    public class PhysicalProduct : Product {
		private double _weight;
        public PhysicalProduct(string name, double price, double weight) : base(name, price) {
            Weight = weight;
        }

        public double Weight {
            get { return _weight; }
            private set {
                if (value < 0) {
                    throw new ArgumentException("Weight cannot be less or equal to 0!");
                }
                _weight = value;
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Weight: {Weight}");
            return sb.ToString().Trim();
        }
    }
}
