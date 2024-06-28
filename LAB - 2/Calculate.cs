using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
     interface Calculatee
    {
        public double addition(double a , double b);
        public double subtraction(double a, double b);

    }
    internal class Result : Calculatee
    {
        public double addition(double a,double b)
        {
            return a + b;
        }
        public double subtraction(double a, double b)
        {
            return a - b;
        }

       
    }
}
