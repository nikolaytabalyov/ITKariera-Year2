using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Животинско_царство {
    public abstract class Animal : IMakeNoise, IMakeTrick {
        protected Animal(string name, int age) {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void MakeNoise() => Console.WriteLine($"My name is {Name}. I am {Age} years old.");
        public virtual void MakeTrick() => Console.WriteLine("Look at my trick.");
    }
}
