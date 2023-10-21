namespace _1._Превозни_средства_2 {
    public abstract class Vehicle {
        protected double _fuel;
        protected double _fuelConsumption;
        protected double _tankCapacity;
        
        protected Vehicle(double fuel, double fuelConsumption, double tankCapacity) {
            _fuel = fuel;
            _fuelConsumption = fuelConsumption;
            _tankCapacity = tankCapacity;
        }

        public virtual void Drive(double distance) {
            if (_fuel / _fuelConsumption >= distance) {
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
                _fuel -= distance * _fuelConsumption;
            } else {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }
        public virtual void Refuel(double liters) {
            if (_fuel + liters > _tankCapacity)
                Console.WriteLine("Cannot fit fuel in tank");
            else
                _fuel += liters;
        }

        public double GetFuel() => _fuel;
    }
}
