using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice2
{
    public class Savings : Account
    {
        int minimumBalance;
        int overdraft;
        int interest;

        public Savings()
        {
            //constructor
            base.WriteBalance();
        }

        public int AddInterest()
        {
            return interest;
        }
    }
}
