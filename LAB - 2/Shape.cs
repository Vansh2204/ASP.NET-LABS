using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal interface Shape
    {
        public double Circle(double r);
        public double Triangle(double ba,double height);
        public double Square(double l ,double b);

    }
    class Area : Shape
    {
        public double Circle(double r)
        {
            return 3.14 * r * r;
        }
        public double Triangle(double ba,double height)
        {
            return 1.5 * ba * height;
        }
        public double Square(double l,double b)
        {
            return l * b;
        }
    }
}
