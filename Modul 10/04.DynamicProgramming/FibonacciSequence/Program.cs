namespace FibonacciSequence {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sequence = GetFibonacciSequence(n);
            Console.WriteLine(string.Join(", ", sequence));
        }
        
        static int[] GetFibonacciSequence(int n) {
            int[] sequence = new int[n];
            sequence[0] = 1; sequence[1] = 1;

            for (int i = 2; i < sequence.Length; i++) {
                sequence[i] = sequence[i - 2] + sequence[i - 1];
            }

            return sequence;
        }
    }
}
