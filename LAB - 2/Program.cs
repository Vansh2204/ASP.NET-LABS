// See https://aka.ms/new-console-template for more information

using Lab_2;
class Program
{
    public static void Main(string[] args)
    {

        // 1.
        //try
        //{
        //    int a, b, c;
        //    Console.WriteLine("Enter number one - ");
        //    a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter number two - ");
        //    b = Convert.ToInt32(Console.ReadLine());
        //    c = a / b;
        //    Console.WriteLine(c);

        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.ToString());
        //}


        // 2.
        //Console.WriteLine(" Enter size of array - ");
        //int size = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter position - ");
        //int pos = Convert.ToInt32(Console.ReadLine());

        //int[] arr = new int[size];

        //try
        //{
        //    Console.WriteLine("Enter element - ");
        //    arr[pos] = Convert.ToInt32(Console.ReadLine());

        //}catch (Exception e)
        //{
        //    Console.WriteLine(e);

        //}

        // 3.
        Calculate c = new Calculate();
        int ans = c.SumOfTwo(2, 3);
        Console.WriteLine("Sum of two numbers is - " + ans);
        int ans2 = c.SumOfThree(10, 10, 10);
        Console.WriteLine("Sum of three numbers is - " + ans2);

        // 4.
        //Result r = new Result();
        //double ans = r.addition(20, 20);
        //Console.WriteLine("Addition - "+ans);
        //double ans2 = r.subtraction(20, 10);
        //Console.WriteLine("Subtraction - "+ans2);

        // 5.
        //string name = "Darshan";
        //string name1 = "University";
        //int len = name.Length;
        //Console.WriteLine("Length - "+len);
        //Console.WriteLine();
        //string up = name.ToUpper();
        //Console.WriteLine("Uppercase - "+up);
        //Console.WriteLine();
        //string joinedstring = string.Concat(name, name1);
        //Console.WriteLine(joinedstring);
        //Console.WriteLine();
        //Boolean result = name.Equals(name1);
        //Console.WriteLine(result);
        //Console.WriteLine();
        //string str = "\'String\' class";
        //Console.WriteLine(str);
        //Console.WriteLine();
        //string lo = name.ToLower();
        //Console.WriteLine("Lowercase - "+lo);
        //Console.WriteLine();
        //int compare = String.Compare(name,name1);
        //Console.WriteLine("Compare - "+compare);
        //Console.WriteLine();
        //string subs = name1.Substring(0,3);
        //Console.WriteLine("Substring - "+subs);
        //string subs1 = name.Substring(2,5);
        //Console.WriteLine("Substring - "+subs1);
        //Console.WriteLine();
        //bool checkvalue = name.Contains("abc");
        //Console.WriteLine("Does it contain abc ? "+checkvalue);
        //Console.WriteLine();
        //string ins = str.Insert(0, "abc");
        //Console.WriteLine("Insert - "+ins);
        //Console.WriteLine();
        //Console.WriteLine(str.Remove(7));
        //Console.WriteLine(str.Replace('s', 'b'));
        //Console.WriteLine("Clone - "+str.Clone());
        //Console.WriteLine(str.EndsWith('s'));
        //Console.WriteLine(str.StartsWith('s'));
        //Console.WriteLine(str.Trim());

        // 6.
        //String name = "Vansh";
        //String name2 = "Hathi";
        //Console.WriteLine(name.ToUpper());
        //Console.WriteLine(name.ToLower());

        // 7.
        //Area area = new Area();
        //Console.WriteLine("Area of circle - "+area.Circle(5));
        //Console.WriteLine("Area of triangle - " + area.Triangle(5,5));
        //Console.WriteLine("Area of square - " + area.Square(5,5));

        // 8.
        //try
        //{
        //    Console.WriteLine("Enter a number - ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    if(num % 2 == 1)
        //    {
        //        throw new Exception("Number is not even !!!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Number - "+num);
        //    }
        //}catch(Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}

        // 9.
        //Console.WriteLine("Enter string - ");
        //string value = Console.ReadLine();

        //string[] demo = value.Split();

        //int maxi = demo[0].Length;
        //string maxstring = "";

        //foreach(var i in demo)
        //    if(maxi < i.Length)
        //    {
        //        maxstring = i;
        //        Console.WriteLine(maxstring);

        //    }
        //    else
        //    {
        //        maxstring = demo[0];
        //    }


        // 10.
        //Console.WriteLine("Enter character - ");
        //string i = Console.ReadLine().ToUpper();
        //Console.WriteLine(i);





    }
}