namespace _1._Превозни_средства_2 {
    public class Truck : Vehicle {
        
        public Truck(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity) {
            _fuelConsumption += 1.6;
        }

        public override void Refuel(double liters) => _fuel += liters * 0.95;
    }
}
