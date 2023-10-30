using System.Text;

namespace ShoppingSystem {
    public abstract class Product {
        private string _name;
        private double _price;
        protected Product(string name, double price) {
            Name = name;
            Price = price;
        }
        public string Name {
            get { return _name; }
            private set {
                if (value.Length < 3 || value.Length > 30) {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }
                _name = value;
            }
        }
        public double Price {
            get { return _price; }
            private set {
                if (value < 0) {
                    throw new ArgumentException("Price should be 0 or positive!");
                }
                _price = value;
            }
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Price: {Price}");
            return sb.ToString().Trim();
        }
    }

}
