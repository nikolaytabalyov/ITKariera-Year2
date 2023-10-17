using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5._3 {
    internal class Smartphone : ICallable, IBrowseable {
        public void Browse(string[] urls) {
            for (int i = 0; i < urls.Length; i++) {
                if (!urls[i].Any(Char.IsNumber)) {
                    Console.WriteLine($"Browsing: {urls[i]}!");
                } else {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }

        public void Call(string[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i].All(Char.IsNumber)) {
                    Console.WriteLine($"Calling... {numbers[i]}!");
                } else {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
