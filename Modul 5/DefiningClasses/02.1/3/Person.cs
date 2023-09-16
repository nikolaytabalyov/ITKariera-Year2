namespace _3 {
    class Person {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public void PrintAbove30() {
            if (Age > 30) {
                Console.WriteLine($"{Name} {Age}");
            }
        }
    }
}