namespace GreatestCommonDivisor {
    internal class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int gcdSubstraction = GetGreatestCommonDivisorWithSubstraction(a, b);
            Console.WriteLine(gcdSubstraction);

            int gcdDivision = GetGreatestCommonDivisorWithDivision(a, b);
            Console.WriteLine(gcdDivision);
        }

        private static int GetGreatestCommonDivisorWithDivision(int a, int b) {
            if (b == 0)
                return a;
            /*int r = b;
            b = a % b;
            a = r;*/
            return GetGreatestCommonDivisorWithDivision(b, a % b);
        }

        private static int GetGreatestCommonDivisorWithSubstraction(int a, int b) {
            if (a == b)
                return a;
            if (a > b)
                return GetGreatestCommonDivisorWithSubstraction(a - b, b);
            else
                return GetGreatestCommonDivisorWithSubstraction(a, b - a);
        }
    }
}
