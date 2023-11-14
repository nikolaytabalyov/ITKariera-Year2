using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Components.Processors.Contracts {
    public interface IProcessor {
        int MineMultiplier { get; }
    }
}
