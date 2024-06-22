using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class  Salary
    {
        Double TA, DA, HRA, BASIC,Total;
        public Salary()
        {
            DA = 4000;
            HRA = 10000;
            Console.WriteLine("Enter Travelling Allowance - ");
            TA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Basic salary - ");
            BASIC = Convert.ToDouble(Console.ReadLine());
             Total = TA + DA + HRA + BASIC;

        }
        public void displaysalary()
        {
            Console.WriteLine("Your Travelling Allowance is - " + TA);
            Console.WriteLine("Your Dearness Allowance is - " + DA);
            Console.WriteLine("Your House Rent Allowance is - " + HRA);
            Console.WriteLine("Your Basic Salary is - " + BASIC);
            Console.WriteLine("Your Gross Salary is - "+Total);
        }


    }
}
