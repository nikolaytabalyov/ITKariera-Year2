using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5 {
    class Citizen : IPerson, IBirthable, IIdentifiable {
        public Citizen(string name, int age, string birthdate, string id) {
            Name = name;
            Age = age;
            Birthdate = birthdate;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}
