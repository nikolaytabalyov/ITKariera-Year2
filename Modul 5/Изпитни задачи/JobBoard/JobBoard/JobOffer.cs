using System.Text;

public abstract class JobOffer {
    private string _jobTitle;
    private string _company;
    private double _salary;

    public JobOffer(string jobTitle, string company, double salary) {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
    }

    public string JobTitle {
        get => _jobTitle;
        set {
            if (value.Length >= 3 && value.Length <= 30)
                _jobTitle = value;
            else
                throw new ArgumentException("JobTitle should be between 3 and 30 characters!");
        }
    }

    public string Company {
        get => _company;
        set {
            if (value.Length >= 3 && value.Length <= 30)
                _company = value;
            else
                throw new ArgumentException("Company should be between 3 and 30 characters!");
        }
    }

    public double Salary {
        get => _salary;
        set {
            if (value >=  0)
                _salary = value;
            else
                throw new ArgumentException("Salary should be 0 or positive!");
        }
    }


    public override string ToString() {
        StringBuilder output = new StringBuilder();
        output.AppendLine($"Job Title: {JobTitle}");
        output.AppendLine($"Company: {Company}");
        output.AppendLine($"Salary: {Salary:F2} BGN");
        return output.ToString().Trim();
    }

}
