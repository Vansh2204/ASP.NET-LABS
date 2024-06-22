using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Staff
    {
        public String Name, Department, Designation;
        public Double Experience, Salary;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter Name - ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Department - ");
            Department = Console.ReadLine();
            Console.WriteLine("Enter Designation - ");
            Designation = Console.ReadLine();
            Console.WriteLine("Enter Experience - ");
            Experience = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Salary - ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name - " +Name);
            Console.WriteLine("Salary - " + Salary);
        }





    }
}
