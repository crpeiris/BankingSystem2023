using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class SavingAccount : AccountBase
    {

        public SavingAccount(int _acNumber, string _accOwnerID, double _balance, string _status, DateTime _openDate)
        {
            AcNumber=_acNumber;
            AccOwnerId =_accOwnerID;
            Balance=_balance;
            Status=_status;
            OpenDate=_openDate;
          

        } 
        
        
       public void calculateInterest()
        {
            int Interest;
            Double BeforeBalance = Balance;
            Interest = (int)(Balance * .01);
            Balance += Interest;
            String TransDescription = "Interest :" + DateTime.Now.ToString();

            S_LoadData.TranactionsList.Add(new Transaction(DateTime.Now, AcNumber,BeforeBalance, Interest, Balance, TransDescription));
        }

    }
}
