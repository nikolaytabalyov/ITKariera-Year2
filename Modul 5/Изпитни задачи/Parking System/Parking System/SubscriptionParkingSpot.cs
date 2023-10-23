using System;
using System.Collections.Generic;
using System.Text;

internal class SubscriptionParkingSpot : ParkingSpot
{
    private string _registrationPlate;
    public string RegistrationPlate {
        get => _registrationPlate;
        set {
            if (string.IsNullOrEmpty(value))
                _registrationPlate = value;
            else
                throw new ArgumentException("Registration plate can’t be null or empty!");
        }
    }

    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price) {
        RegistrationPlate = registrationPlate;    
    }

    public override bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }

    public override double CalculateTotal()
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }
}

