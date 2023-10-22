namespace _1._Ферма_за_животни {
    internal class Program {
        static void Main(string[] args) {

            bool isRunning = true;
            List<Mammal> mammals = new List<Mammal>();

            while(isRunning) {

                List<string> commands = Console.ReadLine().Split(' ').ToList();
                switch (commands[0]) {
                    case "Cat":
                        mammals.Add(new Cat(commands[0], commands[1], double.Parse(commands[2]), commands[3], commands[4]));
                        break;
                    case "Tiger":
                        mammals.Add(new Tiger(commands[0], commands[1], double.Parse(commands[2]), commands[3]));
                        break;
                    case "Zebra":
                        mammals.Add(new Zebra(commands[0], commands[1], double.Parse(commands[2]), commands[3]));
                        break;
                    case "Mouse":
                        mammals.Add(new Mouse(commands[0], commands[1], double.Parse(commands[2]), commands[3]));
                        break;
                    case "End":
                        foreach (Mammal m in mammals)
                            Console.WriteLine(m.ToString());
                        isRunning = false;
                        return;
                }

                List<string> foodCommands = Console.ReadLine().Split(' ').ToList();
                if (foodCommands[0] == "Vegetable") {
                    mammals.Last().EatFood(new Vegetable(int.Parse(foodCommands[1])));
                } else if (foodCommands[0] == "Meat") {
                    mammals.Last().EatFood(new Meat(int.Parse(foodCommands[1])));
                }
            }
        }
    }
}