public class Controller {
    private readonly Dictionary<string, Category> _categories;

    public Controller() {

    }

    public string AddCategory(List<string> args) {
        _categories.Add(args[0], new Category(args[0]));
        return $"Created Category {args[0]}!";
    }

    public string AddJobOffer(List<string> args) {
        if (args[4] == "onsite") {
            _categories[args[0]].AddJobOffer(new OnSiteJobOffer(args[1], args[2], double.Parse(args[3]), Console.ReadLine()));
            return $"Created JobOffer {args[1]} in Category {args[0]}!";
        } else {
            _categories[args[0]].AddJobOffer(new RemoteJobOffer(args[1], args[2], double.Parse(args[3]), bool.Parse(Console.ReadLine())));
            return $"Created JobOffer {args[1]} in Category {args[0]}!";
        }
    }

    public string GetAverageSalary(List<string> args) {
        if (_categories.ContainsKey(args[0]))
            return $"The average salary is: {_categories[args[0]].AverageSalary()} BGN";
        else
            return "0";
    }

    public string GetOffersAboveSalary(List<string> args) {
        _categories[args[0]].GetOffersAboveSalary(double.Parse(args[1]));
        return "OffersAboveSalary have been got successfully";
    }

    public string GetOffersWithoutSalary(List<string> args) {
        _categories[args[0]].GetOffersWithoutSalary();
        return "OffersWithoutSalary have been got successfully"; ;
    }

}