using System.Text;

internal class ParkingController {
    private List<ParkingSpot> _parkingSpots;

    public ParkingController() {
        _parkingSpots = new List<ParkingSpot>();
    }

    public string CreateParkingSpot(List<string> args) {
        try {
            int id = int.Parse(args[0]);
            if (_parkingSpots.Where(x => x.Id == int.Parse(args[0])).ToList().Count > 0)
                return $"Parking spot {id} is already registered!";

            bool occupied = bool.Parse(args[1]);

            string type = args[2];
            if (type != "car" && type != "bus" && type != "subscription")
                return "Unable to create a parking spot!";

            double price = double.Parse(args[3]);

            switch (type) {
                case "subscription":
                    string registrationPlate = args[4];
                    _parkingSpots.Add(new SubscriptionParkingSpot(id, occupied, price, registrationPlate));
                    break;
                case "car":
                    _parkingSpots.Add(new CarParkingSpot(id, occupied, price));
                    break;
                case "bus":
                    _parkingSpots.Add(new BusParkingSpot(id, occupied, price));
                    break;
            }

            return $"Parking spot {id} was successfully registered in the system!";
        }
        catch (Exception) {
            return "Unable to create a parking spot!";
        }
    }

    public string ParkVehicle(List<string> args) {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];
        int hoursParked = int.Parse(args[2]);
        string type = args[3];
        if (_parkingSpots.Where(x => x.Id == parkingSpotId).ToList().Count > 0) {
            if (_parkingSpots.Find(x => x.Id == parkingSpotId).ParkVehicle(registrationPlate, hoursParked, type)) {
                return $"Vehicle {registrationPlate} parked at {parkingSpotId} for {hoursParked} hours.";
            } else {
                return $"Vehicle {registrationPlate} can't park at {parkingSpotId}.";
            }
        } else {
            return $"Parking spot {parkingSpotId} not found!";
        }
    }

    public string FreeParkingSpot(List<string> args) {
        int parkingSpotId = int.Parse(args[0]);
        if (_parkingSpots.Where(x => x.Id == parkingSpotId).ToList().Count > 0) {
            if (_parkingSpots.Find(x => x.Id == parkingSpotId).Occupied) {
                _parkingSpots.Find(x => x.Id == parkingSpotId).Occupied = false;
                return $"Parking spot {parkingSpotId} is now free!";
            } else {
                return $"Parking spot {parkingSpotId} is not occupied.";
            }
        } else {
            return $"Parking spot {parkingSpotId} not found!";
        }
    }

    public string GetParkingSpotById(List<string> args) {
        int parkingSpotId = int.Parse(args[0]);
        if (_parkingSpots.Where(x => x.Id == parkingSpotId).ToList().Count > 0) {
            return _parkingSpots.Find(x => x.Id == parkingSpotId).ToString();
        } else {
            return $"Parking spot {parkingSpotId} not found!";
        }
    }

    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args) {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];
        StringBuilder info = new();
        if (_parkingSpots.Where(x => x.Id == parkingSpotId).ToList().Count > 0) {
            foreach (var spot in _parkingSpots.Find(x => x.Id == parkingSpotId).GetAllParkingIntervalsByRegistrationPlate(registrationPlate)) {
                info.AppendLine(spot.ToString());
            }
            return info.ToString().Trim();
        } else {
            return $"Parking spot {parkingSpotId} not found!";
        }
    }

    public string CalculateTotal(List<string> args) {
        double sum = 0;
        foreach (var spot in _parkingSpots) {
            sum += spot.CalculateTotal();
        }
        return $"Total revenue from the parking: {sum:F2} BGN";
    }

}

