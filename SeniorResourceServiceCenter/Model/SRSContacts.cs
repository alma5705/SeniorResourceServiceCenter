using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSContacts
    {
        public int ID { get; set; }
        public string ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public long PhonePrimary { get; set; }
        public long PhoneSecondary { get; set; }
        public long PhoneTeritary { get; set; }
        public bool IsVolunteer { get; set; }
        public bool IsRelative { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public SRSExternalUsers ExternalUsers { get; set; } //collection
    }
}
