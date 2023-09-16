namespace _3 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new();
            for (int i = 0; i < n; i++) {
                string[] arguments = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
                people.Add(new Person(arguments[0], Convert.ToInt32(arguments[1])));
            }
            people = people.OrderBy(x => x.Name).ToList();
            foreach (Person person in people) {
                person.PrintAbove30();
            }
        }
    }

}