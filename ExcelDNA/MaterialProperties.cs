using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class MaterialProperties
    {
        [ExcelFunction(Description = "摩尔质量", Category = "MaterialProperties")]
        public static double molar(string formula)
        {
            return LakeFunctions.MaterialProperties.molar.Invoke(formula);
        }

        [ExcelFunction(Description = "比重", Category = "MaterialProperties")]
        public static double specificGravity(string formula)
        {
            return LakeFunctions.MaterialProperties.specificGravity.Invoke(formula);
        }

        [ExcelFunction(Description = "溶解度", Category = "MaterialProperties")]
        public static double solubility(string formula)
        {
            return LakeFunctions.MaterialProperties.solubility.Invoke(formula);
        }
    }
}
