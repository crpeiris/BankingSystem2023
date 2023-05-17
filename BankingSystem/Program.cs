using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        public Transaction AbcTranaction;
        static void Main(string[] args)
        {
                       
            S_LoadData.LoadAllData();
            int NewAccountNumber =0;
            string userSelection;
           


        MainMenu:
            do
            {
                Console.WriteLine("");
                Console.WriteLine("========================Welcome to the ABC BAnking System======================");

                Console.WriteLine("MAIN MENU");
                Console.WriteLine("View All info                        : <V>");
                Console.WriteLine("Create Saving or Current  Account    : <A>");
                Console.WriteLine("Create Fixed Deposit                 : <F>");
                Console.WriteLine("Create Account Holder                : <H>");
                Console.WriteLine("Clear Screen                         : <clear>");
                Console.WriteLine("END Program                          : <X>");
                Console.WriteLine("Depost or Withdraw Transaction       : <T>");
                Console.WriteLine("Show Transactions                    : <ST>");
                Console.WriteLine("Calculate Interest                   : <SavInt>");



                Console.WriteLine("================================================================================");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("Enter a valid choce : ");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "V":
                        S_LoadData.ShowAllData();
                        break;
                    case "H":
                        createAcHolder();
                        break;
                    case "A":
                        NewAccountNumber = createNewAccount();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "T":
                        MakeTransaction();
                        break;
                    case "ST":
                        S_LoadData.showTransactions();
                        break;
                    case "SavInt":
                        S_LoadData.CalculateSavingInterest();
                        break;
                    default:
                        Console.WriteLine("Worng selection \n");
                        break;
                }
            } while (userSelection != "X");
            


            string createAcHolder()
            {
                Console.WriteLine("Enter Acccount Holder ID");
                string _PID = Console.ReadLine();
                Console.WriteLine("Enter Acccount Holder Name");
                string _FullName = Console.ReadLine();
                Console.WriteLine("Enter Acccount Holder Contact No");
                string _ContactNo = Console.ReadLine();
                Console.WriteLine("Enter Acccount Holder Job Title");
                string _JobTitle = Console.ReadLine();
                Console.WriteLine("Enter Acccount Holder Income");
                int _Income = int.Parse(Console.ReadLine());

                 return S_LoadData.createAccountHolder(_PID, _FullName, _ContactNo, _JobTitle, _Income);
            }


            int createNewAccount()
            {
                string AcHolderRegistred ;
                string TypeofAccount;
                string _PersonID;

                Console.WriteLine("What is type of the Account? Enter <S> for Savind or <C> for Current");
                TypeofAccount = Console.ReadLine();



                Console.WriteLine("Is the Account holder Already registered? Enter Y or N ");
                AcHolderRegistred = Console.ReadLine();
                if (AcHolderRegistred=="N")
                    {
                    _PersonID = createAcHolder();
                    Console.WriteLine("====A New Account Holder created and the New Holder No is : "+ _PersonID+"====");
                    Console.WriteLine("");
                        
                    }
                else
                    {
                    Console.WriteLine("Enter Acccount Holder personID for the new Account Holder");
                    _PersonID = Console.ReadLine();
                }
                Console.WriteLine("Enter Acccount Number ID");
                int _AcNo = int.Parse(Console.ReadLine());
                double _Balance= 0;
                string _Status = "Open";
                DateTime _OpenDate = new DateTime();

                if ( TypeofAccount == "S")
                {
                    NewAccountNumber = S_LoadData.createSavingAccount(_AcNo, _PersonID, _Balance, _Status, _OpenDate);
                    Console.WriteLine("A New Saving Account created and the New Account No is :" + NewAccountNumber);
                }
                else if (TypeofAccount== "C")
                {
                    NewAccountNumber = S_LoadData.CreateCurrentAccount(_AcNo, _PersonID, _Balance, _Status, _OpenDate);
                    Console.WriteLine("A New Current Account created and the New Account No is :" + NewAccountNumber);
                }
                else
                {
                    Console.WriteLine("Enter <S> for Saving Account or <C> for Current");
                    Console.WriteLine("Invalid letter, Account not created, Please try again with correct selection");
                }

                return NewAccountNumber;
            }

            void SavingTransaction()
            {
                StartTransaction:
                int AcNumberForTransaction;
                SavingAccount AccountObj;
                int Amount;

                Console.WriteLine("Enter Account Number ");
                AcNumberForTransaction = int.Parse(Console.ReadLine());

                AccountObj = (S_LoadData.SavingAcList.Find(i => i.AcNumber == AcNumberForTransaction));
                Console.WriteLine("The Account Number:= "+ AccountObj.AcNumber + "  Owner PID : = " + AccountObj.AccOwnerId + "  the current Balance is :=" + AccountObj.Balance);
                Console.WriteLine("If Accounts Correct, press <Y>to Continue, Press <M> for Main Menu ");
               
                if (Console.ReadLine()=="M")
                { 
                    goto StartTransaction; 
                }

                Console.WriteLine("Enter Tranaction Amount (-Amount for Withdrawel) ");
                Amount = int.Parse(Console.ReadLine()); 
                AccountObj.Balance = AccountObj.Balance + Amount ;

                Console.WriteLine("The transaction Succeded , Details are as follows");
                Console.WriteLine("The Account Number:= "+ AccountObj.AcNumber + "  Owner PID : = " + AccountObj.AccOwnerId + "  the current Balance is :=" + AccountObj.Balance);


            }

            void MakeTransaction()
            {
            StartTransaction:
                int intAcNumberTransaction;
                string strAcNumberTransaction;

                dynamic AccountObj = 0;
                string acType;
                int Amount;
                double beforeBalance;


                Console.WriteLine("Enter Account Number ");
                intAcNumberTransaction = int.Parse(Console.ReadLine());
                acType =(intAcNumberTransaction.ToString()).Substring(0,1);

                Console.WriteLine(" actype ="+ acType); 


                if (acType=="1")
                {
                    AccountObj = (S_LoadData.SavingAcList.Find(i => i.AcNumber == intAcNumberTransaction));
                }
                else if (acType=="2")
                {
                    AccountObj = (S_LoadData.CurrentAcList.Find(i => i.AcNumber == intAcNumberTransaction));
                }
                else
                {
                    Console.WriteLine("Account Number incorrect, please check and try agaian");
                }

                Console.WriteLine("The Account Number:= "+ AccountObj.AcNumber + "  Owner PID : = " + AccountObj.AccOwnerId + "  the current Balance is :=" + AccountObj.Balance);
                Console.WriteLine("If Accounts Correct, press <Y>to Continue, Press <M> for Main Menu ");

                if (Console.ReadLine()=="M")
                {
                    goto StartTransaction;
                }



                ReEnterAmount:

                beforeBalance = AccountObj.Balance;
                Console.WriteLine("Enter Tranaction Amount (-Amount for Withdrawel) ");
                Amount = int.Parse(Console.ReadLine());
                AccountObj.Balance = AccountObj.Balance + Amount;
                string Description; 


                if (Amount > 0) 
                    {Description = "Deposit";}
                else if (Amount < 0) 
                    { Description = "Withdrawal"; }
                else 
                    {   Console.WriteLine("Reenter correct amount ");
                    goto ReEnterAmount;
                    }
                
                S_LoadData.TranactionsList.Add(new Transaction(DateTime.Now, AccountObj.AcNumber, beforeBalance, Amount, AccountObj.Balance, Description));
                Console.WriteLine("The transaction Succeded , Details are as follows");
                Console.WriteLine("The Account Number: "+ AccountObj.AcNumber + "  Owner PID : " + AccountObj.AccOwnerId + " Balance before : " + beforeBalance + " The amount : " + Amount + " The updated Balance :" + AccountObj.Balance + " Description :" + Description );

            }


           



            Console.ReadKey();
                  
        }
    }
}
