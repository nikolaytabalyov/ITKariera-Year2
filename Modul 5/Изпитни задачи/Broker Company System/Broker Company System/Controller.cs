using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Company_System {
    public class Controller {
        private Dictionary<string, Company> _companies;
        public Controller() {
            _companies = new Dictionary<string, Company>();
        }
        public string CreateCompany(List<string> args) {
            if (!_companies.ContainsKey(args[0])) {
                _companies.Add(args[0], new Company(args[0]));
                return $"Company {_companies[args[0]].Name} was successfully registerd in the system!";
            } else {
                return $"Company {_companies[args[0]].Name} is already registered!";
            }
        }
        public string RegisterBuilding(List<string> args) {
            if (!_companies.ContainsKey(args[0]))
                return $"Invalid Company: {args[0]}. Cannot find it in system!";
            if (_companies.Values.Any(x => x.GetBuildingByName(args[1]) is not null))
                return $"Building {args[1]} is already registered in {args[0]}!";

            switch (args[0]) {
                case "Hotel":
                    _companies[args[5]].AddBuilding(new Hotel(args[1], args[2], int.Parse(args[3]), double.Parse(args[4])));
                    return $": Building {args[1]} was successfully registerd in {args[5]} catalog!";
                case "Residence":
                    _companies[args[5]].AddBuilding(new Residence(args[1], args[2], int.Parse(args[3]), double.Parse(args[4])));
                    return $": Building {args[1]} was successfully registerd in {args[5]} catalog!";
                case "Business":
                    _companies[args[5]].AddBuilding(new Business(args[1], args[2], int.Parse(args[3]), double.Parse(args[4])));
                    return $": Building {args[1]} was successfully registerd in {args[5]} catalog!";
            }
            return "I don't know man. Something is f*cked up!";
        }
        public string RegisterBroker(List<string> args) { //name, age, city, companyName
            if (!_companies.ContainsKey(args[3]))
                return $"Invalid Company: {args[3]}. Cannot find it in system!";
            if (_companies.Values.Any(x => x.GetBrokerByName(args[1]) is not null))
                return $"Broker {args[0]} is already registered in {args[3]}!";

            _companies[args[3]].AddBroker(new Broker(args[0], int.Parse(args[1]), args[2]));
            return "I don't know man. Something is f*cked up!";
            throw new NotImplementedException();
        }
        public string RentBuilding(List<string> args) {
            if (_companies.ContainsKey(args[0])) {
                Broker? broker = _companies[args[0]].GetBrokerByName(args[2]);
                Building? building = _companies[args[0]].GetBuildingByName(args[1]);
                if (broker is null)
                    return $"Invalid Broker: {args[2]}. Cannot find employee in {args[0]}!";
                if (building is null)
                    return $"Invalid Building: {args[1]}. Cannot find it in {args[0]} catalog!";
                if (!building.IsAvailable)
                    return $"Building: {building.Name} cannot be rented!";

                building.IsAvailable = false;
                broker.ReceiveBonus(building);
                return $"Successfully rented {building.Name}!\n" +
                    $"Broker {building.Name} earned {broker.Bonus}!";
            }
            return $"Invalid Company: {args[0]}. Cannot find it in system!";
        }
        public string CompanyInfo(List<string> args) {
            if (_companies.ContainsKey(args[0]))
                return _companies[args[0]].ToString();
            else
                return $"Invalid Company: {args[0]}. Cannot find it in system!";
        }
        public string Shutdown() {
            throw new NotImplementedException();
        }
    }
}
