using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CD_Account_Test
{
    class SavingsAccount
    {
        // Fields
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;

        //constructor
        public SavingsAccount()
        {
            _accountNumber = "";
            _interestRate = 0;
            _balance = 0;

        }

        //AccountNumber Property
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        //interestRate property
        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }
        //balance property
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
