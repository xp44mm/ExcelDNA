using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class PerfCalc
    {
        [ExcelFunction(Description = "", Category = "PerfCalc")]
        public static double trayPressureDrop(double lg, double vel)
        {
            return LakeFunctions.PerfCalc.trayPressureDrop.Invoke(lg).Invoke(vel);
        }

        [ExcelFunction(Description = "", Category = "PerfCalc")]
        public static double dPSpray(double flux, double vel)
        {
            return LakeFunctions.PerfCalc.dPSpray(flux, vel);
        }

        [ExcelFunction(Description = "", Category = "PerfCalc")]
        public static double dPInlet(double flux)
        {
            return LakeFunctions.PerfCalc.dPInlet(flux);
        }

        [ExcelFunction(Description = "", Category = "PerfCalc")]
        public static double pH(double sr, double rt)
        {
            return LakeFunctions.PerfCalc.pH(sr, rt);
        }

        [ExcelFunction(Description = "", Category = "PerfCalc")]
        public static double meq(string acidType, double ppm, double sln)
        {
            return LakeFunctions.Additive.meq(acidType, ppm, sln);
        }



    }
}
