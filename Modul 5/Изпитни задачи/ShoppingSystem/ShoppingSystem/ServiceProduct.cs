using System.Text;

namespace ShoppingSystem {
    public class ServiceProduct : Product {
        private double _time;

        public ServiceProduct(string name, double price, double time) : base(name, price) {
            Time = time;
        }

        public double Time {
            get { return _time; }
            set {
                if (value < 0) 
                    throw new ArgumentException("Time should be greater than 0!");
                _time = value;
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Time: {Time}");
            return sb.ToString().Trim();
        }
    }
}
