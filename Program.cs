using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 56; //literals
            const int credit = 148;
            a = 45;

            int n = 48;//declaration
            Console.WriteLine("n is: " + n);

            Student s1 = new Student("LAMIYA", "10-39771-1");

            s1.name = "LAMIYA";
            s1.Id = "19-39771-1";
            Console.WriteLine("Name:" + s1.Name);
            Console.WriteLine("Id:" + s1.Id);

            s1.ShowInfo();

        }
    }
}
