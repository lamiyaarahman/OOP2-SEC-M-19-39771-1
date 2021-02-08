using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask3_P8
{
    class Program
    {
        static void Main(string[] args)
        {
          double phy, chem, bio, math, com;

            Console.Write("Enter Physics Marks: ");
            phy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Chemistry Marks: ");
            chem = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Biology Marks: ");
            bio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Mathematics Marks: ");
            math = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Computer Marks: ");
            com = Convert.ToDouble(Console.ReadLine());

            double Marks = (phy + chem + bio + math + com) / 5;
            string grade = "";

            if (Marks >= 90)
                grade = "A+";
            else if (Marks < 90 && Marks >= 85)
                grade = "A";
            else if (Marks < 85 && Marks >= 80)
                grade = "B+";
            else if (Marks < 80 && Marks >= 75)
                grade = "B";
            else if (Marks < 75 && Marks >= 50)
                grade = "C+";
            else
                grade = "F";

            Console.WriteLine("\nThe Grade is: " + grade);


            Console.ReadLine();
        }
    }
}
        
    

