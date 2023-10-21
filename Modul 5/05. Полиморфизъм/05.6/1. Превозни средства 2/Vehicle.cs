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

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
