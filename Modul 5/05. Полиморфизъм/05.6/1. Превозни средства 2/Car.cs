namespace _1._Превозни_средства_2 {
    public class Car : Vehicle {

        public Car(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity) {
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
