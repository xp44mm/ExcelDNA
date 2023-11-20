using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class TowerCalc
    {
        [ExcelFunction(Description = "", Category = "TowerCalc")]
        public static double SO2自然氧化率(double O2, double Cl)
        {
            return LakeFunctions.TowerCalc.SO2自然氧化率(O2, Cl);
        }

        [ExcelFunction(Description = "", Category = "TowerCalc")]
        public static double natoxirate(double stoic, double tds)
        {
            return LakeFunctions.TowerCalc.natoxirate( stoic, tds);
        }

        [ExcelFunction(Description = "", Category = "TowerCalc")]
        public static double 强制氧硫摩尔比(double depth)
        {
            return LakeFunctions.TowerCalc.强制氧硫摩尔比(depth);
        }

        [ExcelFunction(Description = "锥体积", Category = "TowerCalc")]
        public static double coneVolume(double r, double h)
        {
            return LakeFunctions.TowerCalc.coneVolume(r, h);
        }

        [ExcelFunction(Description = "锥台体积", Category = "TowerCalc")]
        public static double truncateConeVolume(double r1, double r2, double h)
        {
            return LakeFunctions.TowerCalc.truncateConeVolume(r1, r2, h);
        }

        [ExcelFunction(Description = "浆液体积", Category = "TowerCalc")]
        public static double slurryVolume(double dia, double hall, double flare, double fHeight, double dll)
        {
            return LakeFunctions.TowerCalc.slurryVolume(dia, hall, flare, fHeight, dll);
        }

        [ExcelFunction(Description = "锥台体积", Category = "TowerCalc")]
        public static double holdupVolume(double ddll, double oxizone, double actvol)
        {
            return LakeFunctions.TowerCalc.holdupVolume(ddll, oxizone, actvol);
        }

        [ExcelFunction(Description = "锥台体积", Category = "TowerCalc")]
        public static double holdup(double dhll, double f, double holdupVol)
        {
            return LakeFunctions.TowerCalc.holdup(dhll, f, holdupVol);
        }


    }
}
