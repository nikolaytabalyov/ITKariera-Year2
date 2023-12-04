using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Components.Processors {
    public class LowPerformanceProcessor : Processor {
        public LowPerformanceProcessor(string model, decimal price, int generation, int lifeWorkingHours) : base(model, price, generation, lifeWorkingHours) {
            MineMultiplier = 2;
        }
    }
}
