using ExcelDna.Integration;
using LakeFunctions.Sections;

namespace ExcelDNA
{
    public static class Staad
    {
        [ExcelFunction(Description = "钢材许用应力", Category = "Staad")]
        public static double allowableStress(string material, double temp)
        {
            return LakeFunctions.Steel.allowableStress(material).Invoke(temp);
        }

        [ExcelFunction(Description = "钢材弹性模量", Category = "Staad")]
        public static double elasticModulus(string material, double temp)
        {
            return LakeFunctions.Steel.elasticModulus(material).Invoke(temp);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double 风压高度变化系数(string tp, double height)
        {
            return LakeFunctions.Staad.风压高度变化系数(tp, height);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double buckling(double slender)
        {
            return LakeFunctions.Staad.buckling.Invoke(slender);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double PipeArea(double dw, double t)
        {
            var pipe = new Pipe(dw, t);
            return pipe.Area;
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double PipeI(double dw, double t)
        {
            var pipe = new Pipe(dw, t);
            return pipe.IM;
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelWeight(string spec)
        {
            return ShapeSteel.weight(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelArea(string spec)
        {
            return ShapeSteel.area(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelIMx(string spec)
        {
            return ShapeSteel.IMx(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelWx(string spec)
        {
            return ShapeSteel.Wx(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelIMy(string spec)
        {
            return ShapeSteel.IMy(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelWy(string spec)
        {
            return ShapeSteel.Wy(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelZ0(string spec)
        {
            return ShapeSteel.Z0(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ShapeSteelB(string spec)
        {
            return ShapeSteel.B(spec);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double CombSectionArea(string spec, double t)
        {
            var sect = new CombSection(spec, t);
            return sect.area;
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double CombSectionWeight(string spec, double t)
        {
            var sect = new CombSection(spec, t);
            return sect.weight;
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double CombSectionIx(string spec, double t)
        {
            var sect = new CombSection(spec, t);
            return sect.ix;
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double CombSectionZmin(string spec, double t)
        {
            var sect = new CombSection(spec, t);
            return sect.zmin;
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double PlateFreq(double t, double ela, double span)
        {
            return LakeFunctions.Ribs.Checker.Plate.freq(t, ela, span);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double PlateStress(double t, double span, double q)
        {
            return LakeFunctions.Ribs.Checker.Plate.stress(t, span, q);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double PlateDeflection(double t, double ela, double span, double q)
        {
            return LakeFunctions.Ribs.Checker.Plate.deflection(t, ela, span, q);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double RibFreq(string spec, double t, double len, double ela)
        {
            var sect = new CombSection(spec, t);
            return LakeFunctions.Ribs.Checker.Pinned.freq(len, ela, sect.ix, sect.weight);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double RibStress(string spec, double t, double len, double q)
        {
            var sect = new CombSection(spec, t);
            return LakeFunctions.Ribs.Checker.Pinned.stress(len, sect.zmin, q);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double RibDeflection(string spec, double t, double len, double ela, double q)
        {
            var sect = new CombSection(spec, t);
            return LakeFunctions.Ribs.Checker.Pinned.deflection(len, ela, sect.ix, q);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double RibBeta(double self, double neighbor)
        {
            return LakeFunctions.Ribs.Loads.ribBeta(self, neighbor);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double insulaThick(double temp)
        {
            return LakeFunctions.Ribs.Loads.insulaThick(temp);
        }

        [ExcelFunction(Description = "", Category = "Staad")]
        public static double ribStable(string spec, double len, double xigma)
        {
            return LakeFunctions.Ribs.Stable.ribStable(spec, len, xigma);
        }

    }
}
