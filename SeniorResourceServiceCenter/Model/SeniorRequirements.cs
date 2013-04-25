using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class SeniorRequirements
    {
        public int ID { get; set; }
        public int SeniorID { get; set; }
        public int RequirementID { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
