using System;

namespace Hotelify {
    internal class Program {
        static void Main(string[] args) {
            Engine engine = new Engine();
            Console.WriteLine(engine.Run());
        }
    }
}