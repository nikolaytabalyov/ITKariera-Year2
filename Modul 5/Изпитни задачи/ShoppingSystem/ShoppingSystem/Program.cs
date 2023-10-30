namespace ShoppingSystem {
    internal class Program {
        static void Main(string[] args) {
            Controller controller = new Controller();
            Engine engine = new Engine(controller);
            Console.WriteLine(engine.Run());
        }
    }
}