using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CryptoMiningSystem.Utilities;

namespace CryptoMiningSystem.Entities.Components.VideoCards {
    public class GameVideoCard : VideoCard {
        public GameVideoCard(string model, decimal price, int generation, int lifeWorkingHours) : base(model, price, generation, lifeWorkingHours) {
            if (generation > 9)
                throw new ArgumentException("Game video card generation cannot be more than 9!");
            Generation = generation;
            MinedMoneyPerHour += MinedMoneyPerHour;
        }
    }
}
