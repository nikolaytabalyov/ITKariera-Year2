namespace _1._Превозни_средства_2 {
    internal class Program {
        static void Main(string[] args) {
            string[] carInfo = Console.ReadLine().Split(' ').ToArray();
            Car car = new(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split(' ').ToArray();
            Truck truck = new(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            string[] busInfo = Console.ReadLine().Split(' ').ToArray();
            Bus bus = new(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                switch (commands[0]) {
                    case "Drive":
                        if (commands[1] == "Car")
                            car.Drive(Convert.ToDouble(commands[2]));
                        else if (commands[1] == "Truck")
                            truck.Drive(Convert.ToDouble(commands[2]));
                        else if (commands[1] == "Bus")
                            bus.DriveWithPeople(Convert.ToDouble(commands[2]));
                        break;
                    case "Refuel":
                        if (commands[1] == "Car")
                            car.Refuel(Convert.ToDouble(commands[2]));
                        else if (commands[1] == "Truck")
                            truck.Refuel(Convert.ToDouble(commands[2]));
                        else if (commands[1] == "Bus")
                            bus.Refuel(Convert.ToDouble(commands[2]));
                        break;
                    case "DriveEmpty":
                        if (commands[1] == "Bus")
                            bus.Drive(Convert.ToDouble(commands[2]));
                        break;
                }
            }

            Console.WriteLine($"Car: {car.GetFuel():F2}");
            Console.WriteLine($"Truck: {truck.GetFuel():F2}");
            Console.WriteLine($"Bus: {bus.GetFuel():F2}");
        } 
    }
}