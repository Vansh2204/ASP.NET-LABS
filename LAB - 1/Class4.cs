using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Student
    {
        int Enrollment_No, Semester;
        String Student_Name;
        Double CPI, SPI;

        public Student()
        {
            Console.WriteLine("Enter Enrollment - ");
            Enrollment_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name - ");
            Student_Name = Console.ReadLine();
            Console.WriteLine("Enter Sem - ");
            Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter CPI - ");
            CPI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter SPI - ");
            SPI = Convert.ToDouble(Console.ReadLine());

        }

       public void DisplayStudentDeatils()
        {
            Console.WriteLine(Enrollment_No);
            Console.WriteLine(Student_Name);
            Console.WriteLine(Semester);
            Console.WriteLine(CPI);
            Console.WriteLine(SPI);


        }
    }
}
