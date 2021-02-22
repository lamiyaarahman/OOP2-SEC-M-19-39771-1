﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem
{
   
        class Savings : Account
        {
            public Savings(string name, string id, int balance)
                : base(name, id, balance)
            {
                Console.WriteLine("Savings account created.");
            }

            new public void withdraw(int withdraw)
            {
                if (withdraw >= 430)
                {
                    if (withdraw <= Balance)
                    {
                        Balance = Balance - withdraw;
                        Console.WriteLine("Withdraw completed.");
                        Console.WriteLine("New Balance: " + Balance);
                    }
                    else
                        Console.WriteLine("Balance is less then" + withdraw);
                }
                else
                    Console.WriteLine("Cannot withdraw!!! Less Than 430!!");
            }
        }
    }

