using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labtask_5



namespace Labtask_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        

            Account a1=new Account("Lamiya","39771",3000);
            a1.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a1.Transfer(200,a1);
            Console.WriteLine("******************************");
            Account a2 = new Account("Rakib", "45678", 7000);
            a2.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a2.Transfer(200,a1);
            Console.WriteLine("******************************");
            savings s1 = new savings("Rima","45678",3400);
            s1.ShowInfo();
            s1.withdraw(500);
            Console.WriteLine("******************************");
            Special_current s2 = new Special_current("Shuvo","98765",15500);
            s2.ShowInfo();
            s2.withdraw(3000);
            Console.WriteLine("******************************");
            Fixed f1 = new Fixed("Ripa", "45678", 5000);
            f1.ShowInfo();
            f1.withdraw(3000);
            Console.WriteLine();
            Console.WriteLine("******************************");
            Overdraft o = new Overdraft("Tuli", "56789", 7000);
            o.ShowInfo();
            o.withdraw(200);
            Console.WriteLine();

        }
    }
        }
    

