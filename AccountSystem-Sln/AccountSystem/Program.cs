using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1=new Account("Lamiya","1111",5000);
            a1.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a1.Transfer(200,a1);
            Console.WriteLine("******************************");
            Account a2 = new Account("Tuli", "2222", 6000);
            a2.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a2.Transfer(200,a1);
            Console.WriteLine("******************************");
            Savings s1 = new Savings("Tonne","3333",2500);
            s1.ShowInfo();
            s1.withdraw(500);
            Console.WriteLine("******************************");
            Special_Current s2 = new Special_Current("Rakib","4444",5500);
            s2.ShowInfo();
            s2.withdraw(3000);
            Console.WriteLine("******************************");
            Fixed f1 = new Fixed("Tamim", "5555", 9000);
            f1.ShowInfo();
            f1.withdraw(3000);
            Console.WriteLine();
            Console.WriteLine("******************************");
            Overdraft o = new Overdraft("Ripa", "6666", 7000);
            o.ShowInfo();
            o.withdraw(200);
            Console.WriteLine();

        }
    }
}

        