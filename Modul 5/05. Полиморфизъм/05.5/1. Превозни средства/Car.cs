namespace _1._Превозни_средства {
    public class Car : Vehicle {
        public Car(double fuel, double fuelConsumption) : base(fuel, fuelConsumption) {
            _fuelConsumption += 0.9;
        }

        public override void Drive(double distance) {
            if (_fuel / _fuelConsumption >= distance) {
                Console.WriteLine($"Car travelled {distance} km");
                _fuel -= distance * _fuelConsumption;
            } else {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double liters) => _fuel += liters;

        public double GetFuel() => _fuel;
    }
}
