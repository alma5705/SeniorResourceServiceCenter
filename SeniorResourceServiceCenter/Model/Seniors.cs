using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorResourceServiceCenter.Model
{
    public class Senior
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public SpecialRequirement Requirement { get; set; }

        //temp values, just for testing
        public string Requirement { get; set; }
        public bool IsSenior { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
