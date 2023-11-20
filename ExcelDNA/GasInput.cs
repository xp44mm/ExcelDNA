using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class GasInput
    {
        [ExcelFunction(Description = "飞灰预计移除率", Category = "GasInput")]
        public static double FlyashExpectedRemoval(double loading)
        {
            return LakeFunctions.GasInput.FlyashExpectedRemoval(loading);
        }

        [ExcelFunction(Description = "飞灰保证移除率", Category = "GasInput")]
        public static double FlyashGuaranteedRemoval(double loading)
        {
            return LakeFunctions.GasInput.FlyashGuaranteedRemoval(loading);
        }

        [ExcelFunction(Description = "AshExpectedRemoval", Category = "GasInput")]
        public static double AshExpectedRemoval(double loading)
        {
            return LakeFunctions.GasInput.AshExpectedRemoval(loading);
        }

        [ExcelFunction(Description = "AshGuaranteedRemoval", Category = "GasInput")]
        public static double AshGuaranteedRemoval(double loading)
        {
            return LakeFunctions.GasInput.AshGuaranteedRemoval(loading);
        }

        [ExcelFunction(Description = "fanOutletTemperature", Category = "GasInput")]
        public static double fanOutletTemperature(double t1, double p1, double p2)
        {
            return LakeFunctions.Oxiair.fanOutletTemperature(t1, p1, p2);
        }


    }
}
