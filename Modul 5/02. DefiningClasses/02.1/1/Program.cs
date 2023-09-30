using System.Reflection;

namespace _1 {
    class Program {
        static void Main(string[] args) {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person person1 = new() { age = 12, name = "Pesho" };
            Person person2 = new() { age = 18, name = "Gosho" };
            Person person3 = new() { age = 25, name = "Stamat" };
            Console.WriteLine($"Name: {person1.name}, Age: {person1.age}");
            Console.WriteLine($"Name: {person2.name}, Age: {person2.age}");
            Console.WriteLine($"Name: {person3.name}, Age: {person3.age}");


        }
    }
}