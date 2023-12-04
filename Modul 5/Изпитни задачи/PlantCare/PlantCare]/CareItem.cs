using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

public class CareItem {
    private string _name;
    private bool _status;
    public CareItem(string name, bool status) {
        Name = name;
        Status = status;
    }

    public string Name {
        get => _name;
        set {
            if (value.Length < 2 || value.Length > 40)
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            _name = value;
        }
    }

    public bool Status { get; private set; }
    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"CareItem {Name}");
        sb.AppendLine($"Status: {Status}");
        return sb.ToString().Trim();
    }
}