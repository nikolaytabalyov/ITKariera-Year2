namespace _1._Ферма_за_животни {
    public class Mouse : Mammal {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion) {
        }

        public override void MakeSound() => Console.WriteLine("SQUEEEAAAK!");
    }
}
