using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;

namespace ExcelDNA
{
    public static class ExcelFunctions
    {
        //[ExcelFunction(Description = "My first .NET function", Category = "STRING")]
        //public static string SayHello([ExcelArgument(Name = "TEXT", Description = "text to split")] string name)
        //{
        //    return "Hello " + name;
        //}

        [ExcelFunction(Description = "等同于String.Format()", Category = "STRING")]
        public static string format(string frmt, params object[] args)
        {
            //var args1 = args.Select((arg) =>
            //{
            //    return arg.GetType() == typeof(ExcelReference) ? ((ExcelReference)arg).GetValue() : arg;
            //}).ToArray();

            try
            {
                return String.Format(frmt, args);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [ExcelFunction(Description = "", Category = "")]
        public static double grind(double inputpassing, double inputmesh)
        {
            return 95;
        }

        [ExcelFunction(Description = "", Category = "")]
        public static double mesh(double mm)
        {
            return 325;
        }

        [ExcelFunction(Description = "cl calculates cl flow from ppm and free water", Category = "")]
        public static double cl(double ppm, double fw)
        {
            return ppm * fw / 1000000.0;
        }

        [ExcelFunction(Description = "cl calculates ppm flow from cl and free water", Category = "")]
        public static double ppm(double cl, double fw)
        {
            return fw == 0 ? 0 : cl / fw * 1000000.0;
        }

        [ExcelFunction(Description = "", Category = "")]
        public static double area(object a, double b)
        {
            if (a.GetType() == typeof(string))
            {
                return Math.PI / 4.0 * b * b;
            }
            else
            {
                return ((double)a) * b;
            }
        }

        [ExcelFunction(Description = "", Category = "")]
        public static double perimeter(object a, double b)
        {
            if (a.GetType() == typeof(string))
            {
                return Math.PI * b;
            }
            else
            {
                var aa = (double)a;
                return 2 * (aa + b);
            }
        }

        [ExcelFunction(Description = "", Category = "")]
        public static object sjoin(object[] values)
        {
            return String.Join(",", values.Select(x => x == null ? "" : x.ToString()).ToArray());
        }



    }
}
