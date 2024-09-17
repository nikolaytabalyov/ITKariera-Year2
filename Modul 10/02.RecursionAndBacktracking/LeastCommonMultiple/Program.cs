namespace LeastCommonMultiple {
    internal class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int lcm = GetLeastCommonMultiple(a, b);
            Console.WriteLine(lcm);
        }

        private static int GetLeastCommonMultiple(int a, int b) {
            int gcd = GetGreatestCommonDivisor(a, b);
            int leastCommonMultiple = (a * b) / gcd;
            return leastCommonMultiple;
        }

        private static int GetGreatestCommonDivisor(int a, int b) {
            if (b == 0)
                return a;
            /*int r = b;
            b = a % b;
            a = r;*/
            return GetGreatestCommonDivisor(b, a % b);
        }
    }
}
