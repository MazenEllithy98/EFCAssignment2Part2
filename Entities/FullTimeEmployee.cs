using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCAssignment2Part2.Entities
{
    internal class FullTimeEmployee : Employee 
    {
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }

    }
}
