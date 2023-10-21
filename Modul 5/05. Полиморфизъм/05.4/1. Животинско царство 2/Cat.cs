namespace _1._Животинско_царство_2 {
    public class Cat : IAnimal {
        public string MakeNoise() => "Meow!";

        public string MakeTrick() => "No trick for you! I'm too lazy!";

        public void Perform() {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
