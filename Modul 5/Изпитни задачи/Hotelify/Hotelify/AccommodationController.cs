using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Hotelify {
    public class AccommodationController {
        private readonly Dictionary<int, Accommodation> _accommodations = new Dictionary<int, Accommodation>();
        private readonly Dictionary<int, Guest> _guests = new Dictionary<int, Guest>();

        public string CreateAccommodation(List<string> args) {
            if (!_accommodations.ContainsKey(int.Parse(args[0]))) {
                switch (args[1]) {
                    case "Hotel":
                        _accommodations.Add(int.Parse(args[0]), new Hotel(int.Parse(args[0]), args[2], args[3], int.Parse(args[4]), args[5], int.Parse(args[6])));
                        return $"{args[0]}: {args[2]} opened!";
                    case "GuestHouse":
                        _accommodations.Add(int.Parse(args[0]), new GuestHouse(int.Parse(args[0]), args[2], args[3], int.Parse(args[4]), args[5], args[6]));
                        return $"{args[0]}: {args[2]} opened!";
                    default:
                        return $"Invalid type: {args[1]}!";
                }
            } else {
                return $"Accommodation with number: {args[0]} already exists!";
            }
        }

        public string CreateGuest(List<string> args) {
            if (_guests.Values.Where(x => x.Name == args[0]).ToList().Count == 0) {
                _guests.Add(_guests.Count, new Guest(args[0], int.Parse(args[1])));
                return $"Successfully added guest {args[0]} with {int.Parse(args[1])} lv. budget!";
            } else {
                return $"Can’t add guest {args[0]}.";
            }
        }
        

        public string AccommodationInfo(List<string> args) {
            if (_accommodations.ContainsKey(int.Parse(args[0]))) {
                return _accommodations[int.Parse(args[0])].ToString();
            } else {
                return string.Empty;
            }
        }

        public string GuestInfo(List<string> args) {
            if (_guests.Values.Where(x => x.Name == args[0]).ToList().Count > 0) {
                return _guests.Values.ToList().Find(x => x.Name == args[0]).ToString();
            } else {
                return string.Empty;
            }
        }

        public string ListPossibleAccommodationByPrice(List<string> args) {
            if (_accommodations.Values.Where(x => x.Price <= int.Parse(args[0])).ToList().Count != 0) {
                List<Accommodation> accommodations = _accommodations.Values.Where(x => x.Price <= int.Parse(args[0])).OrderByDescending(x => x.Price).ToList();
                StringBuilder sb = new StringBuilder();
                accommodations.ForEach(x => sb.AppendLine(x.ToString()));
                return sb.ToString().Trim();
            } else {
                return "No suitable accommodations found.";
            }
        }
    }
}
