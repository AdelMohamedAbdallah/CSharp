
using BenchmarkDotNet.Attributes;
using System.Diagnostics;

namespace C__Course.Attributes
{

    [DebuggerDisplay("Area : {area1}")]

    public class Area
    {

        //public Area(double x, double y)
        //{
        //    this.x = x;
        //    this.y = y;

        //}

        private double area { get; set; }
        //private double x { get; set; }
        //private double y { get; set; }


        [Obsolete("This Method can't use.... ", false)]
        [Benchmark]
        public double GetArea(double x, double y)
        {
            return area = x * y;
        }

        [Benchmark]
        public double Getareaplus(double x, double y) => area = (x * y) + 5;
        //public override string ToString()
        //{
        //    return $"{Getareaplus()}";
        //}
    }
}
