//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Occupancies = new HashSet<Occupancy>();
            this.Payments = new HashSet<Payment>();
        }
    
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Occupancy> Occupancies { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
