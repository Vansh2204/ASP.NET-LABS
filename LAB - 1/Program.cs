// See https://aka.ms/new-console-template for more information
using Lab_1;
using System;



 class Program
{
    public static void Main(string[] vansh)
    {

        int prog;

        Console.WriteLine("Enter program number to execute - ");
        prog = Convert.ToInt32(Console.ReadLine());

        switch (prog){

            case 1:
                Candidate c = new Candidate();
                c.GetCandidateDetails();
                c.DisplayCandidateDetails();
                break;

            case 2:
                Staff[] allstaff = new Staff[5];
                int i;

                for(i = 0; i < 5; i++)
                {
                  allstaff[i] = new Staff();
                   allstaff[i].GetEmployeeDetails();

                }
                for(i = 0; i < 5; i++)
                {
                    if(allstaff[i].Designation == "hod")
                    {
                        allstaff[i].DisplayDetails();
                    }

                }
                break;

            case 3:

                Bank_Account ba = new Bank_Account();
                ba.GetAccountDetails();
                ba.DisplayAccountDetails();

                break;

            case 4:

                Student s = new Student();
                s.DisplayStudentDeatils();
                break;

            case 5:
                Rectangle r = new Rectangle();
                r.Get();
                r.display();

                break;

            case 6:
                Interest inter = new Interest();
                inter.calculateinterest();

                break;

            case 7:
                Salary sal = new Salary();
                sal.displaysalary();
                break;

            case 8:
                Distance d = new Distance();
                d.distance_details();

                break;

            case 9:
                Table t = new Table();
                t.getthis();
                t.displall();
                break;

        }

        

 








    }

}