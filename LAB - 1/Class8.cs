using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Distance
    {
        Double dist1 ,dist2, dist3 ;

        public Distance()
        {
            Console.WriteLine("Enter distance 1 - ");
            dist1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance 2 - ");
            dist2 = Convert.ToDouble(Console.ReadLine());

        }
        public void distance_details()
        {
            dist3 = dist1 + dist2;
            Console.WriteLine("Total Distance is - "+dist3);
        }
    }
}
