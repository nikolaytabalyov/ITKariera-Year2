using System;
using System.Collections.Generic;
using System.Text;


public class OnSiteJobOffer : JobOffer {
    private string _city;
    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary) {
        City = city;
    }

    public string City {
        get => _city;
        set {
            if (value.Length >= 3 && value.Length <= 30)
                _city = value;
            else
                throw new ArgumentException("City should be between 3 and 30 characters!");
        }
    }


    public override string ToString() {
        StringBuilder output = new StringBuilder();
        output.AppendLine($"Job Title: {JobTitle}");
        output.AppendLine($"Company: {Company}");
        output.AppendLine($"Salary: {Salary:F2} BGN");
        output.AppendLine($"City: {City}");
        return output.ToString().Trim();
    }
}

