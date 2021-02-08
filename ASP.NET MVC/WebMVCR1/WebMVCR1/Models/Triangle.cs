using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1
{
    public class Triangle : Shape
    {
        public double Stb { get; set; }
        public double Stc { get; set; }
        override public string Name
        {
            get { return String.Format("\"Треугольник со сторонами {0}, {1} и {2}\"", St, Stb, Stc); }
        }
        public  Triangle(double a, double b, double c)
        {
            St = a;
            Stb = b;
            Stc = c;
        }
        public double Perimeter
        {
            get
            {
                double p = St + Stb + Stc;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - St) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
                return sq;
            }
        }
    }
}