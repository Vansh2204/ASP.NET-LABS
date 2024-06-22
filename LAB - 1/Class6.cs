using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Account_Details
    {
        public String name;
        public double balance;
        public int time;
        public int rate;

        public void getdetails()
        {
            Console.WriteLine("Enter name - ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Balance - ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time - ");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest - ");
            rate = Convert.ToInt32(Console.ReadLine());

        }


    }

    public class Interest : Account_Details
    {
        public Interest()
        {
            getdetails();
        }
        public void calculateinterest()
        {
           var Interest = balance * time * rate / 100;
            Console.WriteLine(Interest);
        }

    }
}
