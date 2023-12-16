using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Controller {
        private readonly Dictionary<int, Plant> _plants;

        public Controller() {
            _plants = new Dictionary<int, Plant>();
        }

        public string AddCareItem(List<string> args) {
            CareItem careItem = new CareItem(args[1], bool.Parse(args[2]));
            int id = int.Parse(args[0]);
            if (!_plants.ContainsKey(id)) {
                return "Plant not found!";
            } else {
                Plant plant = _plants[id];
                plant.AddCareItem(careItem);
                return $"Created Care {args[1]} for {args[0]}!";
            }
        }

        public string AddPlant(List<string> args) { // id, name, humidityLevel, fertilityLevel, type, color OR height
            int id = int.Parse(args[0]);
            string name = args[1];
            double humidityLevel = double.Parse(args[2]);
            double fertilityLevel = double.Parse(args[3]);
            string type = args[4];

            if (_plants.ContainsKey(id))
                return $"Plant with ID {id} already exists!";

            switch (type) {
                case "flower":
                    FloweringPlant flowerPlant = new FloweringPlant(id, name, humidityLevel, fertilityLevel, args[5]);
                    _plants.Add(id, flowerPlant);
                    break;
                case "tree":
                    TreePlant treePlant = new TreePlant(id, name, humidityLevel, fertilityLevel, int.Parse(args[5]));
                    _plants.Add(id, treePlant);
                    break;
            }
            return $"Created Plant {name} with ID {id}!";
        }

        public string GetTotalCaresByPlantId(List<string> args) {
            int id = int.Parse(args[0]);
            if (!_plants.ContainsKey(id))
                return "Plant not found!";
            Plant plant = _plants[id];
            int cares = plant.TotalCaresDone();
            return $"Total cares for plant {id}: {cares}";
        }

        public string WaterPlantById(List<string> args) {
            int id = int.Parse(args[0]);
            double percent = double.Parse(args[1]);
            if (!_plants.ContainsKey(id))
                return "Plant not found!";
            Plant plant = _plants[id];
            if (plant.Water(percent))
                return $"Plant {id} was watered successfully!";
            else
                return $"Plant {id} could not be watered!";
        }

        public string FertilizePlantById(List<string> args) {
            int id = int.Parse(args[0]);
            double percent = double.Parse(args[1]);
            if (!_plants.ContainsKey(id))
                return "Plant not found!";
            Plant plant = _plants[id];
            if (plant.Water(percent))
                return $"Plant {id} was fertilized successfully!";
            else
                return $"Plant {id} could not be fertilized!";
        }

        public string GetTallestTree(List<string> args) {
            List<TreePlant> trees = _plants.Values
                .Where(x => x.GetType() == typeof(TreePlant))
                .Select(x => (TreePlant)x)
                .ToList();
            if (trees.Count == 0)
                return "No trees found!";

            TreePlant tallest = trees.OrderByDescending(x => x.Height).First();
            return tallest.ToString();
        }

}