using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Candidate
    {
        int ID,Age;
        String Name;
        Double Weight, Height;

       public void GetCandidateDetails()
        {
            Console.WriteLine("Enter ID - ");
            this.ID= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age - ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name - ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Weight - ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height - ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

       public void DisplayCandidateDetails()
        {
            Console.WriteLine("Name - "+Name);
            Console.WriteLine("Age - " + Age);
            Console.WriteLine("Height - " + Height);
            Console.WriteLine("Weight - " + Weight);

        }

    }
}
