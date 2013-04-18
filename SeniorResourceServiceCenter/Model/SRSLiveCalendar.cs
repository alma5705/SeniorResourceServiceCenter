using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSLiveCalendar
    {
        public int ID { get; set; }
        public string LiveEventID { get; set; }
        public string LiveEventName { get; set; }
        public string LiveEventDescription { get; set; }
        public DateTime LiveEventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public string EventCreatedAgentID { get; set; }
        public string EventAttendeeName { get; set; }
        public string EventVolunteerName { get; set; }
        public SRSClients Clients { get; set; }
    }
}
