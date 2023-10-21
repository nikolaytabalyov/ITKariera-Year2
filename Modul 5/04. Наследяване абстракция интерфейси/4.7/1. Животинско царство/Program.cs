namespace _1._Животинско_царство {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("****** Cat ******");
            Cat cat = new("Tommy", 1);
            cat.MakeNoise();
            cat.MakeTrick();
            Console.WriteLine("****** Dog ******");
            Dog dog = new("Rex", 2);
            dog.MakeNoise();
            dog.MakeTrick();
        }
    }
}