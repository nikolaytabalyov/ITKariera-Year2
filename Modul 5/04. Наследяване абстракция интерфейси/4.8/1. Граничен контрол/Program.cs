namespace _1._Граничен_контрол {
    internal class Program {
        static void Main(string[] args) {
            List<long> IDs = new();
            List<long> fakeIDs = new();
            while (1 > 0) {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "End") 
                    break;
                else
                    IDs.Add(long.Parse(input.Last()));
            }
            int invalidNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < IDs.Count; i++) {
                if (IDs[i] % 1000 == invalidNumber) {
                    fakeIDs.Add(IDs[i]);
                }
            }
            Console.WriteLine(string.Join("\n", fakeIDs));
        }
    }
}