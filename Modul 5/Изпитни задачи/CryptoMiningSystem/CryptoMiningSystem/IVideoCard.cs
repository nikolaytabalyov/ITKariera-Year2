using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Components.VideoCards.Contracts {
    public interface IVideoCard {
        decimal MinedMoneyPerHour { get; }
        int Ram { get; }
    }
}
