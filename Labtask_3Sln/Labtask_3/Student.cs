using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_3
{
   public class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

       


        //properties 


        public string Name
        {
            set { this.name = value; }
            get { return this.name; }

        }
        public string Id
        {
            set { this.id = value;}
            get { return this.id; }
        }
        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            get { return this.cgpa;}
        }
            public Student()
            {
                Console.WriteLine("Student Created with default");
                
            }
        public Student(string name, string id, string department, float cgpa) //constructor with 3 parameter
        {
            Console.WriteLine("Constructor with 3 parameter...");
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo() //ShowInfo Method
        {
            Console.WriteLine("Name is: "+name);
            Console.WriteLine("Id is: "+id);
            Console.WriteLine("Deparment is: "+department);
            Console.WriteLine("Cgpa is: "+cgpa);
        }
       
            }
        }
    

