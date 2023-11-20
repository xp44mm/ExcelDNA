using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class Validation
    {
        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_so2(double so2)
        {
            return LakeFunctions.Validation.validate_so2(so2);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_solids(double solids)
        {
            return LakeFunctions.Validation.validate_solids(solids);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_inerts(double inerts)
        {
            return LakeFunctions.Validation.validate_inerts(inerts);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_ph(double ph)
        {
            return LakeFunctions.Validation.validate_ph(ph);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_sr(double sr)
        {
            return LakeFunctions.Validation.validate_sr(sr);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_lg(double lg)
        {
            return LakeFunctions.Validation.validate_lg(lg);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_levels(int levels)
        {
            return LakeFunctions.Validation.validate_levels(levels);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_dp(double dp)
        {
            return LakeFunctions.Validation.validate_dp(dp);
        }


        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_grind(double grind325)
        {
            return LakeFunctions.Validation.validate_grind(grind325);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_nozzleFlow(double flow)
        {
            return LakeFunctions.Validation.validate_nozzleFlow(flow);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_nozzlePressure(double pressure)
        {
            return LakeFunctions.Validation.validate_nozzlePressure(pressure);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_nozzleDensity(double dens)
        {
            return LakeFunctions.Validation.validate_nozzleDensity(dens);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_nozzleAngle(double angle)
        {
            return LakeFunctions.Validation.validate_nozzleAngle(angle);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_velocity(double v)
        {
            return LakeFunctions.Validation.validate_velocity(v);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string Validate_trayMinVelocity(double vel)
        {
            return LakeFunctions.Validation.Validate_trayMinVelocity(vel);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string Validate_trayDp(double dp)
        {
            return LakeFunctions.Validation.Validate_trayDp(dp);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_cl(double cl)
        {
            return LakeFunctions.Validation.validate_cl(cl);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_rt(double rt)
        {
            return LakeFunctions.Validation.validate_rt(rt);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_outletSO2(double ppmdv)
        {
            return LakeFunctions.Validation.validate_outletSO2(ppmdv);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string validate_acidMeq(bool noAcid, double meq)
        {
            return LakeFunctions.Additive.validate_acidMeq(noAcid, meq);
        }

        [ExcelFunction(Description = "", Category = "Validation")]
        public static string PerformanceRisk(bool isInterspacial, double eff, double margin)
        {
            return LakeFunctions.Validation.PerformanceRisk(isInterspacial, eff, margin);
        }



    }
}
