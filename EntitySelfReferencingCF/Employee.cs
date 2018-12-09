using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntitySelfReferencingCF
{
    public class Employee
    {
        // Scalar properties
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int? ManagerID { get; set; }

        // Navigation property
        public Employee Manager { get; set; }
    }
}