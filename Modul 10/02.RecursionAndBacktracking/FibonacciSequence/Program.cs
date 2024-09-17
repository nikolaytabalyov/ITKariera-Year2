namespace FibonacciSequence {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(n));
        }

        static int GetFibonacciNumber(int index) {
            if (index <= 0) 
                return 0;
            if (index == 1 || index == 2) 
                return 1;
            else
                return GetFibonacciNumber(index - 1) + GetFibonacciNumber(index - 2);
        }
    }
}
