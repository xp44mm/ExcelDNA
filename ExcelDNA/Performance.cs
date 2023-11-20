using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class Performance
    {
        [ExcelFunction(Description = "", Category = "Performance")]
        public static double TrayMaxVelocity(double flux)
        {
            return LakeFunctions.Performance.trayMaxVelocity(flux);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_base(bool hasTray)
        {
            return LakeFunctions.Performance.rtu_base(hasTray);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_so2(double so2)
        {
            return LakeFunctions.Performance.rtu_so2(so2);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_solids(double solids)
        {
            return LakeFunctions.Performance.rtu_solids(solids);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_ph(double ph)
        {
            return LakeFunctions.Performance.rtu_ph(ph);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_sr(double sr)
        {
            return LakeFunctions.Performance.rtu_sr(sr);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_lg(double lg, int levels)
        {
            return LakeFunctions.Performance.rtu_lg(lg, levels);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_grind(double passing325)
        {
            return LakeFunctions.Performance.rtu_grind(passing325);
        }


        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_dp(double dp)
        {
            return LakeFunctions.Performance.rtu_dp(dp);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_nozzle(double flow, double pressure, double angle)
        {
            return LakeFunctions.Performance.rtu_nozzle(flow, pressure, angle);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_velocity(double v, double ph)
        {
            return LakeFunctions.Performance.rtu_velocity(v, ph);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_cl(double cl, double flux, double so2)
        {
            return LakeFunctions.Performance.rtu_cl(cl, flux, so2);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_quench(bool quench)
        {
            return LakeFunctions.Additive.rtu_quench(quench);
        }

        [ExcelFunction(Description = "", Category = "Performance")]
        public static double rtu_acid(double meq)
        {
            return LakeFunctions.Additive.rtu_acid(meq);
        }


    }
}
