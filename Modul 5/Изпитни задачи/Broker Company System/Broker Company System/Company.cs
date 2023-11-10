using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Company_System {
	public class Company {
		private string _name;
		private readonly List<Building> _buildings;
		private readonly List<Broker> _brokers;

		public Company(string name) {
			Name = name;
			_buildings = new List<Building>();
			_brokers = new List<Broker>();
		}

		public string Name {
			get { return _name; }
			set {
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Company name must not be null or empty!");
				_name = value;
			}
		}

		public void AddBroker(Broker broker) {
			if (_brokers.Where(x => x.Name == broker.Name).ToList().Count == 0)
				_brokers.Add(broker);
		}
		public void AddBuilding(Building building) {
			if (_buildings.Where(x => x.Name == building.Name).ToList().Count == 0)
				_buildings.Add(building);
		}

		public Broker GetBrokerByName(string name) {
			if (_brokers.Where(x => x.Name == name).ToList().Count == 0)
				return _brokers.Find(x => x.Name == name);
			else
				return null;
		}
		public Building GetBuildingByName(string name) {
			if (_buildings.Where(x => x.Name == name).ToList().Count == 0)
				return _buildings.Find(x => x.Name == name);
			else
				return null;
		}

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {Name}");
            sb.AppendLine($"##Brokers: {_brokers.Count}");
            _brokers.ForEach(x => sb.AppendLine(x.ToString()));
            sb.AppendLine($"##Buildings - {_buildings.Count}");
            _brokers.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().Trim();
        }
    }
}
