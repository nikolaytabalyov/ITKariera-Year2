using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    using CryptoMiningSystem.Entities.Components;
    //using CryptoMiningSystem.Utilities;
    using Contracts;
    using System;
    using CryptoMiningSystem.Interfaces;

    public abstract class VideoCard : Component, IVideoCard {
        private int _ram;
        private decimal _minedMoneyPerHour;

        protected VideoCard(string model, decimal price, int generation, int lifeWorkingHours) : base(model, price, generation, lifeWorkingHours) {
            LifeWorkingHours = Ram * Generation * 10;
        }

        public decimal MinedMoneyPerHour {
            get => _minedMoneyPerHour;
            set => _minedMoneyPerHour = Ram * Generation / 10;
        }

        public int Ram {
            get => _ram;
            set {
                if (value <= 0 || value > 32)
                    throw new ArgumentException($"{GetType().Name} ram cannot less or equal to 0 and more than 32!");
                _ram = value;
            }
        }
    }
}
