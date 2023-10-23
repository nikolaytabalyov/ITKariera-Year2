namespace _1._Ферма_за_животни {
    public abstract class Mammal : Animal {
        protected Mammal(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight) {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; protected set; }

        public override string ToString() => $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";

    }
}
