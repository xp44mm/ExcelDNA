using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class FluidFunctions
    {
        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 变截面急转弯头基本阻力系数(double f, double r)
        {
            return LakeFunctions.Fluid.Bend.变截面急转弯头基本阻力系数.Invoke(f).Invoke(r);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 急转弯头基本阻力系数(double r)
        {
            return LakeFunctions.Fluid.Bend.急转弯头基本阻力系数.Invoke(r);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 小圆角弯头形状修正系数(double a)
        {
            return LakeFunctions.Fluid.BendCorrect.smallRoundBendShapeCorrect.Invoke(a);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 圆角弯头角度修正系数(double angle)
        {
            return LakeFunctions.Fluid.BendCorrect.roundBendAngleCorrect.Invoke(angle);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 尖角弯头形状修正系数(double a)
        {
            return LakeFunctions.Fluid.BendCorrect.sharpBendShapeCorrect.Invoke(a);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 尖角弯头角度修正系数(double angle)
        {
            return LakeFunctions.Fluid.BendCorrect.sharpBendAngleCorrect.Invoke(angle);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 变截面尖角弯头基本阻力系数(double b)
        {
            return LakeFunctions.Fluid.Bend.变截面尖角弯头基本阻力系数.Invoke(b);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 虾米弯焊缝条数(double r)
        {
            return LakeFunctions.Fluid.MiterElbow.joint(r);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 虾米弯阻力系数(double r)
        {
            return LakeFunctions.Fluid.MiterElbow.zeta.Invoke(r);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 缩小管阻力系数(double d1, double d2, double a)
        {
            return LakeFunctions.Fluid.Reducer.缩小管阻力系数(d1, d2, a);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double 扩大管阻力系数(double d1, double d2, double a)
        {
            return LakeFunctions.Fluid.Reducer.扩大管阻力系数(d1, d2, a);
        }

        [ExcelFunction(Description = "浆液动力粘度", Category = "Fluid")]
        public static double dynamicViscosity(double sld)
        {
            return LakeFunctions.Fluid.Hydrodynamics.dynamicViscosity.Invoke(sld);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double AirDynamicViscosity(double t, double d)
        {
            return LakeFunctions.Air.dynamicViscosity(t, d);
        }

        [ExcelFunction(Description = "", Category = "Fluid")]
        public static double lambda(double re, double delta)
        {
            return LakeFunctions.Fluid.Hydrodynamics.lambda(re, delta);
        }


    }
}
