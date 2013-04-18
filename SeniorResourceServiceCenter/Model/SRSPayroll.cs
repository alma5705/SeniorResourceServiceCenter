using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSPayroll
    {
        public  int ID { get; set; }
        public  string payEmpID { get; set; }
        public  bool IsSalary { get; set; }
        public  bool IsHourly { get; set; }
        public  long SalaryYearly { get; set; }
        public  long HourlyRate { get; set; }
        public  bool IsVolunteer { get; set; } //or intern
        public  long NumOfTaxDeductions { get; set; }
        public  long NetPayYearly { get; set; }
        public  int HoursScheduledWorkWeekly { get; set; }
        public  SRSEmployeeInfo EmployeeInfo { get; set; }
    }
}
