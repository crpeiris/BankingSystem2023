using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class CurrentAccount : AccountBase
    {
        public CurrentAccount(int _acNumber, string _accOwnerID, double _balance, string _status, DateTime _openDate)
        {
            AcNumber=_acNumber;
            AccOwnerId =_accOwnerID;
            Balance=_balance;
            Status=_status;
            OpenDate=_openDate;
        }
    }
}
