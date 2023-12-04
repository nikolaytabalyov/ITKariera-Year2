using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities
{
    using Components.Processors;
    using Components.VideoCards;
    using CryptoMiningSystem.Interfaces;
    //using CryptoMiningSystem.Utilities;
    using System;
    using System.Text;
    public class Computer : IComputer {
        private int _ram;
        private decimal _minedAmountPerHour;

        public Computer(Processor processor, VideoCard videoCard, int ram, decimal minedAmountPerHour) {
            Processor = processor;
            VideoCard = videoCard;
            Ram = ram;
            MinedAmountPerHour = minedAmountPerHour;
        }

        public Processor Processor { get; set; }

        public VideoCard VideoCard { get; set; }

        public int Ram {
            get => _ram;
            set {
                if (value <= 0 || value > 32)
                    throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
                _ram = value;
            }
        }

        public decimal MinedAmountPerHour {
            get => _minedAmountPerHour;
            set {
                _minedAmountPerHour = VideoCard.MinedMoneyPerHour * Processor.MinedMultiplier;
            }
        }
    }
}
