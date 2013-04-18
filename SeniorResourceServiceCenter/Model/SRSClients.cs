using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSClients
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long SSN { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string EnrollmentAuthByUserId { get; set; }
        public string ClientSpecialNeed1 { get; set; }
        public string ClientSpecialNeed2 { get; set; }
        public string ClientSpecialNeed3 { get; set; }
        public long PhonePrimary { get; set; }
        public long PhoneSecondary { get; set; }
        public string AddressHouseorAptNumber { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public int AddressZip { get; set; }
        public string ClientEmail { get; set; }
        public string ClientNextOfKinPhoneNumber { get; set; }
        public string ClientNextOfKinFirstName { get; set; }
        public string ClientNextOfKinLastName { get; set; }
        public string ClientNextOfKin2PhoneNumber { get; set; }
        public string ClientNextOfKin2FirstName { get; set; }
        public string ClientNextOfKin2LastName { get; set; }
        public string ClientDOB { get; set; }
        public string ClientCoordinatorId { get; set; }
        public SRSEmployeeInfo EmployeeInfo { get; set; } //collection
        public SRSLiveCalendar LiveCalendar { get; set; } //collection

    }
}
