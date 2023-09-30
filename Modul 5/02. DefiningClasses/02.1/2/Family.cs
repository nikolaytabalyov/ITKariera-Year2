using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2 {
    internal class Family {

        public Family() {
            People = new();
        }

        public List<Person> People { get; set; }

        public void Print() {
            People = People.OrderBy(x => x.Name).ToList();
            for (int i = 0; i < People.Count; i++) {
                Console.WriteLine($"{People[i].Name} {People[i].Age}");
            }
        }
    }
}
