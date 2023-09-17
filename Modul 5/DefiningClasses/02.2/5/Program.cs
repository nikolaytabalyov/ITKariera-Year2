namespace _5 {
    class Program {
        static void Main(string[] args) {
            List<EvenNumber> evenNumbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(x => new EvenNumber(Convert.ToInt32(x))).Where(x => x.Num != 0).ToList();
            Console.WriteLine(string.Join(", ", evenNumbers.Select(x => x.Num).ToList()));
        }
    }
}