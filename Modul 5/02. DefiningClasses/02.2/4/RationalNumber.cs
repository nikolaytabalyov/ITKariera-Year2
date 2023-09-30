using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4 {
    class RationalNumber : IComparable {

        private int numerator;
        private int denumerator;
        public RationalNumber(int numerator, int denumerator) {
            if (denumerator < 0) {
                numerator *= -1;
                denumerator *= -1;
            }
            int nod = BiggestDivider(numerator, denumerator);
            Numerator = numerator/nod;
            Denumerator = denumerator/nod;
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

        public static void PrintList(List<RationalNumber> rationalNumbers) {
            rationalNumbers = rationalNumbers.OrderBy(x => x).ToList();

            foreach (var num in rationalNumbers) {
                num.Print();
                if (rationalNumbers.IndexOf(num) != rationalNumbers.Count - 1) {
                    Console.Write("; ");
                }
            }
        }

        public int BiggestDivider(int numerator, int denumerator) {
            int nod = 1;
            int r = 0;
            int a = Math.Abs(numerator);
            int b = Math.Abs(denumerator);

            while (b != 0) {
                r = a % b;
                a = b;
                b = r;
            }

            nod = a;
            return nod;
        }

        public int CompareTo(object? obj) {
            RationalNumber x = (RationalNumber)obj;
            if (Numerator * x.Denumerator < x.Numerator * Denumerator)
                return -1;
            if (Numerator * x.Denumerator == x.Numerator * Denumerator)
                return 0;
            else 
                return 1;

        }
    }
}
