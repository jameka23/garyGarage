using System;
using System.Collections.Generic;

namespace garyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

            electricVehicles.Add(fx);
            electricVehicles.Add(fxs);
            electricVehicles.Add(modelS);
            // modelS.ChargeBattery();


            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasPowered> gasVehicles = new List<IGasPowered>{
                ram, cessna150
            };

            gasVehicles.ForEach(gv => gv.RefuelTank());
        }
    }
}
