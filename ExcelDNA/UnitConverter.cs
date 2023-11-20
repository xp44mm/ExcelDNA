using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class UnitConverter
    {
        [ExcelFunction(Description = "华氏温度转为摄氏温度", Category = "UnitConverter")]
        public static double degC(double f)
        {
            return LakeFunctions.UnitConverter.degC(f);
        }

        [ExcelFunction(Description = "摄氏温度转为华氏温度", Category = "UnitConverter")]
        public static double degF(double c)
        {
            return LakeFunctions.UnitConverter.degF(c);
        }

        [ExcelFunction(Description = "摄氏温度转为华氏温度", Category = "UnitConverter")]
        public static double units(string from_unit, string to_unit)
        {
            return LakeFunctions.UnitConverter.units.Invoke(new Tuple<string, string>(from_unit, to_unit));
        }

    }
}
