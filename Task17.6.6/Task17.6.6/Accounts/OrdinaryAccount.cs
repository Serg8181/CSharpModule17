using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6.Accounts
{
    public class OrdinaryAccount : Account
    {
        public OrdinaryAccount(string type, double balance) : base(type, balance) { }
      
        public override void CalculateInterest()
        {
           Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Interest * 0.2;
            else 
                Interest -= Interest * 0.4;           
        }
    }
}
