using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1
{
    public class Triangle
    {
        public double Sta { get; set; }
        public double Stb { get; set; }
        public double Stc { get; set; }
        public string Name
        {
            get { return String.Format("\"Треугольник со сторонами {0}, {1} и {2}\"", Sta, Stb, Stc); }
        }
        public  Triangle(double a, double b, double c)
        {
            Sta = a;
            Stb = b;
            Stc = c;
        }
        public double Perimeter
        {
            get
            {
                double p = Sta + Stb + Stc;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - Sta) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
                return sq;
            }
        }
    }
}