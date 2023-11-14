using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoMiningSystem.Entities.Components.Processors;
using CryptoMiningSystem.Entities.Components.VideoCards;

namespace CryptoMiningSystem.Entities.Contracts {
    public interface IComputer {
        Processor Processor { get; }
        VideoCard VideoCard { get; }
        int Ram { get; }
        decimal MinedAmountPerHour { get; }
    }
}
