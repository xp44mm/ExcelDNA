using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class InsulationFunctions
    {
        [ExcelFunction(Description = "", Category = "Insulation")]
        public static double 允许最大散热密度(double temp)
        {
            return LakeFunctions.Insulation.常年最大散热密度.Invoke(temp);
        }

        [ExcelFunction(Description = "", Category = "Insulation")]
        public static double winterHeatloss(double temp)
        {
            return LakeFunctions.Insulation.winterHeatloss.Invoke(temp);
        }

        [ExcelFunction(Description = "", Category = "Insulation")]
        public static double conductivity(string material, double temp)
        {
            return LakeFunctions.Insulation.conductivity(material).Invoke(temp);
        }

        ///捆扎铁丝的直径
        ///d,管道直径,mm
        [ExcelFunction(Description = "", Category = "Insulation")]
        public static double ironWireDiameter(double d)
        {
            if (d < 200)
            {
                return 1.2;
            }
            else if (d < 600)
            {
                return 2;
            }
            else if (d < 100)
            {
                return 2.5;
            }
            else
            {
                return 2.5;
            }
        }

        ///每件紧箍承重环的钢板面积,m2
        ///d,管道直径,mm
        ///w,承面宽度,mm
        [ExcelFunction(Description = "", Category = "Insulation")]
        public static double 紧箍承重环钢板面积(double d, double w)
        {
            //承面面积,mm2
            var p = Math.PI * (d + w) * w;
            //紧箍面积,mm2
            var jg = (Math.PI * d + 4.0 * w) * 40.0;
            return (p + jg) / 1e6;
        }

        ///管道捆扎铁丝用量,kg/m
        ///d,管道直径,mm
        [ExcelFunction(Description = "", Category = "Insulation")]
        public static double ironWireWeight(double d)
        {
            if (d < 100)
            {
                return 0.2;
            }
            else if (d < 200)
            {
                return 0.25;
            }
            else if (d < 300)
            {
                return 0.3;
            }
            else if (d < 700)
            {
                return 0.4;
            }

            else
            {
                return 0.6;
            }
        }


    }
}
