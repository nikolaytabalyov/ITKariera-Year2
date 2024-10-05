namespace SequenceFrom0And1 {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetCountOfSequencesFrom0And1(n));

        }
        static int GetCountOfSequencesFrom0And1(int n) {
            int[] counts = new int[n + 1];
            counts[0] = 0; counts[1] = 2; counts[2] = 3;
            for (int i = 3; i < counts.Length; i++) {
                counts[i] = counts[i - 2]+ counts[i-1];
            }
            return counts[n];
        }
    }
}
