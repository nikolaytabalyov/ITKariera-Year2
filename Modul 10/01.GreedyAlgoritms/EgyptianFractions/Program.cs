namespace EgyptianFractions {
    internal class Program {
        static void Main(string[] args) {
            int numerator = Convert.ToInt32(Console.ReadLine());
            int denumerator = Convert.ToInt32(Console.ReadLine());
            List<(int, int)> egyptianFractions = new();
            egyptianFractions = GetEgyptianFractionRepresentation(numerator, denumerator, egyptianFractions);
            Console.WriteLine($"Original fraction: {numerator} / {denumerator} = {string.Join(" + ", egyptianFractions)}");
        }

        private static List<(int,int)> GetEgyptianFractionRepresentation (int numerator, int denumerator, List<(int,int)> egyptianFractions) {
            (numerator, denumerator) = NormalizeFraction(numerator, denumerator);
            if (numerator == 1) {
                egyptianFractions.Add((numerator, denumerator));
                return egyptianFractions;
            } 

            (int newNumerator, int r) = GetNextEgyptianFraction(numerator, denumerator, out r);
            egyptianFractions.Add((newNumerator, r));

            numerator = numerator * r - denumerator;
            denumerator = denumerator * r;
            return GetEgyptianFractionRepresentation(numerator, denumerator, egyptianFractions);
        }

        private static (int, int) GetNextEgyptianFraction(int numerator, int denumerator, out int r) {
            r = (numerator + denumerator) / numerator;
            return (1, r);
        }

        private static int GetGreatestCommonDivider(int num1, int num2) {
            int r = num1 % num2;
            if (r == 0) {
                return num2;
            }
            return GetGreatestCommonDivider(num2, r);
        }

        private static (int, int) NormalizeFraction(int numerator, int denumerator) {
            int num1 = Math.Max(numerator, denumerator);
            int num2 = Math.Min(numerator, denumerator);
            int gcd = GetGreatestCommonDivider(num1, num2);
            return (numerator/gcd, denumerator/gcd);
        } 
    }
}
