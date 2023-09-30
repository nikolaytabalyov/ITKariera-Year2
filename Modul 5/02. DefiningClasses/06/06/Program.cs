namespace _06 {
    class Program {
        static void Main(string[] args) {

            Person pesho = new("Peshov", "Peshov");
            Console.WriteLine(Person.Counter);

        }
    }

    public class Person {

        private static int counter = 0;

        public Person(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
            counter++;
        }

        public static int Counter => counter;

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}