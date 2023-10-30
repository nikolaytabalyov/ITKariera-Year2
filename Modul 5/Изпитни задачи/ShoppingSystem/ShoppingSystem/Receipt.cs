using System.Text;

namespace ShoppingSystem {
    public class Receipt {
		private string _customerName;
		private readonly List<Product> _products;

        public Receipt(string customerName) {
            CustomerName = customerName;
			_products = new List<Product>();
        }

        public string CustomerName {
			get { return _customerName; }
			set {
				if (value.Length < 2 || value.Length > 40)
					throw new ArgumentException("Customer Name should be between 2 and 40 characters!");
				_customerName = value; 
			}
		}

		public void AddProduct(Product product) => _products.Add(product);

        public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Receipt of {CustomerName}");
            sb.AppendLine($"Total Price: {_products.Sum(x => x.Price):F2}");
			_products.ForEach(x => sb.AppendLine(x.ToString()));
			return sb.ToString().Trim();
        }
    }
}
