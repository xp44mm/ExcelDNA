using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class GasCalc
    {
        [ExcelFunction(Description = "", Category = "IdealGas")]
        public static double moleEnthalpy(string form, double k)
        {
            return LakeFunctions.IdealGas.moleEnthalpy.Invoke(form).Invoke(k);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double specificHumidity(double press, double temp, double relativeHumidity)
        {
            return LakeFunctions.GasCalc.specificHumidity(press, temp, relativeHumidity);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double reactHeat(string reagent, object[] namecol, object[] messcol)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.reactHeat(reagent, components);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double gasEnthalpy(object[] namecol, object[] messcol, double temp)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.gasEnthalpy(components, temp);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double gasTemperature(object[] namecol, object[] messcol, double temp)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.gasTemperature(components, temp);
        }


        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double mixTemprature(object[] namecol, object[] messcol1, object[] messcol2, double t1, double t2)
        {
            var components1 = ExcelTools.getPairs(namecol, messcol1);
            var components2 = ExcelTools.getPairs(namecol, messcol2);
            return LakeFunctions.GasCalc.mixTemprature(components1, components2, t1, t2);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double gainHeat(object[] namecol, object[] messcol, double t1, double t2)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.gainHeat(components, t1, t2);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double heating(object[] namecol, object[] messcol, double t0, double heat)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.heating(components, t0, heat);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double gasSaturWaterMass(object[] namecol, object[] messcol, double press, double temp)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.gasSaturWaterMass(components, press, temp);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double gasSaturTemprature(object[] namecol, object[] messcol, double press)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.gasSaturTemprature(components, press);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double evaporativeCooling(object[] namecol, object[] messcol, double press, double temp, double heat)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.evaporativeCooling(components, press, temp, heat);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double totalKmol(object[] namecol, object[] messcol)
        {
            var components = ExcelTools.getPairs(namecol, messcol);
            return LakeFunctions.GasCalc.totalKmol(components);
        }

        [ExcelFunction(Description = "", Category = "GasCalc")]
        public static double gasVolumeCorrect(double pres, double temp)
        {
            return LakeFunctions.IdealGas.volumeCorrect(pres, temp);
        }

        [ExcelFunction(Description = "硫酸露點溫度", Category = "GasCalc")]
        public static double dewPoint(double so3, double moist)
        {
            return LakeFunctions.GasCalc.dewPoint(so3, moist);
        }

        [ExcelFunction(Description = "壓力修正係數", Category = "IdealGas")]
        public static double Pcorrect(double p)
        {
            return 101325 / p;
        }

        [ExcelFunction(Description = "溫度修正係數", Category = "IdealGas")]
        public static double Tcorrect(double t)
        {
            return (t + 273.15) / 273.15;
        }



    }
}
