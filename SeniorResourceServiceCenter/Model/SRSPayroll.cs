using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SRSPayroll
    {
        private int Id;
        private string payEmpId;
        private bool IsSalary;
        private bool IsHourly;
        private long SalaryYearly;
        private long HourlyRate;
        private bool IsVolunteer; //or intern
        private long NumOfTaxDeductions;
        private long NetPayYearly;
        private int HoursScheduledWorkWeekly;
        private SRSEmployeeInfo EmployeeInfo;
    }
}
