﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirLineAPI.Model
{
    public class PassengerTimeTable
    {
        public long PassengerID { get; set; }
        public Passenger Passenger { get; set; }
        public long TimeTableID { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
