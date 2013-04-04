using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSClients
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private long SSN;
        private DateTime EnrollmentDate;
        private string EnrollmentAuthByUserId;
        private string ClientSpecialNeed1;
        private string ClientSpecialNeed2;
        private string ClientSpecialNeed3;
        private long PhonePrimary;
        private long PhoneSecondary;
        private string AddressHouseorAptNumber;
        private string AddressStreet;
        private string AddressCity;
        private string AddressState;
        private int AddressZip;
        private string ClientEmail;
        private string ClientNextOfKinPhoneNumber;
        private string ClientNextOfKinFirstName;
        private string ClientNextOfKinLastName;
        private string ClientNextOfKin2PhoneNumber;
        private string ClientNextOfKin2FirstName;
        private string ClientNextOfKin2LastName;
        private string ClientDOB;
        private string ClientCoordinatorId;
        private SRSEmployeeInfo EmployeeInfo;
        private SRSLiveCalendar LiveCalendar; //collection

    }
}
