using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSCredentialsInternalUsers
    {
        private int Id;
        private string EmployeeId;
        private string EmployeeFirstName;
        private string EmployeeLoginId;
        private string EmployeeLoginPw;
        private bool EmployeeIsAdmin;
        private bool EmployeeArmPrivilageExternalContacts;
        private bool EmployeeArmPrivilageInternalContacts;
        private bool EmployeeArmPrivilageSRSTasks;
        private bool EmployeeArmPrivilageInherited; //bug, a string in the db model
        private DateTime EmployeeLastLogin;
        private DateTime EmployeeLastLogout;
        private string EmployeeLiveUserId;
        private string EmployeeLiveUserPw;
        private SRSEmployeeInfo SRSEmpInfo;
        private SRSWebCredentials SRSWebCredents;
    }
}
