using System;
using System.Linq;

namespace ExcelDNA
{
    public static class ExcelTools
    {
        public static Tuple<string, double>[] getPairs(object[] namecol, object[] messcol)
        {
            var aa =
                    namecol
                    .Select(a =>
                    {
                        try
                        {
                            return Convert.ToString(a);
                        }
                        catch
                        {
                            return "";
                        }
                    });

            var bb =
                    messcol
                    .Select(a =>
                    {
                        try
                        {
                            return Convert.ToDouble(a);
                        }
                        catch
                        {
                            return 0;
                        }
                    });

            return aa
                .Zip(bb, (a, b) => new Tuple<string, double>(a, b))
                .ToArray();
        }
    }
}
