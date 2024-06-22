using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Rectangle
    {
        Double length, breath;

        public void Get()
        {
            Console.WriteLine("Enter length ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breath ");
            breath = Convert.ToDouble(Console.ReadLine());

        }
       public void display()
        {
            Console.WriteLine("Area is - "+length * breath);

        }
    }
}
