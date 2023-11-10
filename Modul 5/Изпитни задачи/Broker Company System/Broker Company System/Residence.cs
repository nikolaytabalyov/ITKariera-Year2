using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Company_System {
    public class Residence : Building {
        private string _name;

        public string Name {
            get { return _name; }
            set {
                if (!value.EndsWith("Residence"))
                    Console.WriteLine("Name of residence buildings should end on Residence!");
                else
                    _name = value;
            }
        }

        public Residence(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount) {
            Name = name;
        }
    }
}
