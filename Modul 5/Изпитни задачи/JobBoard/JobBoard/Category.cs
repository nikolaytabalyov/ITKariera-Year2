using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category {
    private string _name;
    private List<JobOffer> _jobOffers;

    public string Name {
        get => _name;
        set {
            if (value.Length >= 2 && value.Length <= 40)
                _name = value;
            else
                throw new ArgumentException("Name should be between 2 and 40 characters!");
        }
    }

    public Category(string name) {
        Name = name;
        _jobOffers = new List<JobOffer>();
    }

    public void AddJobOffer(JobOffer offer) => _jobOffers.Add(offer);

    public double AverageSalary() => _jobOffers.Sum(x => x.Salary) / _jobOffers.Count;

    public List<JobOffer> GetOffersAboveSalary(double salary) => _jobOffers.Where(x => x.Salary >= salary).OrderBy(x => x.Salary).ToList();

    public List<JobOffer> GetOffersWithoutSalary() => _jobOffers.Where(x => x.Salary == 0).OrderBy(x => x.Company).ToList();

    public override string ToString() {
        StringBuilder output = new StringBuilder();
        output.AppendLine($"Company {Name}");
        output.AppendLine($"Total Offers: {_jobOffers.Count}");
        return output.ToString().Trim();
    }
}