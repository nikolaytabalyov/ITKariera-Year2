using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Components.Contracts {
    public interface IComponent {
        string Model { get; }
        decimal Price { get; }
        int Generation { get; }
        int LifeWorkingHours { get; }
    }
}
