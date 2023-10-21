namespace _1._Животинско_царство_2 {
    public class Dog : IAnimal {
        public string MakeNoise() => "Woof!";

        public string MakeTrick() => "Hold my paw, human!";

        public void Perform() {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
