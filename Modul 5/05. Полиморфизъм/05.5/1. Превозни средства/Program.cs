namespace _1._Превозни_средства {
    internal class Program {
        static void Main(string[] args) {
            string[] carInfo = Console.ReadLine().Split(' ').ToArray();
            Car car = new(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split(' ').ToArray();
            Truck truck = new(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                switch (commands[0]) {
                    case "Drive":
                        if (commands[1] == "Car")
                            car.Drive(Convert.ToDouble(commands[2]));
                        else if (commands[1] == "Truck")
                            truck.Drive(Convert.ToDouble(commands[2]));
                        break;
                    case "Refuel":
                        if (commands[1] == "Car")
                            car.Refuel(Convert.ToDouble(commands[2]));
                        else if (commands[1] == "Truck")
                            truck.Refuel(Convert.ToDouble(commands[2]));
                        break;
                }
            }

            Console.WriteLine($"Car: {car.GetFuel():F2}");
            Console.WriteLine($"Car: {truck.GetFuel():F2}");
        }
    }
}