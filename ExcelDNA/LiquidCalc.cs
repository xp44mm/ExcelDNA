using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;
using Microsoft.FSharp.Collections;

namespace ExcelDNA
{
    public static class LiquidCalc
    {

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double dewateringcase(int d, int p, int c, int s)
        {
            return LakeFunctions.Dewatering.dewateringCase(d, p, c, s);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double CakeCl(double moisture, double effect, double displacement)
        {
            return LakeFunctions.VacuumFilter.CakeCl(moisture, effect, displacement);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double tempCorrection(double temp)
        {
            return LakeFunctions.LiquidCalc.tempCorrection(temp);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double suspendedSpecificGravity(object[] namecol, object[] messcol)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.LiquidCalc.suspendedSpecificGravity(components);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double slurryDensity(double sg)
        {
            return LakeFunctions.LiquidCalc.slurryDensity(sg);
        }


        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double caseSplit(int casing, string name)
        {
            return LakeFunctions.Dewatering.caseSplit(casing, name);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static int caseBleed(int cs)
        {
            return LakeFunctions.Dewatering.caseBleed.Invoke(cs);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static int caseWash(int cs)
        {
            return LakeFunctions.Dewatering.caseWash(cs);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double recycleRatio(object[] namerow, object[] valrow)
        {
            var pairs = MapModule.OfArray(ExcelTools.getPairs(namerow, valrow));

            var p = pairs["p"];
            var q = pairs["q"];
            var r = pairs["r"];
            var s = pairs["s"];
            var t = pairs["t"];
            var u = pairs["u"];
            var v = pairs["v"];
            var w = pairs["w"];
            var x = pairs["x"];
            var y = pairs["y"];
            var z = pairs["z"];

            return LakeFunctions.Dewatering.recycleRatio(p, q, r, s, t, u, v, w, x, y, z);
        }

        [ExcelFunction(Description = "", Category = "LiquidCalc")]
        public static double recycle(object[] namerow, object[] valrow)
        {
            var pairs = MapModule.OfArray(ExcelTools.getPairs(namerow, valrow));

            var p = pairs["p"];
            var q = pairs["q"];
            var r = pairs["r"];
            var s = pairs["s"];
            var t = pairs["t"];
            var u = pairs["u"];
            var v = pairs["v"];
            var w = pairs["w"];
            var x = pairs["x"];
            var y = pairs["y"];
            var z = pairs["z"];

            return LakeFunctions.Dewatering.recycleRatio(p, q, r, s, t, u, v, w, x, y, z);
        }


    }
}
