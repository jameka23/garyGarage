using System;

namespace garyGarage{
    public class Zero:IElectricPowered {  // Electric motorcycle
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void ChargeBattery () { Console.WriteLine("Zero, going to the charge tower.");
    }
}

}