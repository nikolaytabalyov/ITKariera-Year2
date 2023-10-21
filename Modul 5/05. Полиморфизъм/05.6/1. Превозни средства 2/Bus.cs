namespace _1._Превозни_средства_2 {
    public class Bus : Vehicle {
        public Bus(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity) {
        }

        public void DriveWithPeople(double distance) {
            if (_fuel / (_fuelConsumption + 1.4) >= distance) {
                Console.WriteLine($"Bus travelled {distance} km");
                _fuel -= distance * (_fuelConsumption + 1.4);
            } else {
                Console.WriteLine("Bus needs refueling");
            }
        }
    }
}
