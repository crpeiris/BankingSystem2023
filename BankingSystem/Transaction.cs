using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Transaction
    {
        public DateTime TransactionDate;
        public int AccountNumber;
        public double BeforeBalance;
        public int Amount;
        public double AfterBalance;
        public string Description;

        public Transaction(DateTime _transactionDate, int _accountNumber, double _beforeBalance, int _amount, double _afterBalance, string _description)
        {
            TransactionDate=_transactionDate;
            AccountNumber= _accountNumber;
            BeforeBalance= _beforeBalance;
            Amount= _amount;
            AfterBalance= _afterBalance;
            Description=_description;
        }
    }
}
