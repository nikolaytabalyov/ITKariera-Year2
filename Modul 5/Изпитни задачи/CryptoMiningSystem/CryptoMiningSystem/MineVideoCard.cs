using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CryptoMiningSystem.Utilities;

namespace CryptoMiningSystem.Entities.Components.VideoCards {
    public class MineVideoCard : VideoCard {
        public MineVideoCard(string model, decimal price, int generation, int lifeWorkingHours) : base(model, price, generation, lifeWorkingHours) {
            if (generation > 6)
                throw new ArgumentException("Mine video card generation cannot be more than 6!");
            Generation = generation;
            MinedMoneyPerHour += MinedMoneyPerHour * 7;
            LifeWorkingHours += LifeWorkingHours;
        }
    }
}
