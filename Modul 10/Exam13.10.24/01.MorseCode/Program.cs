
namespace _01.MorseCode {
    internal class Program {
        static List<string> codes = new List<string>();
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || n > 20)
                throw new ArgumentException("Non valid n");
            List<List<int>> combinations = new List<List<int>>();
            List<int> indexes = codes.Select(x => codes.IndexOf(x)).ToList();
            for (int i = 0; i < n; i++) {
                string input = Console.ReadLine();
                if (input.Length != n)
                    throw new ArgumentException("Incorrect length of code");
                
                codes.Add(input);
            }
            GetCombinations(new int[n], 0, 1, n);
        }

        static void GetCombinations(int[] arr, int index, int start, int end) {
            if (index >= arr.Length) {
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write($"{codes[arr[i] - 1]}");//, arr[i]);
                    else Console.Write(codes[arr[i] - 1]);//arr[i]);
                Console.WriteLine();
            } else {
                for (int i = start; i <= end; i++) {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
            }
        }
    }
}
