using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class FixedDeposit
    {
        public int AccountNo;
        public string HolderID;
        public double InterestRate;
        public int Amount;
        public int Duraion;
        public string Status;
        public DateTime OpenDate;
        public DateTime ClosedDate;
        public string IPType;
        public int ITransferAcNumber;

        public FixedDeposit(int _accountNo, string _holderID, double _interestRate, int _amount, int _duration, string _status, DateTime _openDate, DateTime _closedDate, string _iPType, int _iTransferAcNumber)
        {
            AccountNo=_accountNo;
            HolderID=_holderID;
            InterestRate=_interestRate;
            Amount=_amount;
            Duraion=_duration;
            Status=_status;
            OpenDate=_openDate;
            ClosedDate=_closedDate;
            IPType=_iPType;
            ITransferAcNumber=_iTransferAcNumber;
        }
    }
}
