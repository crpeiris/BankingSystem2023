using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal static class S_LoadData
    {

        // Account Holder Section
        public static List<AccountHolder> AcHolderList= new List<AccountHolder>();
        
        public static string createAccountHolder(string _personID, string _personName, string _contactNumber, string _aHJobTitle, int _aHIncome)
        {
            AcHolderList.Add(new AccountHolder(_personID,  _personName,  _contactNumber,  _aHJobTitle,  _aHIncome));
            ShowAccountHolders();
            return _personID;
        }

        public static void loadDataAccountHolders()
           
        {
            {
                AcHolderList.Add(new AccountHolder("1", "Sameera Perera", "555625", "Teacher", 85000));
                AcHolderList.Add(new AccountHolder("2", "Kumara Peiris", "125700", "Business", 95000));
                AcHolderList.Add(new AccountHolder("3", "Mohamad Safraz", "200365", "Business", 145000));
                AcHolderList.Add(new AccountHolder("4", "Geetha Shanthi", "485658", "Lawyer", 55000));
                AcHolderList.Add(new AccountHolder("5", "Namal Herath", "500366", "Teacher", 120000));
            }
        }

        public static void ShowAccountHolders()
        {
            Console.WriteLine("========================Account Holder Data ===========================");
            Console.WriteLine("AcHPid	AcHName\t\t	AcHContact\t JobTitle\t Income");
            Console.WriteLine("=======================================================================");
            foreach (AccountHolder AcHolder in AcHolderList)
                {
                Console.WriteLine( AcHolder.PersonID + "\t"+ AcHolder.PersonName + "\t\t"+  AcHolder.ContactNumber + "\t\t"+ AcHolder.AHJobTitle + "\t\t"+ AcHolder.AHIncome);

            }
            Console.WriteLine("=======================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
        }



        //Employee Section


        public static List<Employee> EmployeeList = new List<Employee>();

        public static void loadDataEmployees()
        {
            {
                EmployeeList.Add(new Employee("101", "Chamara Kuma", "71427735", 101, "Loan", "Manager", 125000));
                EmployeeList.Add(new Employee("102", "Nimal Silva", "45658285", 102, "Counter", "Officer", 80000));
                EmployeeList.Add(new Employee("103", "Raj Kumar", "59888835", 103, "Loan", "Assistant", 65000));
                EmployeeList.Add(new Employee("104", "Malki Gamage", "74119385", 104, "Counter", "Officer", 90000));
                EmployeeList.Add(new Employee("105", "Mohamad Niyaz", "88349935", 105, "Pawning", "Clerk", 80000));

            }
        }

        public static void ShowEmployees()
        {
            Console.WriteLine("============================Employee List Data ==================================");
            Console.WriteLine( "PID \tPersonName \tContactNo \tEmpId \tDept \tStatus \t\tSalary");
            Console.WriteLine("=================================================================================");
            foreach (Employee _emp in EmployeeList)
            {
                Console.WriteLine(_emp.PersonID + "\t"+ _emp.PersonName + "\t" + _emp.ContactNumber +"\t" + _emp.EmployeeId + "\t" + _emp.Department + "\t" + _emp.Status + "\t\t" + _emp.Salary);
            }
            Console.WriteLine("================================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        

        // Savings Account Section

        public static List<SavingAccount> SavingAcList = new List<SavingAccount>();


        public static int createSavingAccount(int _acNumber, string _accOwnerID, double _balance, string _status, DateTime _openDate)
        {
            SavingAcList.Add(new SavingAccount( _acNumber,  _accOwnerID,  _balance,  _status,  _openDate));
            ShowSavingsAcList();
            return _acNumber;
        }





        public static void loadDataSavingdAc()

        {
            {
                SavingAcList.Add(new SavingAccount(1001, "1", 200000, "Open", new DateTime(2014, 11, 12)));
                SavingAcList.Add(new SavingAccount(1002, "2", 15000, "Open", new DateTime(2010, 2, 2)));
                SavingAcList.Add(new SavingAccount(1003, "3", 25000, "Open", new DateTime(2022, 8, 2)));
                SavingAcList.Add(new SavingAccount(1004, "4", 12000, "Closed", new DateTime(2009, 12, 3)));
                SavingAcList.Add(new SavingAccount(1005, "5", 175000, "Open", new DateTime(2016, 10, 9)));



            }
        }

        public static void ShowSavingsAcList()
        {
            Console.WriteLine("=======================Saving Account List Data ========================");
            Console.WriteLine("Ac No \tAcHPID \tBalance Status \tOpen date");
            Console.WriteLine("=======================================================================");
            foreach (SavingAccount _saveAC in SavingAcList)
            {
                Console.WriteLine(_saveAC.AcNumber + "\t"+ _saveAC.AccOwnerId + "\t" + _saveAC.Balance + "\t" + _saveAC.Status + "\t" + _saveAC.OpenDate);
            }
            Console.WriteLine("=======================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
        }




        // Current Account Section

        public static List<CurrentAccount> CurrentAcList = new List<CurrentAccount>();

        public static void loadDataCurrentAc()

        {
            {
                CurrentAcList.Add(new CurrentAccount(2001, "1", 100000, "Open", new DateTime(2014, 5, 14)));
                CurrentAcList.Add(new CurrentAccount(2002, "1", 100000, "Open", new DateTime(2014, 5, 14)));
                CurrentAcList.Add(new CurrentAccount(2003, "2", 75000, "Open", new DateTime(2020, 1, 1)));
                CurrentAcList.Add(new CurrentAccount(2004, "3", 125000, "Open", new DateTime(2019, 9, 19)));
                CurrentAcList.Add(new CurrentAccount(2005, "4", 50000, "Closed", new DateTime(2005, 7, 5)));



            }
        }

        public static void ShowCurrentAcList()
        {
            Console.WriteLine("=======================Current Account List Data ========================");
            Console.WriteLine("Ac No \tAch PID \tBalance Status \tOpen date");
            Console.WriteLine("=======================================================================");
            foreach (CurrentAccount _currentAC in CurrentAcList)
            {
                Console.WriteLine(_currentAC.AcNumber + "\t"+ _currentAC.AccOwnerId + "\t" + _currentAC.Balance + "\t" + _currentAC.Status + "\t" + _currentAC.OpenDate);
            }
            Console.WriteLine("=======================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
        }



        public static int CreateCurrentAccount(int _acNumber, string _accOwnerID, double _balance, string _status, DateTime _openDate)
        {
           CurrentAcList.Add(new CurrentAccount(_acNumber, _accOwnerID, _balance, _status, _openDate));
            ShowSavingsAcList();
            return _acNumber;
        }




        // Fixed Deposit  Section

        public static List<FixedDeposit> FixedDeposits = new List<FixedDeposit>();

        public static void loadDataFixedDeposit()

        {
            {
                FixedDeposits.Add(new FixedDeposit(3001, "2", 0.1, 20000, 360, "Open", new DateTime(2022, 10, 20), new DateTime(2023, 10, 15), "End of P", 1000001));
                FixedDeposits.Add(new FixedDeposit(3002, "3", 0.15, 150000, 360, "Open", new DateTime(2023, 5, 1), new DateTime(2019, 2, 1), "End of P", 1000002));
                FixedDeposits.Add(new FixedDeposit(3003, "4", 0.15, 75000, 180, "Open", new DateTime(2019, 3, 3), new DateTime(2020, 3, 3), "End of P", 1000005));
                FixedDeposits.Add(new FixedDeposit(3004, "3", 0.2, 1000000, 30, "Closed", new DateTime(2021, 1, 20), new DateTime(2021, 12, 21), "End of M", 1000001));
                FixedDeposits.Add(new FixedDeposit(3005, "5", 0.07, 245000, 360, "Open", new DateTime(2022, 8, 10), new DateTime(2015, 10, 10), "End of M", 1000002));


            }
        }

        public static void ShowFixedDepositList()
        {
            Console.WriteLine("=========================================================Fixed Deposit List =====================================================");
            Console.WriteLine("AccNo \t ACh PID\t IntRate Amount Duration Status OpenDate\t\t ClosedDate\t\t IPType \tIPayAc");
            Console.WriteLine("=================================================================================================================================");
            foreach (FixedDeposit _fixedDeposit in FixedDeposits)
            {
                Console.WriteLine(_fixedDeposit.AccountNo + "\t\t" + _fixedDeposit.HolderID + "\t" + _fixedDeposit.InterestRate  + "\t"  + _fixedDeposit.Amount  + "\t" + _fixedDeposit.Duraion + "\t" + _fixedDeposit.Status  + "\t" + _fixedDeposit.OpenDate + "\t" + _fixedDeposit.ClosedDate + "\t" + _fixedDeposit.IPType + "\t" + _fixedDeposit.ITransferAcNumber);
            }
            Console.WriteLine("==================================================================================================================================");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static  List<Transaction> TranactionsList = new List<Transaction>();

        public static void showTransactions()
        {
            Console.WriteLine("======================Transactions Log Data =========================================");
            Console.WriteLine("TransactionDate  \tAc No \tBalance \tAmount \tAfterBalance \tDescription");

            foreach (Transaction AbcTranObj in S_LoadData.TranactionsList)
            {
                Console.WriteLine( AbcTranObj.TransactionDate + "\t"  + AbcTranObj.AccountNumber +"\t" + AbcTranObj.BeforeBalance +"\t\t" +AbcTranObj.Amount +"\t" + AbcTranObj.AfterBalance +"\t\t" + AbcTranObj.Description) ;
            }
           
            Console.WriteLine("=====================================================================================");

        }


        public static void CalculateSavingInterest()
        {
            Console.WriteLine("======================Saving Account Interest Calculation Result=========================================");
           
            foreach (SavingAccount SavingAcObj in S_LoadData.SavingAcList)
            {
               SavingAcObj.calculateInterest(); 
            }
            Console.WriteLine("=======================Total Interest Paid for Saving Accounts Success============================");

        }








        public static void LoadAllData()
        {
            loadDataAccountHolders();
            loadDataEmployees();
            loadDataSavingdAc();
            loadDataCurrentAc();
            loadDataFixedDeposit();
        }

        public static void ShowAllData()
        {
            ShowAccountHolders();
            ShowEmployees();
            ShowSavingsAcList();
            ShowCurrentAcList();
            ShowFixedDepositList();
        }

    }
}
