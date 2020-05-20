﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalendarApp.DTO
{
    public class OrderDTO
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
