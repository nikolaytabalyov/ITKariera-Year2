using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Company_System {
    public class Business : Building {
        private string _name;

        public string Name {
            get { return _name; }
            set {
                if (!value.EndsWith("Business"))
                    Console.WriteLine("Name of business buildings should end on Business!");
                else
                    _name = value;
            }
        }

        public Business(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount) {
            Name = name;
        }
    }
}
