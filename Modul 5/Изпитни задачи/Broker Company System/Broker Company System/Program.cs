using System.Text;

namespace Broker_Company_System {
    internal class Program {
        public class InputCommands {
            public const string CreateCompany = "CreateCompany";
            public const string RegisterBuilding = "RegisterBuilding";
            public const string RegisterBroker = "RegisterBroker";
            public const string RentBuilding = "RentBuilding";
            public const string CompanyInfo = "CompanyInfo";
            public const string Shutdown = "Shutdown";
        }
        static void Main(string[] args) {
            bool running = true;
            StringBuilder output = new StringBuilder();
            Controller controller = new Controller();


            while (running) {
                try {
                    List<string> input = Console.ReadLine().Split('*').ToList();
                    string command = input[0];
                    input = input.Skip(1).ToList();

                    switch (command) {
                        case InputCommands.CreateCompany:
                            output.AppendLine(controller.CreateCompany(input));
                            break;
                        case InputCommands.RegisterBuilding:
                            output.AppendLine(controller.RegisterBuilding(input));
                            break;
                        case InputCommands.RegisterBroker:
                            output.AppendLine(controller.RegisterBroker(input));
                            break;
                        case InputCommands.RentBuilding:
                            output.AppendLine(controller.RentBuilding(input));
                            break;
                        case InputCommands.CompanyInfo:
                            output.AppendLine(controller.CompanyInfo(input));
                            break;
                        case InputCommands.Shutdown:
                            output.AppendLine(controller.Shutdown());
                            Console.WriteLine(output.ToString());
                            break;
                    }
                } catch (ArgumentException e) {
                    output.AppendLine(e.Message);
                }
            }

        }
    }
}