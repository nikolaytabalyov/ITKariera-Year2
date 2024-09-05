namespace SumRepresentation {
    internal class Program {
        static void Main(string[] args) {
            int wantedSum = Convert.ToInt32(Console.ReadLine());
            int currentSum = 0;
            int[] coins = { 25, 25, 10, 10, 10, 5, 5, 5, 1, 1, 1 };
            List<int> collectedCoins = new List<int>();

            for (int i = 0; i <= coins.Length; i++) {
                if (currentSum == wantedSum) {
                    Console.WriteLine(string.Join(", ", collectedCoins));
                    break;
                }

                if (currentSum + coins[i] <= wantedSum) {
                    currentSum += coins[i];
                    collectedCoins.Add(coins[i]);
                }
            }
        }
    }
}
