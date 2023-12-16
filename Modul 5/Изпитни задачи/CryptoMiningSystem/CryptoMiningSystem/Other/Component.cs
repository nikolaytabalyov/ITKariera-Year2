using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Components
{
    //using CryptoMiningSystem.Utilities;
    using Contracts;
    using CryptoMiningSystem.Interfaces;
    using System;
    using System.Text;
    public abstract class Component : IComponent {
        private string _model;
        private decimal _price;
        private int _generation;

        protected Component(string model, decimal price, int generation, int lifeWorkingHours) {
            Model = model;
            Price = price;
            Generation = generation;
            LifeWorkingHours = lifeWorkingHours;
        }

        public string Model {
            get => _model;
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Model cannot be null or empty!");
                _model = value;
            }
        }

        public decimal Price {
            get => _price;
            set {
                if (value <= 0 || value > 10000)
                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
                _price = value;
            }
        }

        public int Generation {
            get => _generation;
            set {
                if (value <= 0)
                    throw new ArgumentException("Generation cannot be 0 or negative!");
                _generation = value;
            }
        }

        public int LifeWorkingHours { get; set; }
    }
}
