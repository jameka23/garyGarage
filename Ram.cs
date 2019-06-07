using System;

namespace garyGarage{
public class Ram : IGasPowered{  // Gas powered truck
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void RefuelTank () { Console.WriteLine("Refueling the car.");
    }
}    
}