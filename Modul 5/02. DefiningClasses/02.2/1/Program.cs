namespace _1 {
    internal class Program {
        static void Main(string[] args) {
            int n = 3;
            List<RationalNumber> rationalNums = new();
            for (int i = 0; i < n; i++) {
                int numerator = Convert.ToInt32(Console.ReadLine());
                int denumerator = Convert.ToInt32(Console.ReadLine());

                rationalNums.Add(new RationalNumber(numerator, denumerator));
            }

            foreach (var num in rationalNums) {
                num.Print();
            }
        }
    }
}