using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Животинско_царство {
    public class Cat : Animal {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeNoise() {
            Console.WriteLine("Meow!");
            base.MakeNoise();
        }

        public override void MakeTrick() => Console.WriteLine("No trick for you! I'm too lazy!");
    }
}
