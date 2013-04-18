using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSChangeManagement
    {
        public int ID { get; set; }
        public string ChangeID { get; set; }
        public string ChangeDescription { get; set; }
        public string AffectedSoftwareItems { get; set; }
        public int NumberOfTotalChangesMade { get; set; }
        public string UserIdOfChangeAgent { get; set; }
        public DateTime DatetimeChangeMade { get; set; }
        public bool ChangesRolledBack { get; set; }
        public bool RollbackPossible { get; set; }
        public DateTime RollbackDatetime { get; set; }
        public SRSWebCredentials UserIDOfRollbackChangeAgent { get; set; } //collection
    }
}
