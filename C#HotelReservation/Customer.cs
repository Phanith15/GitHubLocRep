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
    
    public partial class Customer
    {
        public Customer()
        {
            this.Occupancies = new HashSet<Occupancy>();
            this.Payments = new HashSet<Payment>();
        }
    
        public string CustomerID { get; set; }
        public string BookedIDFK { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Licence { get; set; }
        public Nullable<int> NumberOfGuest { get; set; }
        public string RoomBooked { get; set; }
        public Nullable<System.DateTime> CheckIn { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
        public Nullable<System.DateTime> BookedFromDate { get; set; }
        public Nullable<System.DateTime> BookedToDate { get; set; }
        public Nullable<double> Balance { get; set; }
        public string RoomStatus { get; set; }
    
        public virtual ICollection<Occupancy> Occupancies { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
