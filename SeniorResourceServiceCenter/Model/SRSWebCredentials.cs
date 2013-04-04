using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSWebCredentials
    {
        public int Id;
        private string WebMasterLiveActId;
        private string WebMasterLiveActPw;
        private string WebSecurityTypeUsed;
        private string WebHostIpAddress;
        private string WebHostLoginId;
        private string WebHostLoginPw;
        private long WebSRSWebsiteIPAddress;
        private DateTime WebSRSWebsiteLastConnectionDatetime;
        private DateTime WebSRSWebsiteLastDisconnectDatetime;
        private SRSChangeManagement WebSRSWebsiteChangeLogManual; //Collection
        private SRSCredentialsInternalUsers SRSStaffCredentialsCollection; //Collection
    }
}
