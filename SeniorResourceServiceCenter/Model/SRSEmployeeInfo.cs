using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSEmployeeInfo
    {
        private int Id;
        private long EmpSSN;
        private string FirstName;
        private string LastName;
        private string Gender;
        private long SRSDeskPhoneExtension;
        private long CellPhoneNumber;
        private long SecondaryPhoneNumber;
        private DateTime HireDate;
        private string ManagerId;
        private string ManagerFirstName;
        private string ManagerLastName;
        private long AddressHouseOrAptNumber;
        private string AddressStreet;
        private string AddressCity;
        private string AddressState;
        private int AddressZip;
        private DateTime DateOfBirth;
        private SRSClients CurrentlyManagedSeniors; //collection
        private SRSPayroll Payroll;
        private SRSCredentialsInternalUsers SRSCredentialsInternal;

    }
}
