using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6.Accounts
{
    public abstract class Account
    {
        // тип учетной записи
        public string Type { get; protected set; }

        // баланс учетной записи
        protected double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account(string type, double balance)
        {
            Type = type;
            Balance = balance;
            Interest = 0.00;
        }

        public double GetBalance() => Balance; 

        public abstract  void CalculateInterest();
    }
}
