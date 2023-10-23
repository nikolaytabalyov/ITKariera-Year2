namespace _1._Ферма_за_животни {
    public class Tiger : Feline {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion) {
        }

        public override void MakeSound() => Console.WriteLine("ROARR!!!");
    }
}
