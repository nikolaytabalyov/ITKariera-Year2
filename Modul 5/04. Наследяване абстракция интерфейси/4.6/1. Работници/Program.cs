namespace _1._Работници {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("********* FullTimeEmployee *********");
            FullTimeEmployee fullTimeEmployee = new("1234", "FullTimePesho", "Haskovo", "JrDev", "Video Game");
            fullTimeEmployee.Show();
            Console.WriteLine($"Salary - {fullTimeEmployee.CalculateSalary(10)}");
            Console.WriteLine();
            Console.WriteLine("********* ContractEmployee *********");
            ContractEmployee contractEmployee = new("5678", "ContractPesho", "Sofia", "SeniorDev", "Video Game");
            contractEmployee.Show();
            Console.WriteLine($"Salary - {contractEmployee.CalculateSalary(10)}");
        }
    }
}