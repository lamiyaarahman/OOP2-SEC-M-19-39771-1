﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSystem
{

    class Special_Current : Account
    {
        public Special_Current(string name, string id, int balance)
            : base(name, id, balance)
        {
            Console.WriteLine("Special current account created.");
        }

        new public void withdraw(int withdraw)
        {
            if (withdraw >= (Balance * 10) / 100)
            {
                if (withdraw <= Balance)
                {
                    Balance = Balance - withdraw;
                    Console.WriteLine("Withdraw done");
                    Console.WriteLine("New Balance " + Balance);
                }
                else
                {
                    Console.WriteLine("Balance is less than " + withdraw);
                }
            }
            else
            {
                Console.WriteLine("Less: " + (Balance * 10) / 100);
            }
        }
    }
}

