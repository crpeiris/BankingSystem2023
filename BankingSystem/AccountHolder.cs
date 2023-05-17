using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class AccountHolder : Person
    {
        public string AHJobTitle;
        public int AHIncome;
        

        public AccountHolder(string _personID, string _personName, string _contactNumber, string _aHJobTitle, int _aHIncome)
        {
            this.PersonID = _personID;
            this.PersonName= _personName;
            this.ContactNumber = _contactNumber;
            this.AHJobTitle = _aHJobTitle;
            this.AHIncome = _aHIncome;  
            
        }
    }
}
