using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Plant {
    private int _id;
    private string _name;
    private string _type;

    private double _fertilityLevel;
    private double _humidityLevel;
    private List<CareItem> _careItems;
    public Plant(int id, string name, string type, double humidityLevel, double fertilityLevel) {
        _careItems = new List<CareItem>();
        Id = id;
        Name = name;
        Type = type;
        HumidityLevel = humidityLevel;
        FertilityLevel = fertilityLevel;
    }

    public int Id { get; protected set; }

    public string Name {
        get => _name;
        set {
            if (value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            _name = value;
        }
    }

    public string Type {
        get => _type;
        set {
            if (value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Type should be between 3 and 30 characters!");
            _type = value;
        }
    }

    public double HumidityLevel {
        get => _humidityLevel;
        set {
            if (value < 0 || value > 1)
                throw new ArgumentException("Humidity Level should be between 0 and 1!");
            _humidityLevel = value;
        }
    }

    public double FertilityLevel {
        get => _fertilityLevel;
        set {
            if (value < 0 || value > 1)
                throw new ArgumentException("Fertility Level should be between 0 and 1!");
            _fertilityLevel = value;
        }
    }

    public void AddCareItem(CareItem careItem) => _careItems.Add(careItem);

    public int TotalCaresDone() => _careItems.Where(x => x.Status == true).ToList().Count;

    public bool Water(double percent) {
        double totalAfter = HumidityLevel + percent;
        if (totalAfter > 1) {
            return false;
        } else {
            HumidityLevel = totalAfter;
            return true;
        }
    }

    public bool Fertilize(double percent) {
        double totalAfter = FertilityLevel + percent;
        if (totalAfter > 1) {
            return false;
        } else {
            FertilityLevel = totalAfter;
            return true;
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Id: {Id}");
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Type: {Type}");
        sb.AppendLine($"Humidity Level: {HumidityLevel:F2} %");
        sb.AppendLine($"Fertility Level: {FertilityLevel:F2} %");
        return sb.ToString().Trim();
    }
}
