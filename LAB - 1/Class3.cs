using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Bank_Account
    {
        int Account_No;
        String Email,User_Name,Account_Type;
        Double Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account_No - ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email - ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter User_Name - ");
            User_Name = Console.ReadLine();
            Console.WriteLine("Enter Account_Type - ");
            Account_Type = Console.ReadLine();
            Console.WriteLine("Enter Account_Balance - ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account_No - " + Account_No);            
            Console.WriteLine("Email - " + Email);
            Console.WriteLine("User_Name - " + User_Name);
            Console.WriteLine("Account_Type - " + Account_Type);
            Console.WriteLine("Account_Balance - " + Account_Balance);


        }

    }
}
