using System.Text;

namespace ShoppingSystem {
    public class Engine {
        private Controller controller;
        private bool isRunning;
        public Engine(Controller controller) {
            this.controller = controller;
            this.isRunning = true;
        }
        public string Run() {
            StringBuilder sb = new StringBuilder(); 
            while (isRunning) {
                string[] splittedInput = Console.ReadLine().Split();
                string command = splittedInput[0];
                List<string> arguments = splittedInput
                    .Skip(1)
                    .ToList();
                switch (command) {
                    case "Product":
                        sb.AppendLine(controller.ProcessProductCommand(arguments));
                        break;
                    case "Service":
                        sb.AppendLine(controller.ProcessServiceCommand(arguments));
                        break;
                    case "Checkout":
                        sb.AppendLine(controller.ProcessCheckoutCommand(arguments));
                        break;
                    case "Info":
                        sb.AppendLine(controller.ProcessInfoCommand(arguments));
                        break;
                    case "End":
                        sb.AppendLine(controller.ProcessEndCommand());
                        this.isRunning = false;
                        break;
                    default:
                        sb.AppendLine("Invalid command");
                        break;
                }
            }
            return sb.ToString().Trim();
        }
    }

}
