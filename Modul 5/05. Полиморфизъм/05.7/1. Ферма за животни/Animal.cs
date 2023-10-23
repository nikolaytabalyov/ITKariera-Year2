namespace _1._Ферма_за_животни {
    public abstract class Animal {
        protected Animal(string animalType, string animalName, double animalWeight) {
            AnimalType = animalType;
            AnimalName = animalName;
            AnimalWeight = animalWeight;
        }

        public string AnimalName { get; protected set; }
        public string AnimalType { get; protected set; }
        public double AnimalWeight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract void MakeSound();
        public virtual void EatFood(Food food) {
            if (food is Vegetable) {
                if (this is Mouse || this is Zebra || this is Cat)
                    this.FoodEaten += food.Quantity;
                else if (this is Tiger)
                    Console.WriteLine($"{GetType().Name} are not eating this type of food!");
            } else if (food is Meat) {
                if (this is Tiger || this is Cat)
                    this.FoodEaten += food.Quantity;
                else if (this is Mouse || this is Zebra)
                    Console.WriteLine($"{GetType().Name} are not eating this type of food!");
            }
        }
    }
}
