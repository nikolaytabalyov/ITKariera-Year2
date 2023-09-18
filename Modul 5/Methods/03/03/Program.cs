
namespace _03 {
    internal class Program {
        static void Main(string[] args) {
            BankAccount acc = new();
            BankAccount acc2 = new(123456, 50.0m);

            Console.WriteLine(acc.ToString());
            Console.WriteLine(acc2.ToString()); 
        }
    }
}