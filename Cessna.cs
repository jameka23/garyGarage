using System;
namespace garyGarage{
public class Cessna : IGasPowered{  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void RefuelTank () { Console.WriteLine("Refueling aircraft"); }
}    
}