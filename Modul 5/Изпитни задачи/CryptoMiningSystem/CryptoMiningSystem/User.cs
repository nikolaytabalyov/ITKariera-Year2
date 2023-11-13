using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem {
    public class User {
        private string _name;
        private double _money;
        private Computer _computer;

        public string Name {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Username must not be null or empty!");
                _name = value;
            }
        }
        public int Stars {
            get { return Stars; }
            set {
                Stars = (int)Money / 100;
            }
        }
        public double Money {
            get { return _money; }
            set {
                if (value < 0)
                    throw new ArgumentException("User's money cannot be less than 0!");
                _money = value;
            }
        }
        public Computer Computer {
            get { return _computer; }
            set { _computer = value; }
        }
    }
}
