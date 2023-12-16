using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    using CryptoMiningSystem.Entities.Components;
    //using CryptoMiningSystem.Utilities;
    using Contracts;
    using System;
    using CryptoMiningSystem.Interfaces;

    public abstract class Processor : Component, IProcessor {
        public Processor(string model, decimal price, int generation, int lifeWorkingHours) : base(model, price, generation, lifeWorkingHours) {
            if (generation > 9)
                throw new ArgumentException($"{GetType().Name} generation cannot be more than 9!");
            else 
                Generation = generation;
            LifeWorkingHours = Generation * 100; 
        }

        public int MineMultiplier { get; set; }
    }
}
