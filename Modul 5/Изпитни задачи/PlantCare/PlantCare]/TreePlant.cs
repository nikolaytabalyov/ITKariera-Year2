using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Drawing;

public class TreePlant : Plant {
    private int _height;

    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel, int height)
        : base(id, name, "tree", humidityLevel, fertilityLevel) {
        Height = height;
    }

    public int Height {
        get => _height;
        set {
            if (value < 0)
                throw new ArgumentException("Height should be positive!");
            _height = value;
        }
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Height: {Height}");
        return sb.ToString().Trim();
    }
}

