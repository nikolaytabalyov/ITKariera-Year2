using System.Text;

namespace PlantCare_ {
    internal class Program {
        static void Main(string[] args) {
            Controller controller = new Controller();
            bool isRunning = true;
            StringBuilder sb = new StringBuilder();
            while (isRunning) {
                string[] splittedInput = Console.ReadLine().Split();

                string command = splittedInput[0];
                List<string> arguments = splittedInput
                    .Skip(1)
                    .ToList();

                //string result = "";
                try {
                    switch (command) {
                        case "AddCareItem":
                            sb.AppendLine(controller.AddCareItem(arguments));
                            break;
                        case "AddPlant":
                            sb.AppendLine(controller.AddPlant(arguments));
                            break;
                        case "GetTotalCaresByPlantId":
                            sb.AppendLine(controller.GetTotalCaresByPlantId(arguments));
                            break;
                        case "WaterPlantById":
                            sb.AppendLine(controller.WaterPlantById(arguments));
                            break;
                        case "FertilizePlantById":
                            sb.AppendLine(controller.FertilizePlantById(arguments));
                            break;
                        case "GetTallestTree":
                            sb.AppendLine(controller.GetTallestTree(arguments));
                            break;
                        case "End":
                            isRunning = false;
                            break;
                        default:
                            sb.AppendLine("Invalid command");
                            break;
                    }

                    if (!isRunning) { break; }
                }
                catch (Exception e) {
                    sb.AppendLine(e.Message);
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}