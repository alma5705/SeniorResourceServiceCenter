using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSEmployeeInfo
    {
        public int ID { get; set; }
        public long EmpSSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public long SRSDeskPhoneExtension { get; set; }
        public long CellPhoneNumber { get; set; }
        public long SecondaryPhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public string ManagerID { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public long AddressHouseOrAptNumber { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public int AddressZip { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SRSClients CurrentlyManagedSeniors { get; set; } //collection
        public SRSPayroll Payroll { get; set; }
        public SRSCredentialsInternalUsers SRSCredentialsInternal { get; set; }

    }
}
