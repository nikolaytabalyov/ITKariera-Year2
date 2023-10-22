namespace _1._Ферма_за_животни {
    public class Cat : Feline {
        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalType, animalName, animalWeight, livingRegion) {
            Breed = breed;
        }

        public string Breed { get; private set; }

        public override void MakeSound() => Console.WriteLine("Meowwww");
        public override string ToString() => $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
