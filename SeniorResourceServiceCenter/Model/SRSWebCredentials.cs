using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSWebCredentials
    {
        public int ID { get; set; }
        public  string WebMasterLiveActId { get; set; }
        public  string WebMasterLiveActPw { get; set; }
        public  string WebSecurityTypeUsed { get; set; }
        public  string WebHostIpAddress { get; set; }
        public  string WebHostLoginId { get; set; }
        public  string WebHostLoginPw { get; set; }
        public  long WebSRSWebsiteIPAddress { get; set; }
        public  DateTime WebSRSWebsiteLastConnectionDatetime { get; set; }
        public  DateTime WebSRSWebsiteLastDisconnectDatetime { get; set; }
        public  SRSChangeManagement WebSRSWebsiteChangeLogManual { get; set; } //Collection
        public  SRSCredentialsInternalUsers SRSStaffCredentialsCollection { get; set; } //Collection
    }
}
