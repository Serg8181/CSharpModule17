using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6.Accounts
{
    public class SalaryAccount : Account
    {
        public SalaryAccount(string type, double balance) : base(type, balance) { }

        public override void CalculateInterest()
        {           
           Interest = Balance * 0.5;
        }
    }
}
