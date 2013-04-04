using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSChangeManagement
    {
        public int Id;
        public string ChangeId;
        public string ChangeDescription;
        public string AffectedSoftwareItems;
        public int NumberOfTotalChangesMade;
        public string UserIdOfChangeAgent;
        public DateTime DatetimeChangeMade;
        public bool ChangesRolledBack;
        public bool RollbackPossible;
        public DateTime RollbackDatetime;
        public SRSWebCredentials UserIdOfRollbackChangeAgent;
    }
}
