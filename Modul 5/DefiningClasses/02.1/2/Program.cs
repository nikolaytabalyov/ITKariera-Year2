namespace _2 {
    internal class Program {
        static void Main(string[] args) {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                string[] arguments = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
                family.People.Add(new Person(arguments[0], Convert.ToInt32(arguments[1])));
            }

            family.Print();
        }
    }
}