using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1 {
    public class Person {
		private string _firstName;
		private string _secondName;
		private int _age;

        public Person(string firstName, string secondName, int age) {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }

        public string FirstName {
			get { return _firstName; }
			set {
				if (!string.IsNullOrEmpty(value))
					_firstName = value;
				else
					throw new ArgumentNullException("value", "The first name cannot be null or empty");
			}
		}

		public string SecondName {
            get { return _secondName; }
            set {
                if (!string.IsNullOrEmpty(value))
                    _secondName = value;
                else
                    throw new ArgumentNullException("value", "The second name cannot be null or empty");
            }
        }

		public int Age {
			get { return _age; }
			set {
				if (value >= 0 && value <= 120)
					_age = value;
				else
					throw new ArgumentOutOfRangeException("value", "Age should be in the range [0 ... 120].");
			}
		}
	}
}
