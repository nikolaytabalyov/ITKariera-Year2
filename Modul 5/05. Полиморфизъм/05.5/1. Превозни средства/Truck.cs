using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Превозни_средства {
    public class Truck : Vehicle {
        public Truck(double fuel, double fuelConsumption) : base(fuel, fuelConsumption) {
            _fuelConsumption += 1.6;
        }

        public override void Drive(double distance) {
            if (_fuel / _fuelConsumption >= distance) {
                Console.WriteLine($"Truck travelled {distance} km");
                _fuel -= distance * _fuelConsumption;
            } else {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters) => _fuel += liters * 0.95;

        public double GetFuel() => _fuel;
    }
}
