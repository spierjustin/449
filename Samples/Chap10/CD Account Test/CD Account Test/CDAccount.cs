using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Account_Test
{
    class CDAccount : SavingsAccount
    {
        //Field
        private string _maturityDate;

        //constructor
        public CDAccount()
        {
            _maturityDate = "";

        }

        //MaturityDate property
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
