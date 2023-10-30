using System.Text;

namespace ShoppingSystem {
    public class Controller {
        private readonly List<Receipt> _receipts;
        private List<Product> _currentProducts;
        public Controller() {
            _receipts = new List<Receipt>();
            _currentProducts = new List<Product>();
        }
        public string ProcessProductCommand(List<string> args) {
            _currentProducts.Add(new PhysicalProduct(args[0], double.Parse(args[1]), double.Parse(args[2])));
            return $"The current customer has bought {args[0]}";
        }

        public string ProcessServiceCommand(List<string> args) {
            _currentProducts.Add(new ServiceProduct(args[0], double.Parse(args[1]), double.Parse(args[2])));
            return $"The current customer has applied for {args[0]} service.";
        }
        public string ProcessCheckoutCommand(List<string> args) {
            Receipt receipt = new Receipt(args[0]);
            double sumOfProductPrices = _currentProducts.Sum(x => x.Price);
            _currentProducts.ForEach(x => receipt.AddProduct(x));
            _receipts.Add(receipt);
            _currentProducts = new List<Product>();
            return $"Customer checked out for a total of ${sumOfProductPrices:F2}.";
            }
        public string ProcessInfoCommand(List<string> args) {
            StringBuilder sb = new StringBuilder();
            if (args[0] == "Customer") {
                sb.AppendLine("Current customer has:");
                sb.AppendLine($"Products: {_currentProducts.Count}");
                sb.AppendLine($"Total Bill: ${_currentProducts.Sum(x => x.Price):F2}");
                return sb.ToString().Trim();
            } else if (args[0] == "Shop" && _receipts.Count != 0) {
                sb.AppendLine("Receipts:");
                _receipts.ForEach(x => sb.AppendLine(x.ToString()));
                return sb.ToString().Trim();
            } 
            return "Receipts: No receipts";
        }

        public string ProcessEndCommand() => $"Total customers today: {_receipts.Count}";
    }

}
