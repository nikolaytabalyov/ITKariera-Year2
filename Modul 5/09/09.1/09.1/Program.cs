namespace _09._1 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Person noName = new Person(string.Empty, "Goshev", 31);
                //Person negativeAge = new Person("Stoyan", "Kolev", -1);
                //Person noLastName = new Person("Ivan", null, 63);
                //Person tooOldForThisProgram = new Person("Iskren", "Ivanov", 121);
            }
            catch (ArgumentNullException e) {
                Console.WriteLine($"Exception thrown: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine($"Exception thrown: {e.Message}");
            }
        }
    }
}