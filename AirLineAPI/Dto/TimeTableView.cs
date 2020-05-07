﻿using AirLineAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineAPI.Dto
{
    public class TimeTableView
    {
        public long ID { get; set; }
        public string RouteName { get; set; }
        public string FlightName { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
