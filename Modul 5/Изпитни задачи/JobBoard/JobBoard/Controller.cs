using System.Text;

public class Controller {
    private readonly Dictionary<string, Category> _categories;

    public Controller() {
        _categories = new Dictionary<string, Category>();
    }

    public string AddCategory(List<string> args) {
        _categories.Add(args[0], new Category(args[0]));
        return $"Created Category {args[0]}!";
    }

    public string AddJobOffer(List<string> args) {
        if (args[4] == "onsite") {
            _categories[args[0]].AddJobOffer(new OnSiteJobOffer(args[1], args[2], double.Parse(args[3]), args[5]));
            return $"Created JobOffer {args[1]} in Category {args[0]}!";
        } else {
            _categories[args[0]].AddJobOffer(new RemoteJobOffer(args[1], args[2], double.Parse(args[3]), bool.Parse(args[5])));
            return $"Created JobOffer {args[1]} in Category {args[0]}!";
        }
    }

    public string GetAverageSalary(List<string> args) {
        if (_categories.ContainsKey(args[0]))
            return $"The average salary is: {_categories[args[0]].AverageSalary():F2} BGN";
        return $"The average salary is: {0:F2} BGN";
    }

    public string GetOffersAboveSalary(List<string> args) {
        StringBuilder sb = new StringBuilder();
        List<JobOffer> jobOffers = _categories[args[0]].GetOffersAboveSalary(double.Parse(args[1]));
        jobOffers.ForEach(x => sb.AppendLine(x.ToString()));
        return sb.ToString().Trim();
    }

    public string GetOffersWithoutSalary(List<string> args) {
        StringBuilder sb = new StringBuilder();
        List<JobOffer> jobOffers = _categories[args[0]].GetOffersWithoutSalary();
        jobOffers.ForEach(x => sb.AppendLine(x.ToString()));
        return sb.ToString().Trim();
    }

}