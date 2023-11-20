using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class SaturWater
    {
        [ExcelFunction(Description = "饱和水压力", Category = "SaturWater")]
        public static double saturPressure(double t)
        {
            return LakeFunctions.SaturWater.saturPressure.Invoke(t);
        }

        [ExcelFunction(Description = "饱和水温度", Category = "SaturWater")]
        public static double saturTemprature(double p)
        {
            return LakeFunctions.SaturWater.saturTemprature.Invoke(p);
        }

        [ExcelFunction(Description = "饱和水焓", Category = "SaturWater")]
        public static double enthalpy(double p)
        {
            return LakeFunctions.SaturWater.enthalpy.Invoke(p);
        }

        [ExcelFunction(Description = "汽化潜热", Category = "SaturWater")]
        public static double latentHeat(double p)
        {
            return LakeFunctions.SaturWater.latentHeat.Invoke(p);
        }



    }
}
