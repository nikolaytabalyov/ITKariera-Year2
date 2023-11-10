using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Company_System {
    public class Hotel : Building {
		private string _name;

		public string Name {
			get { return _name; }
			set {
				if (!value.EndsWith("Hotel"))
                    Console.WriteLine("Name of hotel buildings should end on Hotel!");
				else
					_name = value;
			}
		}

		public Hotel(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount) {
			Name = name;
        }
    }
}
