namespace _01.LeastWalkedDistanceForFriends {
    internal class Program {
        static void Main(string[] args) {
            List<int> streetNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            streetNumbers.Sort();
            Console.WriteLine(streetNumbers[2] - streetNumbers[0]);
        }
    }
}
