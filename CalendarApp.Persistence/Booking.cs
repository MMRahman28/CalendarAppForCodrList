//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalendarApp.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public System.Guid Id { get; set; }
        public System.DateTime CheckInDay { get; set; }
        public System.DateTime CheckOutDay { get; set; }
        public int StayDuration { get; set; }
        public bool Paid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
    }
}
