using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2 {
    class RationalNumber {
        private int numerator;
        private int denumerator;
        public RationalNumber(int numerator, int denumerator) {
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public int Numerator { get; set; }
        public int Denumerator {
            get => denumerator;
            set {
                if (value == 0)
                    throw new ArgumentException("Denumerator cannot be 0!");
                else
                    denumerator = value;
            }
        }

        public void Print() {
            Console.Write($"{Numerator}/{Denumerator}");
        }
    }
}
