namespace Permutations {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(Permutate(new int[]{ 0, 1, 2, 3, 4}));
        }

        static int Permutate(int[] numbers) {
            // getting the number of combinations for one of the numbers except 0
            bool containsZero = numbers.Contains(0);
            int countOfNums = containsZero ? numbers.Length - 1 : numbers.Length;

            int combinations = 1;
            for (int i = 1; i <= countOfNums; i++) {
                combinations *= i;
            }

            combinations = containsZero ? combinations * countOfNums : combinations;
            return combinations;
        }
    }
}
