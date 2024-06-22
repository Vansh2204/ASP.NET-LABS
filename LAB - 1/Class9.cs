using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Furniture
    {
       public String material;
       public Double price;

       public void getinfo()
        {
            Console.WriteLine("Enter material name - ");
            material = Console.ReadLine();
            Console.WriteLine("Enter price - ");
            price = Convert.ToDouble(Console.ReadLine());
        }
    }
    public class Table : Furniture
    {
        Double height, surface_area;

       public void getthis()
        {
            getinfo();

            Console.WriteLine("Enter height - ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter price - ");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void displall()
        {
            Console.WriteLine("Material - "+material);
            Console.WriteLine("Price - "+price);
            Console.WriteLine("Height - " + height);
            Console.WriteLine("Surface area is - "+surface_area);
        }


    }
}
