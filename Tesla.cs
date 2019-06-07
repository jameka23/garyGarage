using System;
namespace garyGarage{
public class Tesla:IElectricPowered {  // Electric car
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void ChargeBattery () { Console.WriteLine("Tesla going to the charging tower"); 
    }
}

}