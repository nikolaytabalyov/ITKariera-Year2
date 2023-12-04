using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

public class FloweringPlant : Plant {
    private string _color;

    public FloweringPlant(int id, string name, double humidityLevel, double fertilityLevel, string color)
        : base(id, name, "flower", humidityLevel, fertilityLevel) {
        Color = color;
    }

    public string Color {
        get => _color;
        set {
            if (value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Color should be between 3 and 30 characters!");
            _color = value;
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Color: {Color}");
        return sb.ToString().Trim();
    }
}
