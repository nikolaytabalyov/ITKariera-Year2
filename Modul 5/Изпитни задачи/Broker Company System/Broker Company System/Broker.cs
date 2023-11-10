using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Company_System {
    public class Broker {
        private string _name;
        private int _age;
        private string _city;
        private double _bonus;
        private readonly List<Building> _buildings;
        public Broker(string name, int age, string city) {
            Name = name;
            Age = age;
            City = city;
            _buildings = new List<Building>();
        }

        public string Name {
            get { return _name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Broker name must be not null or empty!");
                _name = value;
            }
        }


        public int Age {
            get { return _age; }
            set {
                if (value < 16 || value > 70)
                    Console.WriteLine("Broker's age cannot be less than 16 or above 70!");
                _age = value;
            }
        }
        public string City {
            get { return _city; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("City must be not null or empty!");
                _city = value;
            }
        }

        public double Bonus {
            get { return _bonus; }
            set { _bonus = value; }
        }
        
        public double ReceiveBonus(Building building) {
            _buildings.Add(building);
            Bonus += building.RentAmount * 2 * building.Stars / 100;
            return Bonus;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Building: {Name} <{Age}>");
            sb.AppendLine($"****Location: {City}");
            sb.AppendLine($"****Bonus: {Bonus}");
            _buildings.ForEach(x => sb.AppendLine($"******{x.Name}"));
            return sb.ToString().Trim();
        }
    }
}
