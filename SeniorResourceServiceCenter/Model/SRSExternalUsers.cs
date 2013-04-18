using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSExternalUsers
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime UserAdded { get; set; }
        public bool CanAddItem { get; set; }
        public bool CanDelItem { get; set; }
        public bool CanModItem { get; set; }
        public string LiveID { get; set; }
        public string LivePW { get; set; }
        public SRSContacts Contacts { get; set; } //collection
    }
}
