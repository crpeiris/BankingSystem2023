using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Employee : Person 
    {
        public int EmployeeId ;
        public string Department;
        public string Status;
        public int Salary;


        public Employee(string _personID, string _personName, string _contactNumber, int _employeeID, string _department, string _status, int _salary) 
        {
            this.PersonID = _personID;
            this.PersonName= _personName; 
            this.ContactNumber = _contactNumber;
            this.EmployeeId = _employeeID;
            this.Department = _department;
            this.Status = _status;
            this.Salary = _salary;

        }

    }
}
