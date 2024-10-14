namespace _01.DoubleFuFu {
    internal class Program {
        static void Main(string[] args) {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string input = Console.ReadLine();
            char firstLetter = input[0];
            char secondLetter = input[1];
            if (!alphabet.Contains(firstLetter)
                || !alphabet.Contains(firstLetter)
                || input.Length != 2
                || firstLetter == secondLetter) {
                Console.WriteLine("No FuFu");
                return;
            }
            int firstIndex = alphabet.IndexOf(firstLetter);
            int secondIndex = alphabet.IndexOf(secondLetter) + 1;

            if (secondIndex > firstIndex) { // if (2nd letter is before 1st, the indexing should start from one back
                Console.WriteLine(firstIndex * 25 + secondIndex - 1);
            } else { // if 2nd letter is before 1st, the indexing should be normal 
                Console.WriteLine(firstIndex * 25 + secondIndex);
            }
        }
    }
}
