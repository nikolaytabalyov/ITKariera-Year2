namespace _1._Превозни_средства_2 {
    public class Car : Vehicle {

        public Car(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity) {
            _fuelConsumption += 0.9;
        }
    }
}
