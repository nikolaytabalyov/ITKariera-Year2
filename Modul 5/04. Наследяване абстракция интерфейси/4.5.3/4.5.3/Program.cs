namespace _4._5._3 {
    internal class Program {
        static void Main(string[] args) {
            Smartphone smartphone = new();
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] urls = Console.ReadLine().Split(' ').ToArray();
            smartphone.Call(numbers);
            smartphone.Browse(urls);
        }
    }
}