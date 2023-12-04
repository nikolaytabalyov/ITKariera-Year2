using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities
{
    using CryptoMiningSystem.Interfaces;
    //using CryptoMiningSystem.Utilities;
    using System;
    using System.Text;
    public class User : IUser {
        private string _name;
        private int _stars;
        private decimal _money;

        public User(string name, int stars, decimal money, Computer computer) {
            Name = name;
            Stars = stars;
            Money = money;
            Computer = computer;
        }

        public string Name {
            get => _name;
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Username must not be null or empty!");
                _name = value;
            }
        }
        public int Stars {
            get => _stars;
            set => _stars = (int)Money / 100;
        }
        public decimal Money {
            get => _money;
            set {
                if (value < 0)
                    throw new ArgumentException("User's money cannot be less than 0!");
                _money = value;
            }
        }

        public Computer Computer { get; private set; }
    }
}
