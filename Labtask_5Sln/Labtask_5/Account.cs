using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_5
 namespace Account
{
    class Account
    {
         string accName;
         string acid;
         int balance;
         int amount;
         int transfer;
        Account acc;


        
            get { return amount; }
        }

        public int Transfer
        {
            set { transfer = value; }
            get { return transfer; }
        }

        public Account Acc
        {
            set { acc = value; }


        public Account(string accName, string acid, int balance)
        {
            Console.WriteLine("Student Created with 3 parameters.");
            Console.WriteLine("Account Created with 3 parameters.");
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;

        {
            if (balance > 0)
            {
                this.balance = balance + amount;
                Console.WriteLine("After Diposite: " + balance);
                balance = balance + amount;
                Console.WriteLine("After Diposite: " +balance);
            }
            else
            {

        {
            if (amount > 0 && amount <= balance)
            {
                this.balance = balance - amount;
                Console.WriteLine("After Withdraw: " + balance);
                balance = balance - amount;
                Console.WriteLine("After Withdraw: " +balance);
            }
            else
            {


        public void Transfer(int amount,Account acc)
        {
            if(amount>0 && amount<=balance)
            if (amount > 0 && amount <= balance)
            {
                this.balance = this.balance - amount;
                acc.balance = acc.balance + amount;


                Console.WriteLine("Transfer amount:" + amount);
                balance = balance - amount;
                Console.WriteLine("After Transfer Balance:" + this.balance);
                balance = balance + amount;
                Console.WriteLine("Recieve amount:" + amount);

            }
            else
                Console.WriteLine("Amount Exceeded");
        }




        public void ShowInfo()
        {
            Console.WriteLine("Account Name is: " + accName);
            Console.WriteLine("ID is: " + acid);
            Console.WriteLine("Balance is: " + balance);
            Console.WriteLine("");
        }
    }
}

    }
}
