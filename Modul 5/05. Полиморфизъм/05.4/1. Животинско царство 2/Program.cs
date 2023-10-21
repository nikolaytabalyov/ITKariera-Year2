namespace _1._Животинско_царство_2 {
    internal class Program {
        static void Main(string[] args) {

            Dog dog = new();
            Cat cat = new();
            Trainer catTrainer = new(cat);
            Trainer dogTrainer = new(dog);
            catTrainer.Make();
            dogTrainer.Make();

        }
    }
}