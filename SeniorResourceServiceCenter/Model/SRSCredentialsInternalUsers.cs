using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSCredentialsInternalUsers
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLoginID { get; set; }
        public string EmployeeLoginPw { get; set; }
        public bool EmployeeIsAdmin { get; set; }
        public bool EmployeeArmPrivilageExternalContacts { get; set; }
        public bool EmployeeArmPrivilageInternalContacts { get; set; }
        public bool EmployeeArmPrivilageSRSTasks { get; set; }
        public bool EmployeeArmPrivilageInherited { get; set; } //bug, a string in the db model
        public DateTime EmployeeLastLogin { get; set; }
        public DateTime EmployeeLastLogout { get; set; }
        public string EmployeeLiveUserID { get; set; }
        public string EmployeeLiveUserPw { get; set; }
        public SRSEmployeeInfo SRSEmpInfo { get; set; } //collection
        public SRSWebCredentials SRSWebCredents { get; set; } //collection
    }
}
