using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelify {
    class Engine {

        public void Run() {
            AccommodationController controller = new AccommodationController();
            string command = "";
            do {
                command = Console.ReadLine();
                string[] commandData = command.Split('|').ToArray();
                try {
                    switch (commandData[0]) {
                        case "CreateAccommodation":
                            Console.WriteLine(controller.CreateAccommodation(commandData.Skip(1).ToList()));
                            break;
                        case "CreateGuest":
                            Console.WriteLine(controller.CreateGuest(commandData.Skip(1).ToList()));
                            break;
                        case "AccommodationInfo":
                            Console.WriteLine(controller.AccommodationInfo(commandData.Skip(1).ToList()));
                            break;
                        case "GuestInfo":
                            Console.WriteLine(controller.GuestInfo(commandData.Skip(1).ToList()));
                            break;
                        case "ListPossibleAccommodationByPrice":
                            Console.WriteLine(controller.ListPossibleAccommodationByPrice(commandData.Skip(1).ToList()));
                            break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine($"{e.Message}");
                }
            } while (command != "End");
        }

    }
}
