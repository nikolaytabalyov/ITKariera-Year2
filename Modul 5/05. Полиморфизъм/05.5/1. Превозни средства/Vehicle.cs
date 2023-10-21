namespace _1._Превозни_средства {
    public abstract class Vehicle {
        protected double _fuel;
        protected double _fuelConsumption;

        protected Vehicle(double fuel, double fuelConsumption) {
            _fuel = fuel;
            _fuelConsumption = fuelConsumption;
        }

        public abstract void Drive(double distance); 
        public abstract void Refuel(double liters);
    }
}
