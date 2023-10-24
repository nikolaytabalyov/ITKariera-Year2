using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class ParkingInterval
{
    private ParkingSpot _parkingSpot;
    private string _registrationPlate;
    private int _hoursParked;
    public ParkingSpot ParkingSpot {
        get => _parkingSpot;
        set { 
            if (value is ParkingSpot)
                _parkingSpot = value;
        }
    }
    
    public string RegistrationPlate {
        get => _registrationPlate;
        set {
            if (!string.IsNullOrEmpty(value))
                _registrationPlate = value;
            else
                throw new ArgumentException("Registration plate can’t be null or empty!");
        }
    }

    public int HoursParked {
        get => _hoursParked;
        set {
            if (value > 0)
                _hoursParked = value;
            else
                throw new ArgumentException("Hours parked can't be zero or negative!");
        }
    }

    public double Revenue {
        get {
            if (ParkingSpot is SubscriptionParkingSpot)
                return 0;
            else {
                return ParkingSpot.Price * HoursParked;
            }
        }
    }

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked) {
        ParkingSpot = parkingSpot;
        RegistrationPlate = registrationPlate;
        HoursParked = hoursParked;
    }

    public override string ToString() {
        return
            ($"> Parking Spot #{ParkingSpot.Id}\n"
            + $"> RegistrationPlate: {RegistrationPlate}\n"
            + $"> HoursParked: {HoursParked}\n"
            + $"> Revenue: {Revenue:F2} BGN").Trim();
    }
}