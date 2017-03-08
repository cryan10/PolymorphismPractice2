using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice2
{
   public class Account //parent class
    {
        int balance;
       

        public Account()
        {
            //constructor
        }

        public virtual void Withdrawal()
        {
            //withdraw money from bank account
            Console.WriteLine("How much money do you want to withdraw?");
        }

        public int WriteBalance()
        {
            Console.WriteLine("Your current balance is $", balance);
            return balance;

        }
    }
}
