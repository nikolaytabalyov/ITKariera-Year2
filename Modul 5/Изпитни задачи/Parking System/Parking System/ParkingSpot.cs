using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ParkingSpot
{
    private int _id;
    private bool _occupied;
    private string _type;
    private double _price;
    protected List<ParkingInterval> _parkingIntervals;

    public int Id { get => _id; set => _id = value; }

    public bool Occupied { get => _occupied; set => _occupied = value; }

    public string Type { get => _type; set => _type = value; }

    public double Price {
        get => _price;
        set {
            if (_price > 0)
                _price = value;
            else
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
        }
    }

    public ParkingSpot(int id, bool occupied, string type, double price) {
        _id = id;
        _occupied = occupied;
        _type = type;
        _price = price;
        _parkingIntervals = new();
    }

    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type) {
        if (this.Type == type && !Occupied) {
            _parkingIntervals.Add(new ParkingInterval(this, registrationPlate, hoursParked));
            return true;
        } else {
            return false;
        }
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate) {
        return _parkingIntervals.FindAll(x => x.RegistrationPlate == registrationPlate);
    }

    public virtual double CalculateTotal() {
        return _parkingIntervals.Sum(x => x.HoursParked * this.Price);
    }

    public override string ToString() {
        return
            ($"> Parking Spot #{Id}\n"
            + $"> Occupied: {Occupied}\n"
            + $"> Type: {Type}\n"
            + $"> Price per hour: {Price:F2} BGN").Trim();
    }

}
