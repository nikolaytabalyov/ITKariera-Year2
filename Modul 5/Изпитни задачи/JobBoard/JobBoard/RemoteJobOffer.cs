using System.Text;

public class RemoteJobOffer : JobOffer {
    private bool _fullyRemote;

    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary) {
        FullyRemote = fullyRemote;
    }

    public bool FullyRemote {
        get => _fullyRemote;
        set {
            if (value is bool)
                _fullyRemote = value;
            else
                throw new ArgumentException("Invalid value");
        }
    }

    public override string ToString() {
        StringBuilder output = new StringBuilder();
        output.AppendLine($"Job Title: {JobTitle}");
        output.AppendLine($"Company: {Company}");
        output.AppendLine($"Salary: {Salary:F2} BGN");
        string result = FullyRemote ? "yes" : "no";
        output.AppendLine($"Fully Remote: {result}");
        return output.ToString().Trim();
    }
}

